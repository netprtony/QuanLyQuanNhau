using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Bill
    {
        public Bill(string id, DateTime? checkin, DateTime? checkout, bool st, string casher, string customer, string table, decimal? total, decimal discount = 0)
        {
            this.Id = id;
            this.DateCheckin = checkin;
            this.DateCheckout = checkout;
            this.Status = st;
            this.Cashier_id = casher;
            this.Cus_id = customer;
            this.Table_id = table;
            this.Total_bill = total;
            this.Discount = discount;
        }
        public Bill(DataRow r)
        {
            this.Id = (string)r["bill_id"];

            //var dateCheckinTemp = r["dateCheckin"];
            //if (dateCheckinTemp.ToString() != "")
            //    this.DateCheckin = (DateTime?)dateCheckinTemp;

            //var dateCheckoutTemp = r["dateCheckout"];
            //if (dateCheckoutTemp.ToString() != "")
            //    this.DateCheckout = (DateTime?)dateCheckoutTemp;
            //this.Status = (bool)r["status"];
            //this.Cashier_id = (string)r["cashier_id"];
            //this.Cus_id = (string)r["cus_id"];
            //this.Table_id = (string)r["table_id"];
            //this.Total_bill = (decimal?)r["total_bill"];
        }
        private decimal discount;
        private decimal? total_bill;
        private string table_id;
        private string cus_id;
        private string cashier_id;
        private bool status;
        private DateTime? dateCheckout;
        private DateTime? dateCheckin;
        private string id;

        public string Id { get => id; set => id = value; }
        public DateTime? DateCheckin { get => dateCheckin; set => dateCheckin = value; }
        public DateTime? DateCheckout { get => dateCheckout; set => dateCheckout = value; }
        public bool Status { get => status; set => status = value; }
        public string Cashier_id { get => cashier_id; set => cashier_id = value; }
        public string Table_id { get => table_id; set => table_id = value; }
        public string Cus_id { get => cus_id; set => cus_id = value; }
        public decimal? Total_bill { get => total_bill; set => total_bill = value; }
        public decimal Discount { get => discount; set => discount = value; }
    }
}
