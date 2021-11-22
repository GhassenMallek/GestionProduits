using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Chemical : Product
    {
        public String City { get; set; }
        public String LabName { get; set; }
        public string StreeAddress { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            System.Console.WriteLine(this.City + " " + this.LabName + " " + this.StreeAddress);
        }



        
        public override void GetMyType()
        {
            Console.WriteLine("chemical");
        }






    }
}
