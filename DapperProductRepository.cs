using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDepartment
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _connection.Query<Products>("Select * From products;");
        }

        public Products GetProduct(int id)
        {
            return _connection.QuerySingle<Products>("Select * From products Where ProductID = @id;",
            new { id = id });
        }

        public void UpdateProduct(Products product)
        {
          _connection.Execute("Update products Set Name = @name, Price = @price, OnSale = @onsale Where ProductID = @id;",
                                           new{name = product.Name, price = product.Price, onSale = product.OnSale, id = product.ProductID});    

                
        }
    }
}
