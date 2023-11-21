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
            this.cb_addBeverage = new System.Windows.Forms.ComboBox();
            this.cb_addDish = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstView_bill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_switchTable = new System.Windows.Forms.ComboBox();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.flowLayoutTable.Size = new System.Drawing.Size(780, 583);
            this.flowLayoutTable.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(3, 3);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(771, 580);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nud_countdish);
            this.panel1.Controls.Add(this.btn_addDish);
            this.panel1.Controls.Add(this.cb_addBeverage);
            this.panel1.Controls.Add(this.cb_addDish);
            this.panel1.Location = new System.Drawing.Point(798, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 101);
            this.panel1.TabIndex = 1;
            // 
            // nud_countdish
            // 
            this.nud_countdish.Location = new System.Drawing.Point(376, 40);
            this.nud_countdish.Name = "nud_countdish";
            this.nud_countdish.Size = new System.Drawing.Size(51, 20);
            this.nud_countdish.TabIndex = 3;
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
            // 
            // cb_addBeverage
            // 
            this.cb_addBeverage.FormattingEnabled = true;
            this.cb_addBeverage.Location = new System.Drawing.Point(3, 59);
            this.cb_addBeverage.Name = "cb_addBeverage";
            this.cb_addBeverage.Size = new System.Drawing.Size(276, 21);
            this.cb_addBeverage.TabIndex = 1;
            this.cb_addBeverage.SelectedIndexChanged += new System.EventHandler(this.cb_addBeverage_SelectedIndexChanged);
            // 
            // cb_addDish
            // 
            this.cb_addDish.FormattingEnabled = true;
            this.cb_addDish.Location = new System.Drawing.Point(3, 17);
            this.cb_addDish.Name = "cb_addDish";
            this.cb_addDish.Size = new System.Drawing.Size(276, 21);
            this.cb_addDish.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstView_bill);
            this.panel2.Location = new System.Drawing.Point(798, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 370);
            this.panel2.TabIndex = 2;
            // 
            // lstView_bill
            // 
            this.lstView_bill.HideSelection = false;
            this.lstView_bill.Location = new System.Drawing.Point(3, 3);
            this.lstView_bill.Name = "lstView_bill";
            this.lstView_bill.Size = new System.Drawing.Size(424, 364);
            this.lstView_bill.TabIndex = 0;
            this.lstView_bill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_switchTable);
            this.panel3.Controls.Add(this.btn_switchTable);
            this.panel3.Controls.Add(this.btn_pay);
            this.panel3.Location = new System.Drawing.Point(798, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 100);
            this.panel3.TabIndex = 2;
            // 
            // cb_switchTable
            // 
            this.cb_switchTable.FormattingEnabled = true;
            this.cb_switchTable.Location = new System.Drawing.Point(107, 41);
            this.cb_switchTable.Name = "cb_switchTable";
            this.cb_switchTable.Size = new System.Drawing.Size(100, 21);
            this.cb_switchTable.TabIndex = 4;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(14, 32);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(87, 37);
            this.btn_switchTable.TabIndex = 5;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(327, 19);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 63);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
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
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 622);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nud_countdish;
        private System.Windows.Forms.Button btn_addDish;
        private System.Windows.Forms.ComboBox cb_addBeverage;
        private System.Windows.Forms.ComboBox cb_addDish;
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
    }
}

