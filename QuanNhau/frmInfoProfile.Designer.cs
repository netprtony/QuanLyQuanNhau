
namespace QuanNhau
{
    partial class frmInfoProfile
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
            this.tb_passOld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_passNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rePassNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_resetAcc = new System.Windows.Forms.Button();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tb_disName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_passOld
            // 
            this.tb_passOld.Location = new System.Drawing.Point(149, 107);
            this.tb_passOld.Margin = new System.Windows.Forms.Padding(2);
            this.tb_passOld.Name = "tb_passOld";
            this.tb_passOld.Size = new System.Drawing.Size(190, 20);
            this.tb_passOld.TabIndex = 3;
            this.tb_passOld.Leave += new System.EventHandler(this.tb_userName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // tb_passNew
            // 
            this.tb_passNew.Location = new System.Drawing.Point(149, 149);
            this.tb_passNew.Margin = new System.Windows.Forms.Padding(2);
            this.tb_passNew.Name = "tb_passNew";
            this.tb_passNew.Size = new System.Drawing.Size(190, 20);
            this.tb_passNew.TabIndex = 5;
            this.tb_passNew.Leave += new System.EventHandler(this.tb_userName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // tb_rePassNew
            // 
            this.tb_rePassNew.Location = new System.Drawing.Point(149, 188);
            this.tb_rePassNew.Margin = new System.Windows.Forms.Padding(2);
            this.tb_rePassNew.Name = "tb_rePassNew";
            this.tb_rePassNew.Size = new System.Drawing.Size(190, 20);
            this.tb_rePassNew.TabIndex = 7;
            this.tb_rePassNew.Leave += new System.EventHandler(this.tb_userName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // btn_resetAcc
            // 
            this.btn_resetAcc.Location = new System.Drawing.Point(255, 251);
            this.btn_resetAcc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resetAcc.Name = "btn_resetAcc";
            this.btn_resetAcc.Size = new System.Drawing.Size(84, 41);
            this.btn_resetAcc.TabIndex = 10;
            this.btn_resetAcc.Text = "Cập nhật";
            this.btn_resetAcc.UseVisualStyleBackColor = true;
            this.btn_resetAcc.Click += new System.EventHandler(this.btn_resetAcc_Click);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(149, 65);
            this.tb_userName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(190, 20);
            this.tb_userName.TabIndex = 12;
            this.tb_userName.Leave += new System.EventHandler(this.tb_userName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(358, 251);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 41);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tb_disName
            // 
            this.tb_disName.Location = new System.Drawing.Point(149, 27);
            this.tb_disName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_disName.Name = "tb_disName";
            this.tb_disName.Size = new System.Drawing.Size(190, 20);
            this.tb_disName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên hiển thị";
            // 
            // frmInfoProfile
            // 
            this.AcceptButton = this.btn_resetAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(452, 310);
            this.Controls.Add(this.tb_disName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_resetAcc);
            this.Controls.Add(this.tb_rePassNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_passNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_passOld);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInfoProfile";
            this.Text = "InfoProfile";
            this.Load += new System.EventHandler(this.frmInfoProfile_Load);
            this.Leave += new System.EventHandler(this.tb_userName_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_passOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_passNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_rePassNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_resetAcc;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tb_disName;
        private System.Windows.Forms.Label label5;
    }
}