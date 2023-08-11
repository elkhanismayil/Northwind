using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Products : IEntity
    {
        [Key]
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}