using NengHuan.Forms.Common;
using NengHuan.Models.Sjcj;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NengHuan.Database.MySQL.ModelsManage
{
    class DeviceRealtimeValueManages : DbContext_MySQL<DeviceRealtimeValue>
    {
        // 判断表是否存在
        public bool IsExist()
        {
            try
            {
                CurrentDb.GetList();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // 创建表
        public void CreateTable()
        {
            Db.CodeFirst.InitTables(typeof(DeviceRealtimeValue));
        }

        // 获取实时数据点位信息
        public override List<DeviceRealtimeValue> GetList()
        {
            return Db.Queryable<DeviceRealtimeValue>()
                .Where(it => it.DelFlag == false || it.DelFlag == null)
                .OrderBy(it => it.Sid)
                .ToList();
        }

        public override List<DeviceRealtimeValue> GetListForDate(DateTime specifiedDate)
        {
            // 获取指定日期的开始时间和结束时间
            DateTime startDate = specifiedDate.Date; // 当天的 00:00:00
            DateTime endDate = startDate.AddDays(1); // 第二天的 00:00:00
            return Db.Queryable<DeviceRealtimeValue>()
                 .Where(it => (it.DelFlag == false || it.DelFlag == null) &&
                     it.CollectTime >= startDate &&
                     it.CollectTime < endDate)
                .OrderBy(it => it.Sid)
                .ToList();
        }

        /// <summary>
        /// 批量插入实时数据信息
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>
        public int InsertBatches(List<DeviceRealtimeValue> deviceRealtimeValues)
        {
            int v = 0;
            try
            {
                v = Db.Insertable(deviceRealtimeValues).UseParameter().ExecuteCommand();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"InsertBatches：异常 {ex}");
            }
            return v;

        }


        /* public int InsertBatches(List<DeviceRealtimeValue> deviceRealtimeValues, int batchSize = 20)
         {
             int totalInserted = 0;

             // 将列表分割成指定大小的批次
             for (int i = 0; i < deviceRealtimeValues.Count; i += batchSize)
             {
                 var batch = deviceRealtimeValues.GetRange(i, Math.Min(batchSize, deviceRealtimeValues.Count - i));

                 try
                 {
                     // 开始事务
                     Db.Ado.BeginTran();

                     try
                     {
                         // 插入当前批次
                         int inserted = Db.Insertable(batch).UseParameter().ExecuteCommand();

                         // 如果有行被插入，则提交事务
                         if (inserted > 0)
                         {
                             Db.Ado.CommitTran();
                             totalInserted += inserted;
                         }
                         else
                         {
                             // 如果没有行被插入，可以选择回滚事务
                             Db.Ado.RollbackTran();
                             Console.WriteLine($"InsertBatches：没有行被插入");
                         }
                     }
                     catch (Exception ex)
                     {
                         // 发生异常时回滚事务
                         Db.Ado.RollbackTran();
                         Console.WriteLine($"InsertBatches：异常 {ex}");
                         throw;
                     }
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine($"InsertBatches：异常 {ex}");
                     throw;
                 }
             }

             return totalInserted;
         }*/
        public int InsertBatches(List<DeviceRealtimeValue> deviceRealtimeValues, int batchSize = 20)
        {
            int totalInserted = 0;

            // 将列表分割成指定大小的批次
            for (int i = 0; i < deviceRealtimeValues.Count; i += batchSize)
            {
                var batch = deviceRealtimeValues.GetRange(i, Math.Min(batchSize, deviceRealtimeValues.Count - i));

                try
                {
                    // 开始事务
                    Db.Ado.BeginTran();

                    try
                    {
                        // 插入当前批次
                        int inserted = Db.Insertable(batch).UseParameter().ExecuteCommand();

                        // 如果有行被插入，则提交事务
                        if (inserted > 0)
                        {
                            Db.Ado.CommitTran();
                            totalInserted += inserted;
                        }
                        else
                        {
                            // 如果没有行被插入，可以选择回滚事务
                            Db.Ado.RollbackTran();
                            Console.WriteLine($"InsertBatches：没有行被插入");
                        }
                    }
                    catch (Exception ex) when (ex.Message.Contains("Table 'device_realtime_value' doesn't exist"))
                    {
                        // 表不存在，跳过插入操作
                        Db.Ado.RollbackTran();
                        Console.WriteLine("表 'device_realtime_value' 不存在，跳过插入操作。");
                        continue; // 继续下一个批次
                        // 可以在这里进行其他处理，比如创建表或记录日志
                    }
                    catch (Exception ex)
                    {
                        // 发生其他异常时回滚事务
                        Db.Ado.RollbackTran();
                        Console.WriteLine($"InsertBatches：异常 {ex}");
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"InsertBatches：异常 {ex}");
                    throw;
                }
            }

            return totalInserted;
        }

        /// <summary>
        /// 批量更新实时数据信息
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>
        public int UpdateBatches(List<DeviceRealtimeValue> deviceRealtimeValues)
        {
            return Db.Updateable(deviceRealtimeValues).WhereColumns(it => new { it.Sid }).ExecuteCommand();
        }

        /// <summary>
        /// 清空实时数据信息
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>
        /*  public int DeleteBatches(List<DeviceRealtimeValue> deviceRealtimeValues)
          {
              return Db.Deleteable(deviceRealtimeValues).ExecuteCommand();
          }
  */
        public int DeleteBatches(List<DeviceRealtimeValue> deviceRealtimeValues)
        {
            if (deviceRealtimeValues == null || !deviceRealtimeValues.Any())
            {
                return 0;
            }

            const int batchSize = 1000;  // 每批删除的数据量
            int totalDeleted = 0;

            using (var db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = SetupForm.conStr,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            }))
            {
                // 开始事务
                db.Ado.UseTran(() =>
                {
                    for (int i = 0; i < deviceRealtimeValues.Count; i += batchSize)
                    {
                        var batch = deviceRealtimeValues.GetRange(i, Math.Min(batchSize, deviceRealtimeValues.Count - i));
                        Console.WriteLine($"正在删除一批数据，一共 {batch.Count} 条");

                        int deletedCount = db.Deleteable<DeviceRealtimeValue>(batch).ExecuteCommand();
                        totalDeleted += deletedCount;

                        Console.WriteLine($"成功删除了 {deletedCount} 条记录");
                    }
                });

                Console.WriteLine($"总共删除了 {totalDeleted} 条记录");
                return totalDeleted;
            }
        }

    }
}

