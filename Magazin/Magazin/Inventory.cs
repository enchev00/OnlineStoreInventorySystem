using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class Inventory
    {
        private double totalValue;
        public Inventory()
        {
        products = new List<Product>();

        }

        public List<Product> products;

        public void addProduct(Product product)
        {
            if (products.Any(p => p.Name.Equals(product.Name)))
            {
                Console.WriteLine("Product already exists");

            }

            else
            {
                products.Add(product);
            }
        }

            public void displayInventory()
        {
            foreach(var item in products)
            {
                item.PrintDetails();
                
                
            }
        }

      /*  public void searchProductByName1(string searchWord)
        {
            foreach(var item in products)
            {
                if(item.Name == searchWord)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }*/

        public Product searchProductByName(string searchWord)
        {
            foreach (var item in products)
            {
                if (item.Name == searchWord)
                {
                    return item;
                }
            }
            return null;
        }

        public void calculateTotalValueOfInventory()
        {
            foreach(var item in products)
            {
                totalValue += item.Price;
            }

            Console.WriteLine("Total value of Invetory is: " + totalValue + " euro");
            

        }
        
      
        
        

    }
}
