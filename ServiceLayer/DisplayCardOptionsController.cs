using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BusinessLayer;

namespace ServiceLayer
{
    public class DisplayCardOptionsController
    {
        private DisplayCardMenu cardMenu;
        private IWebDriver driver;
        public DisplayCardOptionsController(DisplayCardMenu cardMenu)
        {
            this.cardMenu = cardMenu;
        }
        public int CardOptions()
        {
            int selectedIndex = cardMenu.SelectedIndex;
            if (selectedIndex == cardMenu.Options.Length - 2)
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://db.ygorganization.com/card#" + cardMenu.Card.Id.ToString());
            }
            else if (selectedIndex == cardMenu.Options.Length - 1)
            {
                //Go to previous menu
            }
            return selectedIndex;
        }
    }
}
