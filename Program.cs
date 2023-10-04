using GuitarApp.Model;
using System.Diagnostics;
using System.Reflection;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);
            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC,12, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);
            if (matchingGuitars != null)
            {
                Console.WriteLine("Erin, you might like these guitars: ");
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.GetSpec();
                    Console.WriteLine("We have a " + spec.GetBuilder() + " " + spec.GetModel() +
                    " " + spec.GetType() + " guitar:\n" + spec.GetBackWood() + " back and sides,\n" + spec.GetTopWood() +
                    " top,\nYou can have it for only $" + guitar.GetPrice() + "!\n");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        static void InitializeInventory(Inventory inventory)
        {
            GuitarSpec spec = new GuitarSpec(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC,12, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("V95693", 1499.95, spec);
            inventory.AddGuitar("V95693", 1549.95, spec);
        }
    }
}