using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class Order
    {
        public Order()
        {
            itemsPurchased= new List<Product>();
        }

        public Order(int orderId, string customerName, string orderDate,Cart cart,Inventory inventory)
        {
            itemsPurchased = new List<Product>();
            this.OrderDate= orderDate;
            this.CustomerName= customerName;
            this.OrderId= orderId;

           

            

           
            

        }
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public string OrderDate { get; set; }

        private List<Product> itemsPurchased {get; set;}      //tuk ne sam sig che trqbva da e tochno taka.

        public void PrintOrderDetails()
        {
            foreach(var item in itemsPurchased)
            {
                item.PrintDetails();
            }
        }

        public void purchasedItem(Cart cart)
        {
            foreach (var item in cart.productsCart)
            {
                itemsPurchased.Add(item);


            }
        }

        public void removeFromInventory(Inventory inventory)
        {
            foreach (var item in itemsPurchased)
            {

                inventory.products.Remove(item);
            }

        }
    }
}
