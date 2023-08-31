
using Magazin;
using System.ComponentModel;
using System.Linq;
internal class Program
{

    
    private static void Main(string[] args)
    {



        /* Inventory inventory = new Inventory();
          Product kola = new Product("BMW", 1, 1000);
          Product kola1 = new Product("Audi", 2, 3000);
          Product kola2 = new Product("Fiat", 3, 9000);
          Books hari = new Books("Book", 1, 23.50, "JK rowling", "500", "Trimata Musketari", "adventure");
          Books bari = new Books("Book", 2, 16.50, "Stefan rowling", "100", "It", "horror");


          inventory.addProduct(hari);
          inventory.addProduct(bari);
          inventory.addProduct(kola);
          inventory.addProduct(kola2);

          Cart kolichka = new Cart();
          kolichka.addProductsToCart(kola2);
          kolichka.addProductsToCart(kola);

          Order pora4 = new Order(1, "Koko", "20/02/3050",kolichka,inventory);
          Console.WriteLine("Printirame porachka");
          pora4.PrintOrderDetails();
          Console.WriteLine("Kolichka");
          kolichka.displayProductsInCart();
          Console.WriteLine("Inventory");
          inventory.displayInventory();*/
        OnlineStore magazin = new OnlineStore();

        magazin.startProgram();
     

    }
}

