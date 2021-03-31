using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public object ProductId { get; set; }
        public object ProductName { get; set; }
        public int CategoryId { get; set; }
        
        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }

}
