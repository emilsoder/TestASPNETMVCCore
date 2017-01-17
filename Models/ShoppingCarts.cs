using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test3.Models
{
    public class ShoppingCarts
    {
        [Key]
        public int ShoppingCartID { get; set; }
        public int CustomerID { get; set; }

    }
}
