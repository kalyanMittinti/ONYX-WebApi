using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onxy.models;
namespace Onxy.DataAccess
{
    public class ProductRepo : IProductRepo
    {
        public List<Product> GetProducts()
        {



            return new List<Product>();
        }
    }

    public interface IProductRepo
    {
        List<Product> GetProducts()
        {
            return new List<Product>();
        }
    }
}
