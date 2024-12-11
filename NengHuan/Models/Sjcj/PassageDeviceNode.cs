using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NengHuan.Models.Sjcj
{
    [SugarTable("passage_device_node")]
    class PassageDeviceNode 
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "sid")]
        public int Sid { get; set; } // 序号，自增字段

        [SugarColumn(IsNullable = true, ColumnName = "passage_device_node", ColumnDataType = "varchar", Length = 100)]
        public string PsgDeviceNode { get; set; } // 通道.设备.点位

        [SugarColumn(IsNullable = true, ColumnName = "passage", ColumnDataType = "varchar", Length = 100)]
        public string Passage { get; set; } // 通道名称

        [SugarColumn(IsNullable = true, ColumnName = "device_id", ColumnDataType = "varchar", Length = 100)]
        public string DeviceId { get; set; } // 设备编号

        [SugarColumn(IsNullable = true, ColumnName = "device_name", ColumnDataType = "varchar", Length = 100)]
        public string DeviceName { get; set; } // 设备名称

        [SugarColumn(IsNullable = true, ColumnName = "node_id", ColumnDataType = "varchar", Length = 100)]
        public string NodeId { get; set; } // 点位id

        [SugarColumn(IsNullable = true, ColumnName = "node_describe", ColumnDataType = "varchar", Length = 100)]
        public string NodeDescribe { get; set; } // 点位描述

        [SugarColumn(IsNullable = true, ColumnName = "device_type_id", ColumnDataType = "varchar", Length = 100)]
        public string DeviceTypeId { get; set; } // 设备类型id

        [SugarColumn(IsNullable = true, ColumnName = "device_type_name", ColumnDataType = "varchar", Length = 100)]
        public string DeviceTypeName { get; set; } // 设备类型名称

        [SugarColumn(IsNullable = true, ColumnName = "parent_dev_id", ColumnDataType = "varchar", Length = 100)]
        public string ParentDevId { get; set; } // 父设备Id

        [SugarColumn(IsNullable = true, ColumnName = "parent_dev_name", ColumnDataType = "varchar", Length = 100)]
        public string ParentDevName { get; set; } // 父设备名称

        [SugarColumn(IsNullable = true, ColumnName = "value_type", ColumnDataType = "varchar", Length = 100)]
        public string ValueType { get; set; } // 信号值属性
    }
}
