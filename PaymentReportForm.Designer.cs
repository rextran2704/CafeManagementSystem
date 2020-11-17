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
            this.lsvGeneralReport.Location = new System.Drawing.Point(12, 124);
            this.lsvGeneralReport.Name = "lsvGeneralReport";
            this.lsvGeneralReport.Size = new System.Drawing.Size(1062, 539);
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
            this.colDetail.Text = "Chi tiết";
            this.colDetail.Width = 421;
            // 
            // colTotal
            // 
            this.colTotal.DisplayIndex = 3;
            this.colTotal.Text = "Tổng";
            this.colTotal.Width = 149;
            // 
            // PaymentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 675);
            this.Controls.Add(this.lsvGeneralReport);
            this.Name = "PaymentReportForm";
            this.Text = "PaymentReportForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lsvGeneralReport;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colEmployeeId;
        private System.Windows.Forms.ColumnHeader colDetail;
        private System.Windows.Forms.ColumnHeader colTotal;
    }
}