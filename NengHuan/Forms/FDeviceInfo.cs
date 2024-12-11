using MySql.Data.MySqlClient;
using NengHuan.Database.MySQL.ModelsManage;

using NengHuan.Models.Sjcj;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NengHuan.Forms
{
    public partial class FDeviceInfo : UIForm
    {

        private string connectionString = "Server=127.0.0.1;Database=yethannyhj;User ID=root;Password=123456;Port=3306;";

        public FDeviceInfo()
        {
            InitializeComponent();

        }

        private void FDeviceInfo_Load(object sender, EventArgs e)
        {
            // 判断表是否存在，不存在则创建
            if(!new BaseDataDeviceManages().IsExist())
            {
                new BaseDataDeviceManages().CreateTable();
            }

            //RefreshData();
            // 获取数据
            LoadDeviceTypeData();

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {

        }

        #region 刷新数据
        public void RefreshData()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("设备名称", typeof(string));
            dataTable.Columns.Add("设备类型", typeof(string));
            dataTable.Columns.Add("点位描述", typeof(string));
            dataTable.Columns.Add("父设备名称", typeof(string));
            dataTable.Columns.Add("所属系统名称", typeof(string));
            dataTable.Columns.Add("安装位置", typeof(string));
            dataTable.Columns.Add("创建时间", typeof(string));
            dataTable.Columns.Add("最后更新时间", typeof(string));
            udgv_UInfo.DataSource = dataTable;

            List<BaseDataDevice> baseDataDevices = new List<BaseDataDevice>();
            baseDataDevices = new BaseDataDeviceManages().GetList();
            foreach(BaseDataDevice device in baseDataDevices)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["设备名称"] = device.DeviceName;
                dataRow["设备类型"] = device.TypeName;
                dataRow["点位描述"] = device.NodeDescribe;
                dataRow["父设备名称"] = device.ParentDeviceName;
                dataRow["所属系统名称"] = device.SystemName;
                dataRow["安装位置"] = device.Location;
                dataRow["创建时间"] = device.CreateTime;
                dataRow["最后更新时间"] = device.ModifyTime;
                dataTable.Rows.Add(dataRow);
            }
           
            //this.dataGridView1.Columns[1].HeaderText = "序号";
            //this.dataGridView1.Columns[2].HeaderText = "设备名称";
            //this.dataGridView1.Columns[3].HeaderText = "设备类型";
            //this.dataGridView1.Columns[4].HeaderText = "节点描述";
            //this.dataGridView1.Columns[5].HeaderText = "父设备名称";
            //this.dataGridView1.Columns[6].HeaderText = "所属系统名称";
            //this.dataGridView1.Columns[7].HeaderText = "安装位置";
            //this.dataGridView1.Columns[8].HeaderText = "创建时间";
            //this.dataGridView1.Columns[9].HeaderText = "最后更新时间";
            //调整列宽，以适合该列中的所有单元格的内容，包括标题单元格。
            foreach (DataGridViewColumn column in udgv_UInfo.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }


        #endregion

        private void LoadDeviceTypeData()
        {
            try
            {
                // 创建连接对象
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT deviceTypeName FROM dict_device_type";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("设备类型", typeof(string));
                            dataTable.Columns.Add("量程", typeof(string));
                            dataTable.Columns.Add("校准规则", typeof(string));

                            while (reader.Read())
                            {
                                DataRow row = dataTable.NewRow();
                                row["设备类型"] = reader["deviceTypeName"].ToString();
                                row["量程"] = "0-100"; // 自行添加，可以设置为空
                                row["校准规则"] = "y=ax+b"; // 自行添加，可以设置为空
                                dataTable.Rows.Add(row);
                            }

                        
                            udgv_UInfo.DataSource = dataTable;
                            udgv_UInfo.RowHeadersVisible = false;
                            // 调整列宽
                            foreach (DataGridViewColumn column in udgv_UInfo.Columns)
                            {
                                column.Width = 300;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载设备类型数据时发生错误: " + ex.Message);
            }
        }

        private void udgv_UInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (udgv_UInfo.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedRow = udgv_UInfo.SelectedRows[0];
                utxt_UnitKind.Text = selectedRow.Cells["设备类型"].Value?.ToString();
                utxt_UnitRange.Text = selectedRow.Cells["量程"].Value?.ToString();
                utxt_UnitRule.Text = selectedRow.Cells["校准规则"].Value?.ToString();
            }
        }

    }
}
