using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    public class Clothing : Product
    {
        public string Marka { get; set; }
      public Clothing()
        {

        }
        public Clothing(string name,int productId, double price,string marka)
        {
            this.Name = name;
            this.ProductId = productId;
            this.Price = price;
            this.Marka = marka;


        }
        
    }
}
