using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInhertianceProject {
    public class Product {

        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        
        public virtual string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}";
                // going to get the type for Product - 
                // a method 

        }
        //constructor named the same as the class
        public Product(string Code, decimal price) {
            this.Flag = true; //bool, "this" is optional
            this.Code = Code; //"this" has to be included because Code - it wouldn't know
                               // the difference between property and parameter 
            this.Price = price;
        }
        public Product() {
            Flag = false;

        }
    }
}
