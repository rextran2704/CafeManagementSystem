namespace CafeManagementSystem
{
    partial class GeneralReportForm
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
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsvGeneralReport
            // 
            this.lsvGeneralReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvGeneralReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colIncome,
            this.colPayment,
            this.colProfit});
            this.lsvGeneralReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvGeneralReport.FullRowSelect = true;
            this.lsvGeneralReport.GridLines = true;
            this.lsvGeneralReport.HideSelection = false;
            this.lsvGeneralReport.Location = new System.Drawing.Point(12, 132);
            this.lsvGeneralReport.Name = "lsvGeneralReport";
            this.lsvGeneralReport.Size = new System.Drawing.Size(1062, 531);
            this.lsvGeneralReport.TabIndex = 1;
            this.lsvGeneralReport.UseCompatibleStateImageBehavior = false;
            this.lsvGeneralReport.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Thời gian";
            this.colDate.Width = 300;
            // 
            // colIncome
            // 
            this.colIncome.Text = "Thu";
            this.colIncome.Width = 210;
            // 
            // colPayment
            // 
            this.colPayment.Text = "Chi";
            this.colPayment.Width = 210;
            // 
            // colProfit
            // 
            this.colProfit.Text = "Lợi nhuận";
            this.colProfit.Width = 300;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.comboBox1.Location = new System.Drawing.Point(159, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 39);
            this.comboBox1.TabIndex = 2;
            // 
            // GeneralReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 675);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lsvGeneralReport);
            this.Name = "GeneralReportForm";
            this.Text = "GeneralReportForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lsvGeneralReport;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colIncome;
        private System.Windows.Forms.ColumnHeader colPayment;
        private System.Windows.Forms.ColumnHeader colProfit;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}