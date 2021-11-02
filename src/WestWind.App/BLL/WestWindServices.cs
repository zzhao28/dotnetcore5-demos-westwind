//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WestWind.Entities;
using WestWind.DAL;

namespace WestWind.Services 
{
    public class WestWindServices 
    {
        private readonly WestWindContext Context;
        public  WestWindServices(WestWindContext context) {
            if (context == null)
                throw new ArgumentNullException();
            Context = context;
            //null-coalescing operator ??
            //Context = context ?? throw new ArgumentNullException();
        }

        #region QUERY
        public BuildVersion GetDbVersion() 
        {
            Console.WriteLine($"WestWindServices: GetDbVersion;");
            var result = Context.BuildVersion.ToList();
            return result.First();
        }
        
        // Returns all Category records.
        public List<Category> ListCategories()
        {
            Console.WriteLine($"WestWindServices: ListCategories();");
            return Context.Categories.ToList();
        }

        // Returns zero or more Product records containing the supplied partial Product Name string.
        public List<Product> FindProductsByPartialProductName(string partialProductName)
        {
            Console.WriteLine($"WestWindServices: FindProductsByPartialProductName(); partialProductName= {partialProductName}");
            return Context.Products.Where(x=>x.ProductName.Contains(partialProductName)).ToList();
        }

        // Returns zero or more Product records matching the supplied CategoryId
        public List<Product> FindProductsByCategory(int? selectedCategoryId)
        {
            Console.WriteLine($"WestWindServices: FindProductsByCategory(); selectedCategoryId= {selectedCategoryId}");
            return Context.Products.Where(x=>x.CategoryId == selectedCategoryId).ToList();
        }
        
        // Returns all Supplier records.
        public List<Supplier> ListSuppliers()
        {
            Console.WriteLine($"WestWindServices: ListSuppliers();");
            return Context.Suppliers.ToList();
        }        
        #endregion
        
        #region READ - Retrieve, Edit, Add, Delete
        public Product Retrieve(int productId)
        {
            Console.WriteLine($"WestWindServices: Retrieve; productId= {productId}");
            return Context.Products.Find(productId);
        }

        public void Edit(Product item)
        {
            Console.WriteLine($"WestWindServices: Edit; productId= {item.ProductId}");
            var existing = Context.Entry(item);
            existing.State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Add(Product item)
        {
            Console.WriteLine($"WestWindServices: Add; productId= {item.ProductId}");
            Context.Products.Add(item);
            Context.SaveChanges();
        }

        public void Delete(Product item)
        {
            Console.WriteLine($"WestWindServices: Delete; productId= {item.ProductId}");
            var existing = Context.Entry(item);
            existing.State = EntityState.Deleted;
            Context.SaveChanges();
        }
        #endregion
    }
}