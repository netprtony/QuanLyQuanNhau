using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNhau
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            DBConnection db = new DBConnection();
            List<Table> tableList = db.LoadTableList();
            string st;
            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = db.TableWidth, Height = db.TableHeight};
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
            DBConnection db = new DBConnection();
            List<Order> listOrder = db.GetListAllOrder(db.getUnCheckBillByIdTable(id));
            foreach(Order item in listOrder)
            {
                ListViewItem lsvItem = new ListViewItem(item.Id);
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lstView_bill.Items.Add(lsvItem);
            }
        }

        #endregion
        #region Events
        private void btn_Cilk(object sender, EventArgs e)
        {
            string idTable = ((sender as Button).Tag as Table).ID;
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

        #endregion
    }
}
