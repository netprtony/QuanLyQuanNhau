using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace QuanNhau
{
    class DBConnection
    {
        private const string V = "Data Source=MONKURO;Initial Catalog=QL_QuanNhau;Integrated Security=True";
        private string strConnect = V;
        SqlConnection connect;
        public DBConnection()
        {
            connect = new SqlConnection(strConnect);
        }
        public DBConnection(string strcon)
        {
            connect = new SqlConnection(strcon);
        }
        public void Open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }
        public void Close()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }
        public int getNonQuery(string strQuery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(strQuery, connect);
            int res = cmd.ExecuteNonQuery();
            Close();
            return res;
        }
        public Object getScalar(string strQuery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(strQuery, connect);
            Object res = cmd.ExecuteScalar();
            Close();
            return res;
        }
        public DataTable getDataTable(string strQuery)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter(strQuery, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable dt = getDataTable("USP_GetTableList");
            foreach(DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> GetTableAvailable()
        {
            List<Table> tableList = new List<Table>();
            DataTable dt = getDataTable("USP_GetTableAvailable");
            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public int TableWidth = 100;
        public int TableHeight = 100;
        /// <summary>
        /// Success: bill_id
        /// Failed: null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUnCheckBillByIdTable(string id)
        {
            DataTable dt = getDataTable("exec USP_GetUnCheckBillByIdTable '"+id+"'");
            if(dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.Id;
            }
            return null;
        }
        public List<Order> GetListAllOrder(string id)
        {
            List<Order> listOrder = new List<Order>();
            DataTable dt = getDataTable("exec USP_GetListAllOrder '" + id + "'");
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
            DataTable dt = getDataTable(que); 
            foreach(DataRow item in dt.Rows)
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
            DataTable dt = getDataTable(que);
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
            DataTable dt = getDataTable(que);
            foreach (DataRow item in dt.Rows)
            {
                Item it = new Item(item);
                list.Add(it);
            }
            return list;
        }

    }
}
