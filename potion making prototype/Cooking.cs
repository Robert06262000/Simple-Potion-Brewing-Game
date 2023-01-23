using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_making_prototype
{
    class Cooking : Ingredients
    {
        public static void Brew(Potion_Body potion, int qNum)
        {
            string ans;
            string ingredient;
            Console.WriteLine("Enter 'y' or 'n' to add or ignore ingredient.");
            switch(qNum)
            {
                case 1:
                    ingredient = "troll hair";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 2:
                    ingredient = "pixie dust";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 3:
                    ingredient = "rose petals";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 4:
                    ingredient = "dragon's flame";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 5:
                    ingredient = "wisp essence";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 6:
                    ingredient = "flash frozen water";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 7:
                    ingredient = "goblin tusk";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 8:
                    ingredient = "cookie crumbs";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 9:
                    ingredient = "a gram of gold";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 10:
                    ingredient = "ale";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 11:
                    ingredient = "slime goop";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 12:
                    ingredient = "jasmine";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 13:
                    ingredient = "passion";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 14:
                    ingredient = "sulfur";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 15:
                    ingredient = "black rose petals";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 16:
                    ingredient = "shade essence";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 17:
                    ingredient = "boar tusk";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 18:
                    ingredient = "chimera tail";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 19:
                    ingredient = "hawk talons";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
                case 20:
                    ingredient = "backfat oil";
                    Console.WriteLine(ingredient);
                    ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        potion.color = foodColor[ingredient];
                        potion.weight += foodMass[ingredient];
                        potion.flatness += foodBubbles[ingredient];
                    }
                    break;
            }
        }
    }
}
