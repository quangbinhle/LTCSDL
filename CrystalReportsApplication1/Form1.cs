using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;

namespace CrystalReportsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt_KHOA;
        DataTable dt_SINHVIEN;
        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(@"Data Source=DESKTOP-KS2AHB8\SQLEXPRESS;Initial Catalog=QLSINHVIEN4;Integrated Security=True");
            da = new SqlDataAdapter("Select * from KHOA", cnn);
            dt_KHOA = new DataTable();
            da.Fill(dt_KHOA);
            //
              da.SelectCommand.CommandText= " select SV.*, K.MaKhoa, K.TenKhoa"
                                        + " from (SINHVIEN SV inner join LOP L on SV.MaLop = L.MaLop)"
                                        + " inner join KHOA K on L.MaKhoa = K.MaKhoa";
            dt_SINHVIEN = new DataTable();
            da.Fill(dt_SINHVIEN);
            //
            cb_MaKhoa.DataSource = dt_KHOA;
            cb_MaKhoa.DisplayMember="TenKhoa";
            cb_MaKhoa.ValueMember="MaKhoa";
            cb_MaKhoa.SelectedIndex=-1;
            //
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(dt_SINHVIEN.DefaultView);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void btn_xuatrp_Click(object sender, EventArgs e)
        {
            dt_SINHVIEN.DefaultView.RowFilter="MaKhoa = '"+cb_MaKhoa.SelectedValue.ToString()+"'";
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(dt_SINHVIEN.DefaultView);
            crystalReportViewer1.ReportSource=rpt;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
