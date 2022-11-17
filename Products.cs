using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDepartment
{
    public class Products     
    {
        public Products()
        {

        }
        public int ProductID { get; set; } 
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public double Price { get; set; }
        public int StockLevel { get; set; }
        public bool OnSale { get; set; } 

       
    }
}
