namespace CrystalReportsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cachedCrystalReport11 = new CrystalReportsApplication1.CachedCrystalReport1();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xuatrp = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cb_MaKhoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 51);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1240, 720);
            this.crystalReportViewer1.TabIndex = 10;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn Khoa";
            // 
            // btn_xuatrp
            // 
            this.btn_xuatrp.Location = new System.Drawing.Point(202, 12);
            this.btn_xuatrp.Name = "btn_xuatrp";
            this.btn_xuatrp.Size = new System.Drawing.Size(75, 23);
            this.btn_xuatrp.TabIndex = 7;
            this.btn_xuatrp.Text = "Xuất Report";
            this.btn_xuatrp.UseVisualStyleBackColor = true;
            this.btn_xuatrp.Click += new System.EventHandler(this.btn_xuatrp_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(283, 13);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cb_MaKhoa
            // 
            this.cb_MaKhoa.FormattingEnabled = true;
            this.cb_MaKhoa.Location = new System.Drawing.Point(75, 12);
            this.cb_MaKhoa.Name = "cb_MaKhoa";
            this.cb_MaKhoa.Size = new System.Drawing.Size(121, 21);
            this.cb_MaKhoa.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 443);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cb_MaKhoa);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xuatrp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CachedCrystalReport1 cachedCrystalReport11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xuatrp;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cb_MaKhoa;

    }
}

