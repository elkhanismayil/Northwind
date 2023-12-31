using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}