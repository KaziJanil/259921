using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Shop
    {
        public Shop()
            {
            products = new List<Product>();
        }
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Product> products;




        public bool AddProduct(Product product)
        {
            if (products.Count>0)

            {
                foreach (var checkProduct in products)
                {
                    if (checkProduct.productID == product.productID)
                    {
                        checkProduct.Quantity += product.Quantity;
                        return true;
                    }

                }
            }

            products.Add(product);
            return true;

        }
        public string Getinfo()
        {
            string message = "";
            string shopinfo = "Name:" + Name + "Address: " + Address;
            string header = " product id \t\t\t Quantity";
            string productinfo = "";
            foreach (var product in products)
            {
                productinfo += product.productID + " " + product.Quantity + "\n";  
                
            }
            message = shopinfo + "\n" + header + "\n" + productinfo;
            return message;
        }
    }
}
