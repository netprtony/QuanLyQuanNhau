
namespace QuanNhau
{
    partial class InfoProfile
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
            this.tb_passOld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_passNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rePassNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_resetAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_passOld
            // 
            this.tb_passOld.Location = new System.Drawing.Point(230, 43);
            this.tb_passOld.Name = "tb_passOld";
            this.tb_passOld.Size = new System.Drawing.Size(252, 22);
            this.tb_passOld.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // tb_passNew
            // 
            this.tb_passNew.Location = new System.Drawing.Point(230, 98);
            this.tb_passNew.Name = "tb_passNew";
            this.tb_passNew.Size = new System.Drawing.Size(252, 22);
            this.tb_passNew.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // tb_rePassNew
            // 
            this.tb_rePassNew.Location = new System.Drawing.Point(230, 164);
            this.tb_rePassNew.Name = "tb_rePassNew";
            this.tb_rePassNew.Size = new System.Drawing.Size(252, 22);
            this.tb_rePassNew.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // btn_resetAcc
            // 
            this.btn_resetAcc.Location = new System.Drawing.Point(403, 222);
            this.btn_resetAcc.Name = "btn_resetAcc";
            this.btn_resetAcc.Size = new System.Drawing.Size(112, 50);
            this.btn_resetAcc.TabIndex = 10;
            this.btn_resetAcc.Text = "Đặt lại mật khẩu";
            this.btn_resetAcc.UseVisualStyleBackColor = true;
            this.btn_resetAcc.Click += new System.EventHandler(this.btn_resetAcc_Click);
            // 
            // InfoProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 295);
            this.Controls.Add(this.btn_resetAcc);
            this.Controls.Add(this.tb_rePassNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_passNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_passOld);
            this.Controls.Add(this.label2);
            this.Name = "InfoProfile";
            this.Text = "InfoProfile";
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
    }
}