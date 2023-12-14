using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNhau
{
    public partial class frmManager : Form
    {
        DBConnection db = new DBConnection();
        static string idBillCurrent = "";
        public frmManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCboCate();
            LoadCbTable();
            refeshForm();

        }
        #region Method
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable dt = db.getDataTable("USP_GetTableList");
            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }


        public string getUnCheckBillByIdTable(string id)
        {
            DataTable dt = db.getDataTable("exec USP_GetUnCheckBillByIdTable '" + id + "'");
            if (dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.Id;
            }
            return null;
        }
        public List<Order> GetListAllOrder(string id)
        {
            List<Order> listOrder = new List<Order>();
            DataTable dt = db.getDataTable("exec USP_GetListAllOrder '" + id + "'");
            foreach (DataRow item in dt.Rows)
            {
                Order a_Order = new Order(item);
                listOrder.Add(a_Order);
            }
            return listOrder;
        }
        public List<Menu> GetListMenuByTable(string id)
        {
            List<Menu> listMenu = new List<Menu>();
            string que = "exec USP_GetListMenuByTable  '" + id + "'";
            DataTable dt = db.getDataTable(que);
            foreach (DataRow item in dt.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<Category> GetAllCategory()
        {
            List<Category> list = new List<Category>();
            string que = "select * from Categories";
            DataTable dt = db.getDataTable(que);
            foreach (DataRow item in dt.Rows)
            {
                Category cate = new Category(item);
                list.Add(cate);
            }
            return list;
        }
        public List<Item> GetItemByCategoryId(string id)
        {
            List<Item> list = new List<Item>();
            string que = "select * from Items where category_id = '" + id + "'";
            DataTable dt = db.getDataTable(que);
            foreach (DataRow item in dt.Rows)
            {
                Item it = new Item(item);
                list.Add(it);
            }
            return list;
        }
        string CreateIDBill()
        {
            string mhd = "BI";
            string chuoitruyvan = "select * from Bills where bill_id LIKE '" + mhd + "%' order by bill_id desc";
            DataTable dt = db.getDataTable(chuoitruyvan);
            if (dt.Rows.Count == 0)
            {
                mhd = mhd + "001";
            }
            else
            {
                string mdhbandau = dt.Rows[0]["bill_id"].ToString();
                string stt = mdhbandau.Substring(2);
                int so = int.Parse(stt) + 1;

                if (so < 10)
                {
                    mhd = mhd + "00" + so;
                }
                else
                {
                    if (so < 100)
                        mhd = mhd + "0" + so;
                    else
                        mhd = mhd + so;
                }

            }
            return mhd;
        }
        private void LoadCbTable()
        {
            DataTable dt = db.getDataTable("exec USP_GetTableAvailable");

            cb_switchTable.DataSource = dt;
            cb_switchTable.DisplayMember = "table_name";
            cb_switchTable.ValueMember = "table_id";
        }
        void LoadTable()
        {
            dtgv_loadTable.DataSource = db.getDataTable("exec USP_LoadAllTable");
           
        }
        private void ShowBill(string id)
        {
            lstView_bill.Items.Clear();
            List<Menu> listOrder = GetListMenuByTable(id);
            decimal total = 0;
            decimal readTotal = 0;
            decimal discount = decimal.Parse(tb_discount.Text);
            foreach (Menu item in listOrder)
            {
                ListViewItem lsvItem = new ListViewItem(item.NameItem. ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString()); 
                lsvItem.SubItems.Add(string.Format("{0:0,0}", item.Price));
                lsvItem.SubItems.Add(string.Format("{0:0,0}", item.Total));
                total += item.Total;
                lstView_bill.Items.Add(lsvItem);
            }
            CultureInfo cl = new CultureInfo("vi_VN");
            lb_totalBill.Text = total.ToString("c", cl);
            readTotal = total - (total/100)*discount;
            lb_actPaid.Text = readTotal.ToString();
        }
        private void LoadCboCate()
        {
            List<Category> lst = GetAllCategory();
            cb_lstCate.DataSource = lst;
            cb_lstCate.DisplayMember = "name";
        }
        private void LoadItemOfCate(string id)
        {
            List<Item> lst = GetItemByCategoryId(id);
            cb_ItemOfCate.DataSource = lst;
            cb_ItemOfCate.DisplayMember = "name";
        }
        #endregion
        #region Events
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_addBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoProfile f = new frmInfoProfile();
            f.ShowDialog();
        }

        private void cb_lstCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category sel = cb.SelectedItem as Category;
            string id = sel.Id;
            LoadItemOfCate(id);
        }

        private void btn_addDish_Click(object sender, EventArgs e)
        {
            if (idBillCurrent == "")
            {
                MessageBox.Show("Vui lòng chon bàn để thêm món", "Thông báo");
                return;
            }
               
            string idBill = getUnCheckBillByIdTable(idBillCurrent);
            string idItem = (cb_ItemOfCate.SelectedItem as Item).Id;
            decimal discount = decimal.Parse(tb_discount.Text);
            int amount = (int)nud_countdish.Value;
            if (amount == 0)
            {
                MessageBox.Show("Số lượng không được bằng 0!", "Thông báo");
                return;
            }
            if (idBill == null)
            {
                string idBillNew = CreateIDBill();
                int k = db.getNonQuery("exec USP_InsertBill '" + idBillNew + "', '" + idBillCurrent + "'");
                if (k == 1) MessageBox.Show("Bill đã được tạo", "Thông báo");
                k = db.getNonQuery("exec USP_InsertOrders '"+ idBillNew + "', '"+ idItem + "', '"+ amount + "'");
                if (k == 1) MessageBox.Show("Đã thêm món " + cb_ItemOfCate.Text + " vào hóa đơn " + idBillNew);
            }
            else
            {
                int k = db.getNonQuery("exec USP_InsertOrders '" + idBill + "', '" + idItem + "', '" + amount + "'");
                if (k == 1) MessageBox.Show("Đã thêm món " + cb_ItemOfCate.Text + " vào hóa đơn " + idBill);
            }
            ShowBill(idBillCurrent);
            LoadTable();
            LoadCbTable();
        }
        #endregion

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (idBillCurrent == "")
            {
                MessageBox.Show("Vui lòng chon bàn để thêm món", "Thông báo");
                return;
            }
            ReadMoney rm = new ReadMoney();
            string idBill = getUnCheckBillByIdTable(idBillCurrent);
            decimal acttuallyTotal = decimal.Parse(lb_actPaid.Text.ToString());
            if (idBill != null)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn này ", "Thông báo thanh toán", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    db.getNonQuery("exec USP_CheckOutBill '" + idBill + "', '" + decimal.Parse(tb_discount.Text.ToString()) + "', '" + acttuallyTotal + "', '" + idBillCurrent + "'");
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hóa đơn để thanh toán", "Thông báo");
            }
            idBillCurrent = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_switchTable_Click(object sender, EventArgs e)
        {
            if (idBillCurrent == "")
            {
                MessageBox.Show("Vui lòng chon bàn để thêm món", "Thông báo");
                return;
            }
            string idBill = getUnCheckBillByIdTable(idBillCurrent);
            if(idBill != null)
            {
                if (MessageBox.Show("Bạn có chắc chuyển bàn"+ cb_switchTable.Text , "Thông báo chuyển bàn", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int k = db.getNonQuery("exec USP_swapTable '"+ cb_switchTable.SelectedValue.ToString() + "', '"+ idBill + "'");
                    if (k == 1) MessageBox.Show("Đã chuyển tới" + cb_switchTable.Text, "Thông báo chuyển bàn");
                    LoadCbTable();
                    LoadTable();
                }
            }
            
        }
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_pay_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_addDish_Click(this, new EventArgs());
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_switchTable_Click(this, new EventArgs());
        }

        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin l = new frmLogin();
            this.Hide();
            
        }
        private void refeshForm()
        {
          db.getNonQuery("exec USP_CheckAllTableNotBill");
        }
        private void tb_refesh_Click(object sender, EventArgs e)
        {
            LoadTable();
            LoadCboCate();
            LoadCbTable();
            refeshForm();
        }

        private void dtgv_loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_loadTable.Rows[e.RowIndex];
            ShowBill(r.Cells[0].Value.ToString());
            idBillCurrent = r.Cells[0].Value.ToString();
        }

        private void dtgv_loadTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
        }

        private void dtgv_loadTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgv_loadTable.Columns["Tình trạng"].Index)
            {
                var cellValue = dtgv_loadTable.Rows[e.RowIndex].Cells["Tình trạng"].Value;

                if (cellValue != null)
                {
                    if (cellValue.ToString() == "Có người")
                    {
                        e.CellStyle.BackColor = Color.GreenYellow;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }

        }

        private void tb_discount_TextChanged(object sender, EventArgs e)
        {
            ShowBill(idBillCurrent);
        }
    }
}
