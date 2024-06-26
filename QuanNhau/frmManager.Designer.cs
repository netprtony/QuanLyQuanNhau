﻿namespace QuanNhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.flowLayoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgv_loadTable = new System.Windows.Forms.DataGridView();
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
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_refesh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_actPaid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loadTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdish)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutTable
            // 
            this.flowLayoutTable.Controls.Add(this.dtgv_loadTable);
            this.flowLayoutTable.Location = new System.Drawing.Point(16, 33);
            this.flowLayoutTable.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutTable.Name = "flowLayoutTable";
            this.flowLayoutTable.Size = new System.Drawing.Size(1013, 768);
            this.flowLayoutTable.TabIndex = 0;
            // 
            // dtgv_loadTable
            // 
            this.dtgv_loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loadTable.GridColor = System.Drawing.SystemColors.Control;
            this.dtgv_loadTable.Location = new System.Drawing.Point(3, 3);
            this.dtgv_loadTable.Name = "dtgv_loadTable";
            this.dtgv_loadTable.RowHeadersWidth = 51;
            this.dtgv_loadTable.RowTemplate.Height = 24;
            this.dtgv_loadTable.Size = new System.Drawing.Size(1006, 764);
            this.dtgv_loadTable.TabIndex = 0;
            this.dtgv_loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_loadTable_CellClick);
            this.dtgv_loadTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_loadTable_CellFormatting);
            this.dtgv_loadTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtgv_loadTable_RowPrePaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nud_countdish);
            this.panel1.Controls.Add(this.btn_addDish);
            this.panel1.Controls.Add(this.cb_ItemOfCate);
            this.panel1.Controls.Add(this.cb_lstCate);
            this.panel1.Location = new System.Drawing.Point(1032, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 124);
            this.panel1.TabIndex = 1;
            // 
            // nud_countdish
            // 
            this.nud_countdish.Location = new System.Drawing.Point(503, 53);
            this.nud_countdish.Margin = new System.Windows.Forms.Padding(4);
            this.nud_countdish.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_countdish.Name = "nud_countdish";
            this.nud_countdish.Size = new System.Drawing.Size(59, 22);
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
            this.btn_addDish.Location = new System.Drawing.Point(393, 21);
            this.btn_addDish.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addDish.Name = "btn_addDish";
            this.btn_addDish.Size = new System.Drawing.Size(100, 78);
            this.btn_addDish.TabIndex = 2;
            this.btn_addDish.Text = "Thêm món";
            this.btn_addDish.UseVisualStyleBackColor = true;
            this.btn_addDish.Click += new System.EventHandler(this.btn_addDish_Click);
            // 
            // cb_ItemOfCate
            // 
            this.cb_ItemOfCate.FormattingEnabled = true;
            this.cb_ItemOfCate.Location = new System.Drawing.Point(4, 73);
            this.cb_ItemOfCate.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ItemOfCate.Name = "cb_ItemOfCate";
            this.cb_ItemOfCate.Size = new System.Drawing.Size(367, 24);
            this.cb_ItemOfCate.TabIndex = 1;
            this.cb_ItemOfCate.SelectedIndexChanged += new System.EventHandler(this.cb_addBeverage_SelectedIndexChanged);
            // 
            // cb_lstCate
            // 
            this.cb_lstCate.FormattingEnabled = true;
            this.cb_lstCate.Location = new System.Drawing.Point(4, 21);
            this.cb_lstCate.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lstCate.Name = "cb_lstCate";
            this.cb_lstCate.Size = new System.Drawing.Size(367, 24);
            this.cb_lstCate.TabIndex = 0;
            this.cb_lstCate.SelectedIndexChanged += new System.EventHandler(this.cb_lstCate_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstView_bill);
            this.panel2.Location = new System.Drawing.Point(1037, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 455);
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
            this.lstView_bill.Location = new System.Drawing.Point(4, 4);
            this.lstView_bill.Margin = new System.Windows.Forms.Padding(4);
            this.lstView_bill.Name = "lstView_bill";
            this.lstView_bill.Size = new System.Drawing.Size(595, 447);
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
            this.panel3.Controls.Add(this.tb_discount);
            this.panel3.Controls.Add(this.tb_refesh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lb_actPaid);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lb_totalBill);
            this.panel3.Controls.Add(this.cb_switchTable);
            this.panel3.Controls.Add(this.btn_switchTable);
            this.panel3.Controls.Add(this.btn_pay);
            this.panel3.Location = new System.Drawing.Point(1037, 628);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 174);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(275, 23);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(100, 22);
            this.tb_discount.TabIndex = 13;
            this.tb_discount.Text = "0";
            this.tb_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_discount.TextChanged += new System.EventHandler(this.tb_discount_TextChanged);
            // 
            // tb_refesh
            // 
            this.tb_refesh.Location = new System.Drawing.Point(4, 4);
            this.tb_refesh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_refesh.Name = "tb_refesh";
            this.tb_refesh.Size = new System.Drawing.Size(108, 46);
            this.tb_refesh.TabIndex = 12;
            this.tb_refesh.Text = "Làm mới ";
            this.tb_refesh.UseVisualStyleBackColor = true;
            this.tb_refesh.Click += new System.EventHandler(this.tb_refesh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thực Trả:";
            // 
            // lb_actPaid
            // 
            this.lb_actPaid.AutoSize = true;
            this.lb_actPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_actPaid.Location = new System.Drawing.Point(283, 129);
            this.lb_actPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_actPaid.Name = "lb_actPaid";
            this.lb_actPaid.Size = new System.Drawing.Size(24, 25);
            this.lb_actPaid.TabIndex = 10;
            this.lb_actPaid.Text = "0";
            this.lb_actPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giảm Giá: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thành Tiền:";
            // 
            // lb_totalBill
            // 
            this.lb_totalBill.AutoSize = true;
            this.lb_totalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalBill.Location = new System.Drawing.Point(283, 75);
            this.lb_totalBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_totalBill.Name = "lb_totalBill";
            this.lb_totalBill.Size = new System.Drawing.Size(24, 25);
            this.lb_totalBill.TabIndex = 6;
            this.lb_totalBill.Text = "0";
            this.lb_totalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_switchTable
            // 
            this.cb_switchTable.FormattingEnabled = true;
            this.cb_switchTable.Location = new System.Drawing.Point(4, 75);
            this.cb_switchTable.Margin = new System.Windows.Forms.Padding(4);
            this.cb_switchTable.Name = "cb_switchTable";
            this.cb_switchTable.Size = new System.Drawing.Size(107, 24);
            this.cb_switchTable.TabIndex = 4;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(4, 108);
            this.btn_switchTable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(108, 64);
            this.btn_switchTable.TabIndex = 5;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            this.btn_switchTable.Click += new System.EventHandler(this.btn_switchTable_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(488, 59);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(100, 78);
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
            this.thôngTinToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1645, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.thôngTinToolStripMenuItem.Text = " Thông tin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem,
            this.chuyểnBànToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.chuyểnBànToolStripMenuItem_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 816);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán nhậu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManager_FormClosing);
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.flowLayoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loadTable)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.Button tb_refesh;
        private System.Windows.Forms.DataGridView dtgv_loadTable;
        private System.Windows.Forms.TextBox tb_discount;
    }
}

