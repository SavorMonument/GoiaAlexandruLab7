using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GoiaAlexandruLab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
