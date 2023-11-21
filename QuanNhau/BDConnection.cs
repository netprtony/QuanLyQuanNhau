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
    class BDConnection
    {
        private const string V = @"Data Source=LAPTOP-85REN94E\SQLEXPRESS;Initial Catalog=QL_QuanNhau;Integrated Security=True";
        private string strConnect = V;
        SqlConnection connect;
        public BDConnection()
        {
            connect = new SqlConnection(strConnect);
        }
        public BDConnection(string strcon)
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
        public static double TableWidth = 50;
        public static double TableHeight = 50;
    }
}
