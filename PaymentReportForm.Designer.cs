namespace CafeManagementSystem
{
    partial class PaymentReportForm
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
            this.lsvGeneralReport = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvGeneralReport
            // 
            this.lsvGeneralReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvGeneralReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colDate,
            this.colEmployeeId,
            this.colDetail,
            this.colTotal});
            this.lsvGeneralReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvGeneralReport.FullRowSelect = true;
            this.lsvGeneralReport.GridLines = true;
            this.lsvGeneralReport.HideSelection = false;
            this.lsvGeneralReport.Location = new System.Drawing.Point(16, 153);
            this.lsvGeneralReport.Margin = new System.Windows.Forms.Padding(4);
            this.lsvGeneralReport.Name = "lsvGeneralReport";
            this.lsvGeneralReport.Size = new System.Drawing.Size(1415, 662);
            this.lsvGeneralReport.TabIndex = 15;
            this.lsvGeneralReport.UseCompatibleStateImageBehavior = false;
            this.lsvGeneralReport.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            // 
            // colDate
            // 
            this.colDate.Text = "Thời gian";
            this.colDate.Width = 218;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Text = "Mã nhân viên";
            this.colEmployeeId.Width = 206;
            // 
            // colDetail
            // 
            this.colDetail.DisplayIndex = 4;
            this.colDetail.Text = "Chi Tiết";
            this.colDetail.Width = 421;
            // 
            // colTotal
            // 
            this.colTotal.DisplayIndex = 3;
            this.colTotal.Text = "Tổng tiền";
            this.colTotal.Width = 163;
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmEndDate.Location = new System.Drawing.Point(229, 89);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(331, 38);
            this.dtmEndDate.TabIndex = 16;
            this.dtmEndDate.Value = new System.DateTime(2020, 11, 18, 10, 39, 44, 0);
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmStartDate.Location = new System.Drawing.Point(229, 31);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(331, 38);
            this.dtmStartDate.TabIndex = 16;
            this.dtmStartDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày kết thúc";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirm.FlatAppearance.BorderSize = 5;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = global::CafeManagementSystem.Properties.Resources.icon_search;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(608, 46);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(179, 60);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "   Tìm kiếm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // PaymentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 831);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmStartDate);
            this.Controls.Add(this.dtmEndDate);
            this.Controls.Add(this.lsvGeneralReport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentReportForm";
            this.Text = "PaymentReportForm";
            this.Load += new System.EventHandler(this.PaymentReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvGeneralReport;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colEmployeeId;
        private System.Windows.Forms.ColumnHeader colDetail;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
    }
}