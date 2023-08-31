using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class OnlineStore
    {
        Inventory inventar = new Inventory();
        Order porachka = new Order();
        Cart cart = new Cart();
        Books books = new Books();
        public int action = 0;
        public int action1 = 0;
        public void startProgram()
        {
           
            displayMainMenu();

            var input = Console.ReadLine();
            
            action = int.Parse(input);
            while (action != 0)
            {
                switch (action)
                {

                    case 1:
                        inventar.displayInventory();
                        break;
                    case 2:
                        
                        Console.WriteLine("Choose what kind of Product you will create");
                        Console.WriteLine("Type 1 for Book");
                        Console.WriteLine("Type 2 for Electronics");
                        Console.WriteLine("Type 3 for Clothing");
                        
                        var input1 = Console.ReadLine();
                        action1 = int.Parse(input1);
                        switch (action1) {

                            case 1:
                                Books book = new Books();
                                Console.WriteLine("Enter book name: ");
                                book.Name = Console.ReadLine();
                                Console.WriteLine("Enter book Price: ");
                                book.Price = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter book productId: ");
                                book.ProductId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Author of Book: ");
                                book.Bauthor = Console.ReadLine();
                                Console.WriteLine("Enter Book pages: ");
                                book.Bpages = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Book Title: ");
                                book.Btitle = Console.ReadLine();
                                Console.WriteLine("Enter Book Description: ");
                                book.Bdescription = Console.ReadLine();
                                inventar.addProduct(book);
                                break;
                            case 2:
                                Electronics electronics = new Electronics();
                                Console.WriteLine("Enter Electronics name: ");
                                electronics.Name = Console.ReadLine();
                                Console.WriteLine("Enter Electronics Price: ");
                                electronics.Price = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Electronics productId: ");
                                electronics.ProductId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter electronics ElModel: ");
                                electronics.ElModel = Console.ReadLine();
                                inventar.addProduct(electronics);
                                break;
                            case 3:
                                Clothing clothing = new Clothing();
                                Console.WriteLine("Enter Clothing name: ");
                                clothing.Name = Console.ReadLine();
                                Console.WriteLine("Enter Clothing Price: ");
                                clothing.Price = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Clothing productId: ");
                                clothing.ProductId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Clothing Marka: ");
                                clothing.Marka = Console.ReadLine();
                                inventar.addProduct(clothing);
                                break;
                        }

                        break;

                    case 3:
                        Console.Write("Enter name of Product");
                        var searchedName = Console.ReadLine();
                        Product product1 = inventar.searchProductByName(searchedName);
                        cart.addProductsToCart(product1);
                        break;
                    case 4:

                        cart.displayProductsInCart();
                        break;
                    case 5:
                        Console.WriteLine("Ochakvam printirane na detaili za porachka");
                        porachka.purchasedItem(cart);
                        porachka.removeFromInventory(inventar);
                        porachka.PrintOrderDetails();
                        break;
                        case 6:

                        inventar.calculateTotalValueOfInventory();
                        break; 




                }
                 input = Console.ReadLine();        
                action = int.Parse(input);
            }
        }
        public void displayMainMenu()
        {
            Console.WriteLine("Type 0 to stop the program");
            Console.WriteLine("Type 1 to display Inventory");
            Console.WriteLine("Type 2 to create Product");
            Console.WriteLine("Type 3 to Add Product to Cart");
            Console.WriteLine("Type 4 to Display all products and their details");
            Console.WriteLine("Type 5 to Print Order Details");
            Console.WriteLine("Type 6 to Calculate Total Value of Inventory");
           
        }
    }
}
