using System.Text.Json;
using BusinessLayer;
using Newtonsoft.Json;
using DataLayer;
using PresentationLayer;
using ServiceLayer;
using System.Text.RegularExpressions;

namespace YuGiOh__MasterDuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start the game
            MainController main = new MainController();
            main.Start();
        }
    }
}
