using DapperDepartment;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml;

namespace DapperDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connString = config.GetConnectionString("DefaultConnection");
            
            IDbConnection connection = new MySqlConnection(connString);
            
            #region Department
            //var repo = new DapperDepartmentRepository(conn);

            //var depts = repo.GetAllDepartments();//calls all departments and stores it in depts
            //foreach (var dept in depts)
            //{
            //    Console.WriteLine(dept.Name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Enter a new department name");
            //var newDept = Console.ReadLine();   

            //repo.InsertDepartment(newDept);

            //Console.WriteLine();

            //depts = repo.GetAllDepartments();//getting an updated list of departments

            //foreach (var dept in depts)
            //{
            //    Console.WriteLine(dept.Name);
            //}
            #endregion

            
            var products2 = new DapperProductRepository(connection);
            
            var productToUpdate = products2.GetProduct(940);
            productToUpdate.OnSale = false;
            productToUpdate.Name = "Updated!";
            productToUpdate.Price = 150.00;
            productToUpdate.StockLevel = 1000;
            productToUpdate.CategoryID = 1;
            products2.UpdateProduct(productToUpdate);


            var productRepo = new DapperProductRepository(connection);
            var products = productRepo.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductID);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.CategoryID);
                Console.WriteLine(product.OnSale);
                Console.WriteLine(product.StockLevel);
                Console.WriteLine();
                Console.WriteLine();


            }
        }
    }
}