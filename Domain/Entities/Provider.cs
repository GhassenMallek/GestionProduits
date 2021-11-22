using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Provider : Concept
    {
        public String ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public Boolean IsApproved { get; set; }
        public String Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else System.Console.WriteLine("La taille du password doit etre entre 5 et 20");
            }

        }

        private String password { get; set; }

        public string Username { get; set; }
        public IEnumerable<Product> Product { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine(this.ConfirmPassword + " " + this.DateCreated + " " + this.Email + " " + this.Id + "" 
                + this.IsApproved + " " + this.Password + " " + " " + this.Username);
            foreach(Product p in Product)
            {
                p.GetDetails();
            }
        }

        public static void SetlsApproved(Provider P)
        {
            P.IsApproved =  String.Compare(P.ConfirmPassword, P.Password) == 0;
        }

        public static void SetlsApproved(String password , string confirmPassword, bool isApproved)
        {
            isApproved = String.Compare(confirmPassword, password) == 0;

        }

        public bool Login(String newUsername, string newPassword)
        {
            return (this.Password == newPassword && this.Username == newUsername);
                        
        }
        public bool Login(String newUsername, string newPassword, string newEmail)
        {
            return (this.Password == newPassword && this.Username == newUsername && this.Email == newEmail);

        }

        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Name":
                    foreach (Product p in Product)
                    {
                        if (p.Name.Equals(filterValue))
                        {
                            p.GetDetails();
                        }break;
                        Console.WriteLine( "404 not found");
                    }
                    break;
                case "Price":
                    foreach (Product p in Product)
                    {
                        if (p.Price.Equals(filterValue))
                        {
                            p.GetDetails();
                        }
                        break;
                        Console.WriteLine("404 not found");
                    }
                    break;
                case "DateProd":
                    foreach (Product p in Product)
                    {
                        if (p.DateProd.Equals(filterValue))
                        {
                            p.GetDetails();
                        }
                        break;
                        Console.WriteLine("404 not found");
                    }
                    break;


            }
        }








    }
}
