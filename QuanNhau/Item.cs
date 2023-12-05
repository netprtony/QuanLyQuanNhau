using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Item
    {
        public Item(string id, string name, string des, decimal pr, string cate)
        {
            this.Id = id;
            this.Name = name;
            this.Description = des;
            this.Price = pr;
            this.IdCate = cate;
        }
        public Item(DataRow r)
        {
            this.Id = r["item_id"].ToString();
            this.Name = r["item_name"].ToString();
            this.Description = r["item_description"].ToString();
            this.Price = (decimal)r["item_price"];
            this.IdCate = r["category_id"].ToString();
        }
        private string id;
        private string name;
        private string description;
        private decimal price;
        private string idCate;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public string IdCate { get => idCate; set => idCate = value; }
    }
}
