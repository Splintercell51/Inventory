using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository
{
    public interface IProductRepo
    {
        void Add(Product data);
        void Update(Product data);
        List<Product> GetList();
        Product GetById(int id);
    }
}
