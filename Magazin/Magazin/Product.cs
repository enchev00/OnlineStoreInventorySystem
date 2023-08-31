using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class Product
    {
        public Product()
        {

        }

        public int ProductId {
            get; set;
        }
        
        public string Name
        {
            get; set;  
                
            
        }

        public double Price { get; set; }


        public Product(string name, int productId, double price)
        {
            this.Name = name;
            this.ProductId = productId;
            this.Price = price;

        }

       

        public void PrintDetails()
        {
            Console.WriteLine("Name of Product is: " + this.Name );
            Console.WriteLine("Product Id is: " + this.ProductId);
            Console.WriteLine("Price of Product is: " + this.Price);
            
        }

    }
}
