using NengHuan.Models.Sjcj;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NengHuan.Database.MySQL.ModelsManage
{
    class PassageDeviceNodeManages : DbContext_MySQL<PassageDeviceNode>
    {
        /// <summary>
        /// 获取所有已配置的点位信息
        /// </summary>
        /// <returns></returns>
       public List<PassageDeviceNode> GetPsgDeviceNodeIds()
        {
            // Sid{11-13}范围内的点位不存在可以直接过滤掉
            return Db.Queryable<PassageDeviceNode>().Where(it => it.Sid < 11 || it.Sid > 20).ToList();
        }

        /// <summary>
        /// 通过字符串匹配获取设备类型名称信息
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public string GetByStringMatch(string searchString)
        {
            return Db.Queryable<PassageDeviceNode>()
                     .Where(it => it.PsgDeviceNode == searchString)
                     .Select(it => it.DeviceTypeName)
                     .ToList().First();

        }
        /// <summary>
        /// 按着设备类型分组查询返回点位信息字典表
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<NodeId>> GetPsgDeviceNodeIdsByType()
        {
            // 查询并分组
            Dictionary<string, List<NodeId>> deviceMap = Db.Queryable<PassageDeviceNode>()
                .Where(p => p.Sid > 20 || p.Sid < 11) // 过滤条件
                .Select(p => new { p.DeviceTypeName, p.PsgDeviceNode }) // 选择字段
                .ToList()
                .GroupBy(p => p.DeviceTypeName ?? "其他") // 按设备类型名称分组，为空则分到“其他”组
                .ToDictionary(
                    k => k.Key, // 设备类型名称作为键
                    v => v.Select(n => new NodeId(n.PsgDeviceNode)).ToList() // 将设备节点名称列表作为值
                );
            return deviceMap;
        }

    }
}
