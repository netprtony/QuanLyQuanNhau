using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QuanNhau
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        #region Method
        private bool CheckPKCoincidence(string ck)
        {
            BDConnection db = new BDConnection();
            string str = "Select Count(*) from Items where item_id ='" + ck + "'";
            int k = (int)db.getScalar(str);
            return k == 0 ? true : false;
        }
        private void Load_comboxCategory()
        {
            BDConnection db = new BDConnection();
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
        private void Load_DgvItems()
        {
            BDConnection db = new BDConnection();
            string strView = "select i.item_id as 'ID', i.item_name as N'Mặt hàng', i.item_unit as N'ĐVT' , i.item_price as N'Giá', c.category_name as N'Danh mục', i.item_description as N'Mô tả', item_unit as N'Đơn vị' from Items i, Categories c where c.category_id = i.category_id";
            DataTable dt = db.getDataTable(strView);
            dtgv_Item.DataSource = dt;
        }
        private void Load_DgvCategory()
        {
            BDConnection db = new BDConnection();
            string strView = "select category_id as 'ID', category_name as N'Tên danh mục' from Categories";
            DataTable dt = db.getDataTable(strView);
            dtgv_cate.DataSource = dt;
        }
        private void Load_DgvTables()
        {
            BDConnection db = new BDConnection();
            string strView = "select table_id as 'ID', table_name as N'Tên bàn' from Tables ";
            DataTable dt = db.getDataTable(strView);
            dtgv_table.DataSource = dt;
        }

        private void Load_DgvBills()
        {
            BDConnection db = new BDConnection();
            string strView = "select b.bill_id as N'Mã hóa đơn', t.table_name as N'Bàn khách ngồi', b.cashier_id as N'Thu ngân', FORMAT(b.dateCheckin, 'HH:mm:ss') as N'Giờ vào', FORMAT(b.dateCheckout, 'HH:mm:ss') as N'Giờ ra', FORMAT(b.dateCheckout, 'dd/MM/yyyy') as N'Ngày', CASE WHEN b.status = 1 THEN 'Đã thanh toán' ELSE 'Chưa thanh toán' END AS N'Tình trạng', b.total_bill as N'Tổng hóa đơn' from Bills b, Tables t where b.table_id = t.table_id";
            DataTable dt = db.getDataTable(strView);
            dtgv_bill.DataSource = dt;
        }
        private void Load_DgvAllOrderOfBill(string Query)
        {
            BDConnection db = new BDConnection();
            string strView = "select i.item_name as N'Mặt hàng', i.item_unit as N'ĐVT', i.item_price as N'Giá', o.quantity as N'Số lượng', (i.item_price * o.quantity) as N'Thành tiền' from Items i, Orders o where i.item_id = o.order_item_id and o.bill_id = '" + Query + "'";
            DataTable dt = db.getDataTable(strView);
            dtgv_AllorderOfbill.DataSource = dt;
        }
        private void Load_DgvAcc()
        {
            BDConnection db = new BDConnection();
            string strView = "select Display as N'Tên hiện thị', UserName as N'Tên tài khoản', PassWord as N'Mật khẩu' , CASE WHEN a.Type = 1 THEN N'Admin' ELSE 'Staff' END AS N'Vai trò' from Account a";
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
                BDConnection db = new BDConnection();
                string strQuery = "Insert into Items (item_id, item_name, item_description, item_price, item_unit, category_id) values ('" + tb_idItem.Text + "', N'" + tb_nameItem.Text + "', N'" + tb_despItem.Text + "', " + decimal.Parse(tb_priceItem.Text) + ", '" + cbo_unit.SelectedItem + "', '" + cb_cateItem.SelectedValue + "')";
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
            BDConnection db = new BDConnection();
            string strQuery = "update Items set item_name = N'" + tb_nameItem.Text + "', item_price = " + decimal.Parse(tb_priceItem.Text) + ", item_description = N'" + tb_despItem.Text + "', category_id = '" + cb_cateItem.SelectedValue + "' where item_id = '" + tb_idItem.Text + "'";
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
                BDConnection db = new BDConnection();
                string strQuery = "insert into Categories values ('" + tb_idCate.Text + "', '" + tb_nameCate.Text + "')";
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
        private void dtgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_bill.Rows[e.RowIndex];
            Load_DgvAllOrderOfBill(r.Cells[0].Value.ToString());
            lb_biliId.Text = r.Cells[0].Value.ToString();
        }

        private void dtgv_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delCate_Click(object sender, EventArgs e)
        {
            BDConnection db = new BDConnection();
            DialogResult result = MessageBox.Show("Bạn có xóa danh mục " + tb_nameCate.Text + " không?", "Thông báo xóa danh mục!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "delete from Categories where category_id = '" + tb_idCate.Text + "'";
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
            BDConnection db = new BDConnection();
            DialogResult result = MessageBox.Show("Bạn có xóa mặt hàng " + tb_nameCate.Text + " không?", "Thông báo xóa mặt hàng!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "delete from Items where item_id = '" + tb_idItem.Text + "'";
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
                BDConnection db = new BDConnection();
                string strQuery = "insert into Tables (table_id, table_name) values ('" + tb_idTable.Text + "', N'" + tb_nameTable.Text + "')";
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
            BDConnection db = new BDConnection();
            string strQuery = "update Tables set table_name = N'" + tb_nameTable.Text + "' where table_id = '" + tb_idTable.Text + "'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("" + tb_nameTable.Text + " đã được sửa thành công  ", "Thông báo");
            }
            Load_DgvTables();
        }

        private void btn_changeCate_Click(object sender, EventArgs e)
        {
            BDConnection db = new BDConnection();
            string strQuery = "update Categories set category_name = N'" + tb_nameCate.Text + "' where category_id = '" + tb_idCate.Text + "'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("Danh mục " + tb_nameCate.Text + " đã được sửa thành công  ", "Thông báo");
            }
            Load_DgvCategory();
        }

        private void btn_delTable_Click(object sender, EventArgs e)
        {
            BDConnection db = new BDConnection();
            DialogResult result = MessageBox.Show("Bạn có xóa bàn " + tb_nameTable.Text + " không?", "Thông báo xóa bàn!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "delete from Tables where table_id = '" + tb_idTable.Text + "'";
                int k = db.getNonQuery(strQuery);
                if (k == 1)
                {
                    MessageBox.Show("Đã xóa " + tb_nameCate.Text + "", "Thông báo");
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
                BDConnection db = new BDConnection();
                bool isAdmin = true ? cb_typeAcc.Text == "Admin" : false;
                string strQuery = "insert into Account values ('" + tb_displayAcc.Text + "', '" + tb_username.Text + "', '" + tb_pass.Text + "', '" + isAdmin + "')";
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
            BDConnection db = new BDConnection();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản " + tb_nameTable.Text + " không?", "Thông báo xóa tài khoản!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string strQuery = "delete from Account where UserName = '" + tb_username.Text + "'";
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
            BDConnection db = new BDConnection();
            bool isAdmin = true ? cb_typeAcc.Text == "Admin" : false;
            string strQuery = "update Account  set Display = N'" + tb_displayAcc.Text + "', PassWord = '" + tb_pass.Text + "', Type = '" + isAdmin + "' where UserName = '" + tb_username.Text + "'";
            int k = db.getNonQuery(strQuery);
            if (k == 1)
            {
                MessageBox.Show("Tài khoản " + tb_username.Text + " đã được sửa thành công  ", "Thông báo");
            }
            Load_DgvAcc();
        }
        #endregion

    }
}

