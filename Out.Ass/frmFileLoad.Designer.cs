namespace Outsurance_Ass
{
    partial class frmFileLoad
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
            this.btnGetFileData = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.dgViewData = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.btReport = new System.Windows.Forms.Button();
            this.lblReportLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetFileData
            // 
            this.btnGetFileData.Location = new System.Drawing.Point(12, 12);
            this.btnGetFileData.Name = "btnGetFileData";
            this.btnGetFileData.Size = new System.Drawing.Size(107, 23);
            this.btnGetFileData.TabIndex = 0;
            this.btnGetFileData.Text = "Get File Data";
            this.btnGetFileData.UseVisualStyleBackColor = true;
            this.btnGetFileData.Click += new System.EventHandler(this.btnGetFileData_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 47);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(60, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File Name: ";
            // 
            // dgViewData
            // 
            this.dgViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewData.Location = new System.Drawing.Point(12, 63);
            this.dgViewData.Name = "dgViewData";
            this.dgViewData.Size = new System.Drawing.Size(461, 150);
            this.dgViewData.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(88, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 3;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(12, 219);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(107, 23);
            this.btReport.TabIndex = 4;
            this.btReport.Text = "Report File Data";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // lblReportLocation
            // 
            this.lblReportLocation.AutoSize = true;
            this.lblReportLocation.Location = new System.Drawing.Point(109, 248);
            this.lblReportLocation.Name = "lblReportLocation";
            this.lblReportLocation.Size = new System.Drawing.Size(0, 13);
            this.lblReportLocation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report Location: ";
            // 
            // frmFileLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 270);
            this.Controls.Add(this.lblReportLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgViewData);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnGetFileData);
            this.Name = "frmFileLoad";
            this.Text = "Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetFileData;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.DataGridView dgViewData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Label lblReportLocation;
        private System.Windows.Forms.Label label2;
    }
}

