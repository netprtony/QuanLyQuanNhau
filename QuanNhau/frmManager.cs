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
        }
        #region Method
        string CreateIDBill()
        {
            string mhd = "B";
            mhd = mhd + string.Format("{0:ddMMyyyy}", DateTime.Now);
            string chuoitruyvan = "select * from Bills where bill_id LIKE '" + mhd + "%' order by bill_id desc";
            DataTable dt = db.getDataTable(chuoitruyvan);
            if (dt.Rows.Count == 0)
            {
                mhd = mhd + "001";
            }
            else
            {
                string mdhbandau = dt.Rows[0]["bill_id"].ToString();
                string stt = mdhbandau.Substring(10, 3);
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
        void LoadTable()
        {
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
                        btn.BackColor = Color.Aquamarine;
                        break;
                    default:
                        btn.BackColor = Color.LightSteelBlue;
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
            foreach (Menu item in listOrder)
            {
                ListViewItem lsvItem = new ListViewItem(item.NameItem.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                total += item.Total;
                lstView_bill.Items.Add(lsvItem);
            }
            CultureInfo cl = new CultureInfo("vi_VN");
            lb_totalBill.Text = total.ToString("c", cl);
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
            string id = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category sel = cb.SelectedItem as Category;
            id = sel.Id;
            LoadItemOfCate(id);
        }

        private void btn_addDish_Click(object sender, EventArgs e)
        {
            Table table = lstView_bill.Tag as Table;
            string idBill = db.getUnCheckBillByIdTable(table.ID);
            if(idBill == null)
            {
                string idBillNew = CreateIDBill();
                int k = db.getNonQuery("exec USP_InsertBill '" + idBillNew + "', '" + table.ID + "'");
                if (k == 1) MessageBox.Show("Bill đã được tạo", "Thông báo");
                k = db.getNonQuery("exec USP_InsertOrders '"+ idBillNew + "', '"+ cb_ItemOfCate.SelectedValue + "', '"+ (int)nud_countdish.Value + "'");
                if (k == 1) MessageBox.Show("Đã thêm món " + cb_ItemOfCate.Text + " vào hóa đơn " + idBillNew);
            }
            else
            {
                int k = db.getNonQuery("exec USP_InsertOrders '" + idBill + "', '" + cb_ItemOfCate.SelectedValue + "', '" + (int)nud_countdish.Value + "'");
                if (k == 1) MessageBox.Show("Đã thêm món " + cb_ItemOfCate.Text + " vào hóa đơn " + idBill);
            }
        }
        #endregion
    }
}
