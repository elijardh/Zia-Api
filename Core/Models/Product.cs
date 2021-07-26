using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String ProductName { get; set; }
        public int ProductCost { get; set; }
        public String ProductDescription { get; set; }
    }
}
