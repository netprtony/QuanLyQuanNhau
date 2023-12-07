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
        public frmManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCboCate();
            LoadCbTable();
        }
        #region Method
        string CreateIDBill()
        {
            string mhd = "BI";
            //mhd = mhd + string.Format("{0:ddMMyyyy}", DateTime.Now);
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
            List<Table> lst = db.GetTableAvailable();
            cb_switchTable.DataSource = lst;
            cb_switchTable.DisplayMember = "name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = db.LoadTableList();
            string st;
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = db.TableWidth, Height = db.TableHeight };
                if (item.Status == true) st = "Có người";
                else st = "Trống";
                btn.Text = item.Name + Environment.NewLine + st;
                btn.Click += btn_Cilk;
                btn.Tag = item;
                switch (st)
                {
                    case "Trống":
                        btn.BackColor = Color.DarkKhaki;
                        break;
                    default:
                        btn.BackColor = Color.Beige;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        private void ShowBill(string id)
        {
            lstView_bill.Items.Clear();
            List<Menu> listOrder = db.GetListMenuByTable(id);
            decimal total = 0;
            decimal readTotal = 0;
            decimal discount = decimal.Parse(lb_discount.Text);
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
            List<Category> lst = db.GetAllCategory();
            cb_lstCate.DataSource = lst;
            cb_lstCate.DisplayMember = "name";
        }
        private void LoadItemOfCate(string id)
        {
            List<Item> lst = db.GetItemByCategoryId(id);
            cb_ItemOfCate.DataSource = lst;
            cb_ItemOfCate.DisplayMember = "name";
        }
        #endregion
        #region Events
        private void btn_Cilk(object sender, EventArgs e)
        {
            string idTable = ((sender as Button).Tag as Table).ID;
            lstView_bill.Tag = (sender as Button).Tag;
            ShowBill(idTable);
        }
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
            Table table = lstView_bill.Tag as Table;
            string idBill = db.getUnCheckBillByIdTable(table.ID);
            string idItem = (cb_ItemOfCate.SelectedItem as Item).Id;
            decimal discount = decimal.Parse(lb_discount.Text);
            int amount = (int)nud_countdish.Value;
            if (amount == 0)
            {
                MessageBox.Show("Số lượng không được bằng 0!", "Thông báo");
                return;
            }
            if (idBill == null)
            {
                string idBillNew = CreateIDBill();
                int k = db.getNonQuery("exec USP_InsertBill '" + idBillNew + "', '" + table.ID + "'");
                if (k == 1) MessageBox.Show("Bill đã được tạo", "Thông báo");
                k = db.getNonQuery("exec USP_InsertOrders '"+ idBillNew + "', '"+ idItem + "', '"+ amount + "'");
                if (k == 1) MessageBox.Show("Đã thêm món " + cb_ItemOfCate.Text + " vào hóa đơn " + idBillNew);
            }
            else
            {
                int k = db.getNonQuery("exec USP_InsertOrders '" + idBill + "', '" + idItem + "', '" + amount + "'");
                if (k == 1) MessageBox.Show("Đã thêm món " + cb_ItemOfCate.Text + " vào hóa đơn " + idBill);
            }
            ShowBill(table.ID);
            LoadTable();
            LoadCbTable();
        }
        #endregion

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Table table = lstView_bill.Tag as Table;
            ReadMoney rm = new ReadMoney();
            string idBill = db.getUnCheckBillByIdTable(table.ID);
            decimal acttuallyTotal = decimal.Parse(lb_actPaid.Text.ToString());
            if (idBill != null)
            {
                if (MessageBox.Show("Bạn có chắc hóa đơn cho bàn " + table.Name, "Thông báo thanh toán", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int k = db.getNonQuery("exec USP_CheckOutBill '" + idBill + "', '" + decimal.Parse(lb_discount.Text.ToString()) + "', '" + acttuallyTotal + "', '" + table. ID + "'");
                    if (k == 1) MessageBox.Show("Thanh toán hóa đơn " + idBill + " thành công\nTổng tiền:"+ decimal.Parse(lb_actPaid.Text.ToString()) + "\nThành chữ: "+rm.docSoThanhChu((long)acttuallyTotal), "Thông báo thanh toán");
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hóa đơn để thanh toán", "Thông báo");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_switchTable_Click(object sender, EventArgs e)
        {
            Table table = lstView_bill.Tag as Table;
            string tableNew = (cb_switchTable.SelectedItem as Table).ID;
            string idBill = db.getUnCheckBillByIdTable(table.ID);
            if(idBill != null)
            {
                if (MessageBox.Show("Bạn có chắc chuyển bàn" + table.Name + " sang bàn "+ cb_switchTable.Text , "Thông báo thanh toán", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int k = db.getNonQuery("exec USP_swapTable '"+ tableNew + "', '"+ idBill + "'");
                    if (k == 1) MessageBox.Show("Đã chuyển bàn" + table.Name + " sang bàn " + cb_switchTable.Text, "Thông báo chuyển bàn");
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
            //if (MessageBox.Show("Bạn có muốn thoát ra không?", "Thông báo thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //    frmLogin l = new frmLogin();
            //    l.ShowDialog();
            //    l.Show();
            //}
        }
    }
}
