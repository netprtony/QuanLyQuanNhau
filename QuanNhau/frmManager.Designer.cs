namespace QuanNhau
{
    partial class frmManager
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
            this.flowLayoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_countdish = new System.Windows.Forms.NumericUpDown();
            this.btn_addDish = new System.Windows.Forms.Button();
            this.cb_ItemOfCate = new System.Windows.Forms.ComboBox();
            this.cb_lstCate = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstView_bill = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_totalBill = new System.Windows.Forms.Label();
            this.cb_switchTable = new System.Windows.Forms.ComboBox();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_actPaid = new System.Windows.Forms.Label();
            this.flowLayoutTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdish)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutTable
            // 
            this.flowLayoutTable.Controls.Add(this.flpTable);
            this.flowLayoutTable.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutTable.Name = "flowLayoutTable";
            this.flowLayoutTable.Size = new System.Drawing.Size(760, 624);
            this.flowLayoutTable.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(3, 3);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(753, 621);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nud_countdish);
            this.panel1.Controls.Add(this.btn_addDish);
            this.panel1.Controls.Add(this.cb_ItemOfCate);
            this.panel1.Controls.Add(this.cb_lstCate);
            this.panel1.Location = new System.Drawing.Point(774, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 101);
            this.panel1.TabIndex = 1;
            // 
            // nud_countdish
            // 
            this.nud_countdish.Location = new System.Drawing.Point(377, 43);
            this.nud_countdish.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_countdish.Name = "nud_countdish";
            this.nud_countdish.Size = new System.Drawing.Size(44, 20);
            this.nud_countdish.TabIndex = 3;
            this.nud_countdish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_countdish.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addDish
            // 
            this.btn_addDish.Location = new System.Drawing.Point(295, 17);
            this.btn_addDish.Name = "btn_addDish";
            this.btn_addDish.Size = new System.Drawing.Size(75, 63);
            this.btn_addDish.TabIndex = 2;
            this.btn_addDish.Text = "Thêm món";
            this.btn_addDish.UseVisualStyleBackColor = true;
            this.btn_addDish.Click += new System.EventHandler(this.btn_addDish_Click);
            // 
            // cb_ItemOfCate
            // 
            this.cb_ItemOfCate.FormattingEnabled = true;
            this.cb_ItemOfCate.Location = new System.Drawing.Point(3, 59);
            this.cb_ItemOfCate.Name = "cb_ItemOfCate";
            this.cb_ItemOfCate.Size = new System.Drawing.Size(276, 21);
            this.cb_ItemOfCate.TabIndex = 1;
            this.cb_ItemOfCate.SelectedIndexChanged += new System.EventHandler(this.cb_addBeverage_SelectedIndexChanged);
            // 
            // cb_lstCate
            // 
            this.cb_lstCate.FormattingEnabled = true;
            this.cb_lstCate.Location = new System.Drawing.Point(3, 17);
            this.cb_lstCate.Name = "cb_lstCate";
            this.cb_lstCate.Size = new System.Drawing.Size(276, 21);
            this.cb_lstCate.TabIndex = 0;
            this.cb_lstCate.SelectedIndexChanged += new System.EventHandler(this.cb_lstCate_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstView_bill);
            this.panel2.Location = new System.Drawing.Point(778, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 370);
            this.panel2.TabIndex = 2;
            // 
            // lstView_bill
            // 
            this.lstView_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstView_bill.GridLines = true;
            this.lstView_bill.HideSelection = false;
            this.lstView_bill.Location = new System.Drawing.Point(3, 3);
            this.lstView_bill.Name = "lstView_bill";
            this.lstView_bill.Size = new System.Drawing.Size(447, 364);
            this.lstView_bill.TabIndex = 0;
            this.lstView_bill.UseCompatibleStateImageBehavior = false;
            this.lstView_bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Món";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 34;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 116;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lb_actPaid);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lb_discount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lb_totalBill);
            this.panel3.Controls.Add(this.cb_switchTable);
            this.panel3.Controls.Add(this.btn_switchTable);
            this.panel3.Controls.Add(this.btn_pay);
            this.panel3.Location = new System.Drawing.Point(778, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 141);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thành Tiền:";
            // 
            // lb_totalBill
            // 
            this.lb_totalBill.AutoSize = true;
            this.lb_totalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalBill.Location = new System.Drawing.Point(212, 61);
            this.lb_totalBill.Name = "lb_totalBill";
            this.lb_totalBill.Size = new System.Drawing.Size(19, 20);
            this.lb_totalBill.TabIndex = 6;
            this.lb_totalBill.Text = "0";
            this.lb_totalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_switchTable
            // 
            this.cb_switchTable.FormattingEnabled = true;
            this.cb_switchTable.Location = new System.Drawing.Point(3, 61);
            this.cb_switchTable.Name = "cb_switchTable";
            this.cb_switchTable.Size = new System.Drawing.Size(81, 21);
            this.cb_switchTable.TabIndex = 4;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(3, 88);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(81, 52);
            this.btn_switchTable.TabIndex = 5;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            this.btn_switchTable.Click += new System.EventHandler(this.btn_switchTable_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(366, 48);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 63);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.thôngTinToolStripMenuItem.Text = " Thông tin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giảm Giá: ";
            // 
            // lb_discount
            // 
            this.lb_discount.AutoSize = true;
            this.lb_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_discount.Location = new System.Drawing.Point(212, 19);
            this.lb_discount.Name = "lb_discount";
            this.lb_discount.Size = new System.Drawing.Size(19, 20);
            this.lb_discount.TabIndex = 8;
            this.lb_discount.Text = "0";
            this.lb_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thực Trả:";
            // 
            // lb_actPaid
            // 
            this.lb_actPaid.AutoSize = true;
            this.lb_actPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_actPaid.Location = new System.Drawing.Point(212, 105);
            this.lb_actPaid.Name = "lb_actPaid";
            this.lb_actPaid.Size = new System.Drawing.Size(19, 20);
            this.lb_actPaid.TabIndex = 10;
            this.lb_actPaid.Text = "0";
            this.lb_actPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán nhậu";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.flowLayoutTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdish)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addDish;
        private System.Windows.Forms.ComboBox cb_ItemOfCate;
        private System.Windows.Forms.ComboBox cb_lstCate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_switchTable;
        private System.Windows.Forms.Button btn_switchTable;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ListView lstView_bill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_totalBill;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown nud_countdish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_actPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_discount;
    }
}

