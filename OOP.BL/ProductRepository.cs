using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            //temp
            if (productId == 2)
            {
                product.ProductName = "sunflower";
                product.ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers";
                product.CurrentPrice = 15.96;
            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
