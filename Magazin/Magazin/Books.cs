using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class Books : Product
    {
       public string Bauthor { get; set; }
       public int Bpages { get; set; }
       public string Btitle { get; set; }
      public  string Bdescription { get; set; }

       
        public Books()
        {

        }
        public Books (string name, int productId, double price,string bauthor, int bpages, string btitle, string bdescription)
        {
            this.Name = name;
            this.ProductId = productId;
            this.Price = price;
            this.Bauthor = bauthor;
            this.Bpages = bpages;
            this.Btitle = btitle;
            this.Bdescription = bdescription;
        }

        public void printDetailsOfBook()
        {
            Console.WriteLine("Title of book is: " + this.Btitle + " and the Author is: " +this.Bauthor);
        }

    }
}
