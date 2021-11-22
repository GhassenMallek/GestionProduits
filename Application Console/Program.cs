using Domain.Entities;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            Provider P1 = new Provider() { Password = "123", ConfirmPassword = "123"} ;
            Provider P2 = new Provider() { Password = "1234555", ConfirmPassword = "1234555" };

           // Provider.SetlsApproved(P1.Password,P1.ConfirmPassword,P1.IsApproved);
           // System.Console.WriteLine(P1.IsApproved);

            Provider.SetlsApproved(P2);
            System.Console.WriteLine(P2.IsApproved);

            Provider.SetlsApproved(P1);
            System.Console.WriteLine(P1.IsApproved);

            Category cat1 = new Category()  ;
            Category cat2 = new Category()  ;
            Category cat3 = new Category()  ;

            Provider prov1 = new Provider()  ;
            Provider prov2 = new Provider()  ;
            Provider prov3 = new Provider()  ;

            //Product prod1 = new Product() { Category = cat1 , Provider= [] }  ;
            Product prod2 = new Product()  ;
            Product prod3 = new Product()  ;







        }
    }
}
