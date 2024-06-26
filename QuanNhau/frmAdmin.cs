﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace QuanNhau
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        DBConnection db = new DBConnection();
        #region Method
        private DataTable GetBillListByDateAndPage(DateTime dateStart, DateTime  dateEnd, int page)
        {
            return db.getDataTable("exec USP_LoadDataBillByDateAndPage '" + dateStart + "', '" + dateEnd + "', '" + page + "'");
        }
        private int GetNumBillByDate(DateTime dateStart, DateTime dateEnd)
        {
            return (int)db.getScalar("exec USP_GetNumBillByDate '" + dateStart + "', '" + dateEnd + "'");
        }
        private DataTable LoadDataBillByDate(DateTime dateStart, DateTime dateEnd)
        {
            return db.getDataTable("exec USP_LoadDataBillByDate  '" + dtp_dateStart.Value + "', '" + dtp_dateEnd.Value + "'");
        }
        private bool CheckPKCoincidence(string ck)
        {
            
            string str = "Select Count(*) from Items where item_id ='" + ck + "'";
            int k = (int)db.getScalar(str);
            return k == 0 ? true : false;
        }
        private void Load_comboxCategory()
        {
            string strQuery = "select * from Categories";
            DataTable dt = db.getDataTable(strQuery);
            DataRow dr = dt.NewRow();
            dr["category_id"] = "All";
            dr["category_name"] = "Tất cả danh mục";
            cb_cateItem.DataSource = dt;
            cb_cateItem.DisplayMember = "category_name";
            cb_cateItem.ValueMember = "category_id";
        }
        private void Load_comboxTypeAccount()
        {
            cb_typeAcc.Items.Add("Admin");
            cb_typeAcc.Items.Add("Staff");
        }
        private void Load_DgvItems(string searchInput = null)
        {
            
            string strView = "exec USP_LoadDataItem N'%"+ searchInput + "%'";
            DataTable dt = db.getDataTable(strView);
            dtgv_Item.DataSource = dt;
        }
        private void Load_DgvCategory()
        {
            
            string strView = "exec USP_LoadDateCategory";
            DataTable dt = db.getDataTable(strView);
            dtgv_cate.DataSource = dt;
        }
        private void Load_DgvTables()
        {
            
            string strView = "exec USP_LoadDataTable";
            DataTable dt = db.getDataTable(strView);
            dtgv_table.DataSource = dt;
        }

        private void Load_DgvBills()
        {
            
            string strView = "exec USP_LoadDataBill";
            DataTable dt = db.getDataTable(strView);
            dtgv_bill.DataSource = dt;
        }
        private void Load_DgvAllOrderOfBill(string idBill)
        {
            
            string strView = "exec USP_GetAllOrderOfBill '"+ idBill + "'";
            DataTable dt = db.getDataTable(strView);
            dtgv_AllorderOfbill.DataSource = dt;
        }
        private void Load_DgvAcc()
        {
            
            string strView = "exec USP_LoadAccount";
            DataTable dt = db.getDataTable(strView);
            dtgv_acc.DataSource = dt;
        }
        #endregion
        #region Events
        private void dtgv_dish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tp_dish_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tp_table_Click(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Load_comboxCategory();
            Load_comboxTypeAccount();
            Load_DgvItems();
            Load_DgvCategory();
            Load_DgvTables();
            Load_DgvBills();
            Load_DgvAcc();
        }

        private void btn_addDish_Click(object sender, EventArgs e)
        {
            if (CheckPKCoincidence(tb_idItem.Text))
            {
                
                string strQuery = "USP_InsertItem '" + tb_idItem.Text + "', N'" + tb_nameItem.Text + "', N'" + tb_despItem.Text + "', " + decimal.Parse(tb_priceItem.Text) + ", N'" + cbo_unit.SelectedItem + "', '" + cb_cateItem.SelectedValue + "'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã  thêm món " + tb_nameItem.Text + " vào thực đơn ", "Thông báo");
                    Load_DgvItems();
                }
                else
                {
                    MessageBox.Show("Món " + tb_nameItem.Text + " thêm vào thực đơn không thành công!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã số " + tb_idItem.Text + " của mặt hàng " + tb_nameItem.Text + " bị trùng mã");
            }
        }

        private void tp_bill_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_dish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_Item.Rows[e.RowIndex];
            tb_idItem.Text = r.Cells[0].Value.ToString();
            tb_nameItem.Text = r.Cells[1].Value.ToString();
            tb_priceItem.Text = r.Cells[3].Value.ToString();
            cb_cateItem.Text = r.Cells[4].Value.ToString();
            tb_despItem.Text = r.Cells[5].Value.ToString();
            cbo_unit.Text = r.Cells[2].Value.ToString();

        }

        private void btn_changeDish_Click(object sender, EventArgs e)
        {
            
            string strQuery = "exec USP_UpdateItem '" + tb_idItem.Text+"', N'"+tb_nameItem.Text+"', N'"+tb_despItem.Text+"', '"+decimal.Parse(tb_priceItem.Text)+"', N'"+cbo_unit.SelectedItem+"', '"+cb_cateItem.SelectedValue+"'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("Mặt hàng " + tb_nameItem.Text + " đã vào thực đơn ", "Thông báo");
                Load_DgvItems();
            }
        }

        private void btn_addCate_Click(object sender, EventArgs e)
        {
            if (CheckPKCoincidence(tb_idCate.Text))
            {
                
                string strQuery = "exec USP_InsertCategory '"+tb_idCate.Text+"', N'"+tb_nameCate.Text+"'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã  thêm danh mục " + tb_nameCate.Text + " vào thực đơn ", "Thông báo");
                    Load_DgvItems();
                }
                else
                {
                    MessageBox.Show("Danh mục " + tb_nameCate.Text + " thêm vào thực đơn không thành công!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã số " + tb_idCate.Text + " của mặt hàng " + tb_nameCate.Text + " bị trùng mã");
            }
            Load_DgvCategory();
        }
        ReadMoney rm = new ReadMoney();
        private void dtgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_bill.Rows[e.RowIndex];
            Load_DgvAllOrderOfBill(r.Cells[0].Value.ToString());
            lb_biliId.Text = r.Cells[0].Value.ToString();
            lb_totalBill.Text = rm.ReadAmountInWords(decimal.Parse(r.Cells[7].Value.ToString()));
        }

        private void dtgv_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delCate_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có xóa danh mục " + tb_nameCate.Text + " không?", "Thông báo xóa danh mục!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "exec USP_DeleteCategory '"+tb_idCate.Text+"'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã xóa danh mục " + tb_nameCate.Text + "", "Thông báo");
                    Load_DgvCategory();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dtgv_cate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_cate.Rows[e.RowIndex];
            tb_idCate.Text = r.Cells[0].Value.ToString();
            tb_nameCate.Text = r.Cells[1].Value.ToString();
        }

        private void btn_delItem_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có xóa mặt hàng " + tb_nameCate.Text + " không?", "Thông báo xóa mặt hàng!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "exec USP_DeleteItem '"+tb_idItem.Text+"'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã xóa mặt hàng " + tb_nameItem.Text + "", "Thông báo");
                    Load_DgvItems();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dtgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_table.Rows[e.RowIndex];
            tb_idTable.Text = r.Cells[0].Value.ToString();
            tb_nameTable.Text = r.Cells[1].Value.ToString();
        }

        private void btn_addTable_Click(object sender, EventArgs e)
        {
            if (CheckPKCoincidence(tb_idTable.Text))
            {
                
                string strQuery = "exec USP_insertTable '" + tb_idTable.Text + "', N'" + tb_nameTable.Text + "'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã thêm " + tb_nameTable.Text + " vào ", "Thông báo");
                    Load_DgvItems();
                }
                else
                {
                    MessageBox.Show("" + tb_nameTable.Text + " thêm không thành công!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã số " + tb_idTable.Text + " của " + tb_nameTable.Text + " bị trùng mã");
            }
            Load_DgvTables();
        }

        private void btn_changeTable_Click(object sender, EventArgs e)
        {
            
            string strQuery = "exec USP_UpdateTable '" + tb_idTable.Text + "', N'" + tb_nameTable.Text + "'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("" + tb_nameTable.Text + " đã được sửa thành công  ", "Thông báo");
            }
            Load_DgvTables();
        }

        private void btn_changeCate_Click(object sender, EventArgs e)
        {
            
            string strQuery = "exec USP_UpdateCategory '" + tb_idCate.Text + "', N'" + tb_nameCate.Text + "'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("Danh mục " + tb_nameCate.Text + " đã được sửa thành công  ", "Thông báo");
            }
            Load_DgvCategory();
        }

        private void btn_delTable_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có xóa bàn " + tb_nameTable.Text + " không?", "Thông báo xóa bàn!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "exec USP_DeleteTable '" + tb_idTable.Text + "'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã xóa " + tb_nameTable.Text + "", "Thông báo");
                    Load_DgvTables();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btn_addAcc_Click(object sender, EventArgs e)
        {
            if (CheckPKCoincidence(tb_username.Text))
            {
                
                bool isAdmin = true ? cb_typeAcc.Text == "Admin" : false;
                string strQuery = "exec USP_InsertAccount N'" + tb_displayAcc.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "', '" + isAdmin + "'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã thêm tài khoản " + tb_username.Text + " vào ", "Thông báo");
                    Load_DgvItems();
                }
                else
                {
                    MessageBox.Show("Tài khoản" + tb_username.Text + " thêm không thành công!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên đăng nhập " + tb_username.Text + " của " + tb_username.Text + " bị trùng mã");
            }
            Load_DgvAcc();
        }

        private void dtgv_acc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_acc.Rows[e.RowIndex];
            tb_displayAcc.Text = r.Cells[0].Value.ToString();
            tb_username.Text = r.Cells[1].Value.ToString();
            tb_pass.Text = r.Cells[2].Value.ToString();
            cb_typeAcc.Text = r.Cells[3].Value.ToString();
        }

        private void btn_delAcc_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản " + tb_nameTable.Text + " không?", "Thông báo xóa tài khoản!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "exec USP_DeleteAccount '" + tb_username.Text + "'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã xóa tài khoản " + tb_username.Text + "", "Thông báo");
                    Load_DgvAcc();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btn_changeAcc_Click(object sender, EventArgs e)
        {
            
            bool isAdmin = true ? cb_typeAcc.Text == "Admin" : false;
            string strQuery = "exec USP_UpdateAccount N'" + tb_displayAcc.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "', '" + isAdmin + "'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("Tài khoản " + tb_username.Text + " đã được sửa thành công  ", "Thông báo");
            }
            Load_DgvAcc();
        }
        

        private void btn_findItem_Click(object sender, EventArgs e)
        {
            Load_DgvItems(tb_findItem.Text);
        }
        #endregion

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            dtgv_bill.DataSource = LoadDataBillByDate(dtp_dateStart.Value, dtp_dateEnd.Value);
        }

        private void btn_firstPage_Click(object sender, EventArgs e)
        {
            tb_numPage.Text = "1";
        }

        private void btn_lastPage_Click(object sender, EventArgs e)
        {
            int sum = GetNumBillByDate(dtp_dateStart.Value, dtp_dateEnd.Value);
            int lastPage = sum / 10;
            if (sum % 10 != 0) lastPage++;
            tb_numPage.Text = lastPage.ToString();
        }

        private void tb_numPage_TextChanged(object sender, EventArgs e)
        {
            dtgv_bill.DataSource = GetBillListByDateAndPage(dtp_dateStart.Value, dtp_dateEnd.Value, int.Parse(tb_numPage.Text));
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            int page = int.Parse(tb_numPage.Text);
            int sum = GetNumBillByDate(dtp_dateStart.Value, dtp_dateEnd.Value);
            if (page < sum) page++;
            tb_numPage.Text = page.ToString();

        }
        private void btn_prePage_Click(object sender, EventArgs e)
        {
            
            int page = int.Parse(tb_numPage.Text);
            if (page > 1) page--;
            tb_numPage.Text = page.ToString();
        }

        private void dtgv_bill_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color rowColor = (e.RowIndex % 2 == 0) ? Color.White : Color.LightGray;

            dtgv_bill.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
        }

        private void dtgv_AllorderOfbill_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color rowColor = (e.RowIndex % 2 == 0) ? Color.White : Color.LightGray;

            dtgv_AllorderOfbill.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
        }

        private void dtgv_Item_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color rowColor = (e.RowIndex % 2 == 0) ? Color.White : Color.LightGray;

            dtgv_Item.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
        }

        private void dtgv_cate_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color rowColor = (e.RowIndex % 2 == 0) ? Color.White : Color.LightGray;

            dtgv_cate.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
        }

        private void dtgv_table_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color rowColor = (e.RowIndex % 2 == 0) ? Color.White : Color.LightGray;

            dtgv_table.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
        }

        private void dtgv_acc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color rowColor = (e.RowIndex % 2 == 0) ? Color.White : Color.LightGray;

            dtgv_acc.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
        }
    }
}

