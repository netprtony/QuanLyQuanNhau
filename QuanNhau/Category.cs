using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Category
    {
        public Category(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Category(DataRow r)
        {
            this.Id = (string)r["category_id"];
            this.Name = r["category_name"].ToString();
        }
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
