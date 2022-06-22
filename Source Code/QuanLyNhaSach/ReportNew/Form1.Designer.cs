
namespace ReportNew
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ThongKeDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNhaSachDataSet = new ReportNew.QLNhaSachDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeDoanhThuTableAdapter = new ReportNew.QLNhaSachDataSetTableAdapters.ThongKeDoanhThuTableAdapter();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNhaSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongKeDoanhThuBindingSource
            // 
            this.ThongKeDoanhThuBindingSource.DataMember = "ThongKeDoanhThu";
            this.ThongKeDoanhThuBindingSource.DataSource = this.QLNhaSachDataSet;
            // 
            // QLNhaSachDataSet
            // 
            this.QLNhaSachDataSet.DataSetName = "QLNhaSachDataSet";
            this.QLNhaSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ThongKeDoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportNew.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(91, 236);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1500, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeDoanhThuTableAdapter
            // 
            this.ThongKeDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeStart.Location = new System.Drawing.Point(217, 151);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(200, 27);
            this.dtpTimeStart.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(634, 139);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 39);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống Kê Theo Tháng\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn năm bắt đầu\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNhaSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeDoanhThuBindingSource;
        private QLNhaSachDataSet QLNhaSachDataSet;
        private QLNhaSachDataSetTableAdapters.ThongKeDoanhThuTableAdapter ThongKeDoanhThuTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

