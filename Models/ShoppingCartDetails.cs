﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test3.Models
{
    public class ShoppingCartDetails
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Computed), Key]
        public int ID { get; set; }
        public int ShoppingCartID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
    }
}
