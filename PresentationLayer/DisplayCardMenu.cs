using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace PresentationLayer
{
    public class DisplayCardMenu
    {
        private string prompt = @"
  ______                             __        ______             ______          
 /      \                           /  |      /      |           /      \         
/$$$$$$  |  ______    ______    ____$$ |      $$$$$$/  _______  /$$$$$$  |______  
$$ |  $$/  /      \  /      \  /    $$ |        $$ |  /       \ $$ |_ $$//      \ 
$$ |       $$$$$$  |/$$$$$$  |/$$$$$$$ |        $$ |  $$$$$$$  |$$   |  /$$$$$$  |
$$ |   __  /    $$ |$$ |  $$/ $$ |  $$ |        $$ |  $$ |  $$ |$$$$/   $$ |  $$ |
$$ \__/  |/$$$$$$$ |$$ |      $$ \__$$ |       _$$ |_ $$ |  $$ |$$ |    $$ \__$$ |
$$    $$/ $$    $$ |$$ |      $$    $$ |      / $$   |$$ |  $$ |$$ |    $$    $$/ 
 $$$$$$/   $$$$$$$/ $$/        $$$$$$$/       $$$$$$/ $$/   $$/ $$/      $$$$$$/  
              
";
        public Card Card { get; set; }
        public string[] Options { get; set; }
        public Menu cardMenu;
        public int SelectedIndex { get; set; }

        public DisplayCardMenu(Card card)
        {
            Card = card;
            Options = GetOptions(Card);
            cardMenu = new Menu(prompt, Options);
            SelectedIndex = cardMenu.Run();
        }

        private string[] GetOptions(Card card)
        {
            string cardType = card.CardType;
            if (cardType.Equals("monster"))
            {
                return MonsterOptions(card);
            }
            else if (cardType.Equals("spell"))
            {
                return SpellOptions(card);
            }
            return TrapOptions(card);
        }

        private string[] MonsterOptions(Card card)
        {
            return [
                $"Id: {Card.CardId}",
                $"Name: {Card.Name}",
                $"Type: {Card.CardType}",
                $"Attribute: {Card.Attribute}",
                $"Level: {Card.Level}",
                $"ATK: {Card.ATK}",
                $"DEF: {Card.DEF}",
                $"View card",
                $"Back"
            ];
        }
        private string[] SpellOptions(Card card)
        {
            return [
                $"Id: {Card.CardId}",
                $"Name: {Card.Name}",
                $"Spell Type: {Card.Property}",
                $"View card",
                $"Back"
            ];
        }
        private string[] TrapOptions(Card card)
        {
            return [
                $"Id: {Card.CardId}",
                $"Name: {Card.Name}",
                $"Trap Type: {Card.Property}",
                $"View card",
                $"Back"
            ];
        }
    }
}
