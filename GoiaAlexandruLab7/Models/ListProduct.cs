using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GoiaAlexandruLab7.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey("ShopListID")]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}
