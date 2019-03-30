using DivnaShoes.Controllers;
using System;

namespace DivnaShoes
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeController controller = new HomeController();

            controller.StartUp();
        }
    }
}
