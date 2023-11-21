﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Table
    {
        public Table (string id, string name, bool status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public Table(DataRow row)
        {
            this.ID = row["table_id"].ToString();
            this.Name = row["table_name"].ToString();
            this.Status = (bool)row["status"];
        }
        private string name;
        private bool status;
        private string iD;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }
    }
}
