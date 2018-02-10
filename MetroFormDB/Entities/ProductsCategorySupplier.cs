using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFormDB.Entities {
    public class ProductsCategorySupplier : Products {
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
    }
}
