using NengHuan.Models.Sjcj;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace NengHuan.Database.MySQL.ModelsManage
{
    class DeviceRealtimeValueNowManages : DbContext_MySQL<DeviceRealtimeValueNow>
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
            Db.CodeFirst.InitTables(typeof(DeviceRealtimeValueNow));
        }

        // 获取实时数据点位信息
        public override List<DeviceRealtimeValueNow> GetList()
        {
            return Db.Queryable<DeviceRealtimeValueNow>().Where(it => it.DelFlag == false || it.DelFlag == null).OrderBy(it => it.Sid).ToList();
        }
        
        /// <summary>
        /// 批量插入实时数据信息
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>
        public int InsertBatches(List<DeviceRealtimeValueNow> deviceRealtimeValues)
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
        /// <summary>
        /// 批量更新实时数据信息
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>
        public int UpdateBatches(List<DeviceRealtimeValueNow> deviceRealtimeValues)
        {
            return Db.Updateable(deviceRealtimeValues).WhereColumns(it => new { it.Sid }).ExecuteCommand();
        }


        /// <summary>
        /// 通过PassageDeviceNode（点位描述信息，这是表中唯一的，所以可以根据它查询到唯一一条点位的描述信息）
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>

        //以前版本的批量更新设备实时值时遇到了问题。2024/9/1
        //public int UpdateBatchesByPassageDeviceNode(List<DeviceRealtimeValueNow> deviceRealtimeValuesNow)
        //{
        //   return Db.Updateable(deviceRealtimeValuesNow).WhereColumns(it => new { it.PassageDeviceNode }).ExecuteCommand();
        // }
        //新版本批量更新 2024/9/1  将大量的更新操作拆分成小批量进行，减少单次更新涉及的数据量。例如，可以将列表按一定数量分割成多个子列表，然后逐个更新。     
        public void UpdateBatchesByPassageDeviceNode(List<DeviceRealtimeValueNow> deviceRealtimeValuesNow, int batchSize = 100)
        {
            try
            {
                for (int i = 0; i < deviceRealtimeValuesNow.Count; i += batchSize)
                {
                    var batch = deviceRealtimeValuesNow.Skip(i).Take(batchSize).ToList();
                    Db.Updateable(batch).WhereColumns(it => new { it.PassageDeviceNode }).ExecuteCommand();
                    Db.CommitTran();
                }
            }
            catch(Exception ex)
            {
                Db.RollbackTran();
                throw;
            }
            
         }


        /// <summary>
        /// 清空实时数据信息
        /// </summary>
        /// <param name="deviceRealtimeValues"></param>
        /// <returns></returns>
        public int DeleteBatches(List<DeviceRealtimeValue> deviceRealtimeValues)
        {
            return Db.Deleteable(deviceRealtimeValues).ExecuteCommand();
        }

    }
}
