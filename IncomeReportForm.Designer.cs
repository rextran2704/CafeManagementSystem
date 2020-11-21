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
            this.lsvReceipt = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvReceiptDetail = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lsvReceipt
            // 
            this.lsvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colDate,
            this.colEmployeeId,
            this.colTotal});
            this.lsvReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvReceipt.FullRowSelect = true;
            this.lsvReceipt.GridLines = true;
            this.lsvReceipt.HideSelection = false;
            this.lsvReceipt.Location = new System.Drawing.Point(16, 153);
            this.lsvReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.lsvReceipt.Name = "lsvReceipt";
            this.lsvReceipt.Size = new System.Drawing.Size(819, 742);
            this.lsvReceipt.TabIndex = 15;
            this.lsvReceipt.UseCompatibleStateImageBehavior = false;
            this.lsvReceipt.View = System.Windows.Forms.View.Details;
            this.lsvReceipt.SelectedIndexChanged += new System.EventHandler(this.lsvReceipt_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            // 
            // colDate
            // 
            this.colDate.Text = "Thời gian";
            this.colDate.Width = 259;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.Text = "Mã nhân viên";
            this.colEmployeeId.Width = 173;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Tổng";
            this.colTotal.Width = 116;
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
            this.lsvReceiptDetail.Location = new System.Drawing.Point(844, 153);
            this.lsvReceiptDetail.Margin = new System.Windows.Forms.Padding(4);
            this.lsvReceiptDetail.MultiSelect = false;
            this.lsvReceiptDetail.Name = "lsvReceiptDetail";
            this.lsvReceiptDetail.Size = new System.Drawing.Size(679, 742);
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
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirm.FlatAppearance.BorderSize = 5;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = global::CafeManagementSystem.Properties.Resources.icon_search;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(619, 43);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(179, 60);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "   Tìm kiếm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmStartDate.Location = new System.Drawing.Point(240, 28);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(331, 38);
            this.dtmStartDate.TabIndex = 19;
            this.dtmStartDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmEndDate.Location = new System.Drawing.Point(240, 86);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(331, 38);
            this.dtmEndDate.TabIndex = 20;
            this.dtmEndDate.Value = new System.DateTime(2020, 11, 21, 23, 10, 38, 0);
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmStartDate);
            this.Controls.Add(this.dtmEndDate);
            this.Controls.Add(this.lsvReceiptDetail);
            this.Controls.Add(this.lsvReceipt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IncomeReportForm";
            this.Text = "PaymentReportForm";
            this.Load += new System.EventHandler(this.IncomeReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvReceipt;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colEmployeeId;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ListView lsvReceiptDetail;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
    }
}