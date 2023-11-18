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
        private string strConnect = @"Data Source=LAPTOP-85REN94E\SQLEXPRESS;Initial Catalog=QL_QuanNhau;Integrated Security=True";
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
        public class DataProvider
        {
            private string connectionSTR = @"Data Source=LAPTOP-85REN94E\SQLEXPRESS;Initial Catalog=QL_QuanNhau;Integrated Security=True";

            public DataTable ExecuteQuery(string query, object[] parameter = null)
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }

                return data;
            }
            public object ExecuteScalar(string query, object[] parameter = null)
            {
                object data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();

                    connection.Close();
                }

                return data;
            }
        }
    }
}
