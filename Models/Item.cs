using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G151210078.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
