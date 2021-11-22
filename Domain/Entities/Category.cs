using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Category : Product
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine(this.CategoryId + " " + this.Name);

        }
    }
}
