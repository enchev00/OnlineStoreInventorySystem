using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class Cart
    {
        private double totalValueCart;
        public Cart() { 
        productsCart = new List<Product>();
        }
        public List<Product> productsCart;

        public void calculateTotalPriceOfItemsInCart()
        {
            foreach(var item in productsCart)
            {
                totalValueCart += item.Price;
            }
            Console.WriteLine(totalValueCart);
        }
        public void displayProductsInCart()
        {
            foreach (var item in productsCart) { 
           item.PrintDetails();
            }

        }
        public void removeProductsFromCart(Product product)
        {
            productsCart.Remove(product);
        }
        public void addProductsToCart(Product product)
        {
            productsCart.Add(product);
        }
       
    }
}
