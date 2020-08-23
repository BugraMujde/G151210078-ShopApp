using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G151210078.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }

        public int ProductId { get; set; }
        public int OrderId { get; set; }

    }
}
