using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product : Concept
    {
        public DateTime DateProd { get; set; }
        public String Description { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Provider> Provider { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine(this.DateProd+" "+ this.Description +" "+ this.Name +" "+ this.Price+""+this.ProductId+" "+this.Quantity+" " );
        }
        
        public virtual void GetMyType()
        {
            Console.WriteLine("unknown");
        }





       
    }
}
