using OrgOffering.Data;
using OrgOffering.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OrgOffering.Repository
{
    public class ProductRepo
    {
        protected readonly CMPG323Context _context = new CMPG323Context();

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }
    }
}
