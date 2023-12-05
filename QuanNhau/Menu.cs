using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Menu
    {
        public Menu(string name, int qua, decimal price, decimal total = 0)
        {
            this.NameItem = name;
            this.Quantity = qua;
            this.Price = price;
            this.Total = total;
        }
        public Menu(DataRow r)
        {
            this.NameItem = r["Món"].ToString();
            this.Quantity = (int)r["Số lượng"];
            this.Price = (decimal)r["Giá"];
            this.Total = (decimal)r["Tổng"];
        }
        private decimal total;
        private decimal price;
        private int quantity;
        private string nameItem;

        public string NameItem { get => nameItem; set => nameItem = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
