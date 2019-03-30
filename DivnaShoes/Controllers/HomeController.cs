using DivnaShoes.Models.CartModel;
using DivnaShoes.Models.ProductModel;
using DivnaShoes.Models.ProductModel.Men_s_Shoes;
using DivnaShoes.Models.ProductModel.Women_s_shoes;
using DivnaShoes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivnaShoes.Controllers
{
    public class HomeController
    {
        public Display display;
        public Cart cart;
        CreatingProducts create = new CreatingProducts();

        public HomeController()
        {
            display = new Display();
            cart = new Cart();           
            
        }
        public void StartUp()
        {
            Introduction();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < 100; i++)
            {
                if (commands[0] == "END")
                {
                    break;
                }
                else if (commands[0] == "Add")
                {
                    if (commands[1] == "Hiking")
                    {
                        create.Hiking = new Hiking(int.Parse(commands[2]));
                        cart.Add(create.Hiking);
                    }
                    if (commands[1] == "Sneakers")
                    {
                        create.Sneakers = new Sneakers(int.Parse(commands[2]));
                        cart.Add(create.Sneakers);
                    }
                    if (commands[1] == "Trainers")
                    {
                        create.Trainers = new Trainers(int.Parse(commands[2]));
                        cart.Add(create.Trainers);
                    }
                    if (commands[1] == "Wingtip")
                    {
                        create.Wingtip = new Wingtip(int.Parse(commands[2]));
                        cart.Add(create.Wingtip);
                    }
                    if (commands[1] == "Mules")
                    {
                        create.Mules = new Mules(int.Parse(commands[2]));
                        cart.Add(create.Mules);
                    }
                    if (commands[1] == "Platform")
                    {
                        create.Platform = new Platform(int.Parse(commands[2]));
                        cart.Add(create.Platform);
                    }
                    if (commands[1] == "Pumps")
                    {
                        create.Pumps = new Pumps(int.Parse(commands[2]));
                        cart.Add(create.Pumps);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (commands[1] == "Hiking")
                    {
                        cart.Remove(create.Hiking);
                    }
                    if (commands[1] == "Sneakers")
                    {
                        cart.Remove(create.Sneakers);
                    }
                    if (commands[1] == "Trainers")
                    {
                        cart.Remove(create.Trainers);
                    }
                    if (commands[1] == "Wingtip")
                    {
                        cart.Remove(create.Wingtip);
                    }
                    if (commands[1] == "Mules")
                    {
                        cart.Remove(create.Mules);
                    }
                    if (commands[1] == "Platform")
                    {
                        cart.Remove(create.Platform);
                    }
                    if (commands[1] == "Pumps")
                    {
                        cart.Remove(create.Pumps);
                    }
                }
                else if (commands[0] == "Price")
                {
                    Console.WriteLine("--------------------------------  ");
                    Console.WriteLine("Your products cost: " + cart.FinalPrice());
                    Console.WriteLine("--------------------------------  ");
                }
                else if (commands[0] == "Cart")
                {
                    cart.Print();
                }
                else
                {
                    Console.WriteLine("--------------------------------  ");
                    Console.WriteLine("Wrong Command!");
                    Console.WriteLine("--------------------------------  ");
                }

                commands = Console.ReadLine().Split(' ').ToArray();
            }
            
        }

        public void Introduction()
        {
            Console.WriteLine("Please choose: Command/Shoe/Size");
        }
    }
        
 
}
