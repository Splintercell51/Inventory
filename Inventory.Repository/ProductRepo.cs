using Inventory.Core;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly Context context;
        public ProductRepo()
        {
            context = new Context();
        }

        public void Add(Product data)
        {
            context.Product.Add(data);
            context.SaveChanges();
        }

        public Product GetById(int id)
        {
            return context.Product.Find(id);
        }

        public List<Product> GetList()
        {
            //IQueryable<Product> i = context.Product;
            return context.Product.ToList();
        }

        public void Update(Product data)
        {
            var entity = GetById(data.Id);

            //entity.Name = data.Name;
            //entity.Weight = data.Weight;
            //entity.ManufacturedDate = data.ManufacturedDate;
            //entity.ExpiryDate = data.ExpiryDate;
            //entity.Barcode = data.Barcode;
            //entity.BatchNo = data.BatchNo;

            context.Entry(entity).State = EntityState.Detached;
            context.Product.Attach(data);
            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}
