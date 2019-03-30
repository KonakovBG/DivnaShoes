using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Views
{
    public class Display
    {
        public string firstName;
        public string lastName;

        public string FirstName
        {
            get
            {
                return firstName;           
            }
            set
            {
                if (firstName == null)
                {
                    throw new ArgumentException("Your name cannot be null");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (lastName == null)
                {
                    throw new ArgumentException("Your name cannot be null");
                }
                this.lastName = value;
            }
        }

        public Display()
        {
            Console.WriteLine("Insert:" + System.Environment.NewLine +
                "---------------------------------" + System.Environment.NewLine +
                "First name: " + System.Environment.NewLine +
                "Last name:" + System.Environment.NewLine +                
                "---------------------------------");
            getValues();
        }

        public void getValues()
        {
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            
        }

        public void Print()
        {
            Console.WriteLine(firstName + " - " + lastName);
            Console.WriteLine("---------------------------------");
        }
    }
}
