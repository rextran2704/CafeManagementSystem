namespace CafeManagementSystem
{
    partial class IncomeReportForm
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
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvReceiptDetail = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colTotal});
            this.lsvGeneralReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvGeneralReport.FullRowSelect = true;
            this.lsvGeneralReport.GridLines = true;
            this.lsvGeneralReport.HideSelection = false;
            this.lsvGeneralReport.Location = new System.Drawing.Point(12, 124);
            this.lsvGeneralReport.Name = "lsvGeneralReport";
            this.lsvGeneralReport.Size = new System.Drawing.Size(615, 551);
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
            this.colDate.Width = 202;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Text = "Mã nhân viên";
            this.colEmployeeId.Width = 173;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Tổng";
            this.colTotal.Width = 175;
            // 
            // lsvReceiptDetail
            // 
            this.lsvReceiptDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvReceiptDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colQuantity,
            this.colPrice});
            this.lsvReceiptDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvReceiptDetail.FullRowSelect = true;
            this.lsvReceiptDetail.GridLines = true;
            this.lsvReceiptDetail.HideSelection = false;
            this.lsvReceiptDetail.Location = new System.Drawing.Point(633, 124);
            this.lsvReceiptDetail.MultiSelect = false;
            this.lsvReceiptDetail.Name = "lsvReceiptDetail";
            this.lsvReceiptDetail.Size = new System.Drawing.Size(510, 551);
            this.lsvReceiptDetail.TabIndex = 16;
            this.lsvReceiptDetail.UseCompatibleStateImageBehavior = false;
            this.lsvReceiptDetail.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Tên món";
            this.colName.Width = 238;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            this.colQuantity.Width = 120;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Thành tiền";
            this.colPrice.Width = 147;
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.lsvReceiptDetail);
            this.Controls.Add(this.lsvGeneralReport);
            this.Name = "IncomeReportForm";
            this.Text = "PaymentReportForm";
            this.Load += new System.EventHandler(this.IncomeReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lsvGeneralReport;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colEmployeeId;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ListView lsvReceiptDetail;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colPrice;
    }
}