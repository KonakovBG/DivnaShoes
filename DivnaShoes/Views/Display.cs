using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Views
{
    public class Display
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Number { get; set; }


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
            First_Name = Console.ReadLine();
            Last_Name = Console.ReadLine();
            
        }

        public void Print()
        {
            Console.WriteLine(First_Name + " - " + Last_Name);
            Console.WriteLine("---------------------------------");
        }




    }
}
