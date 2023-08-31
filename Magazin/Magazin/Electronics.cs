using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    
    public class Electronics : Product
    {

        public string ElModel { get; set; }

        public Electronics()
        {

        }
        public Electronics(string name, int productId, double price, string model)
        {
            this.ElModel = model;
            this.Name = name;
            this.ProductId = productId;
            this.Price = price;

        
        }
    }
}
