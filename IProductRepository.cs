using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDepartment
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
        public Products GetProduct(int id);
        public void UpdateProduct(Products product);   
    }

}
