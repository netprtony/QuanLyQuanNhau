using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Order
    {
        public Order(string id, string item, int quantity)
        {
            this.Id = id;
            this.Item = item;
            this.Quantity = quantity;
        }
        public Order(DataRow r)
        {
            this.Id = r["bill_id"].ToString();
            this.Item = r["item_id"].ToString();
            this.Quantity = (int)r["quantity"];
        }
        private string id;
        private string item;
        private int quantity;

        public string Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
