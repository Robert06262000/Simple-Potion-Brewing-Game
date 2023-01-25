using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_making_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int qNum = 1;
            //Ingredients are constantly given from an array; the user decides whether or not to add that ingredient.
            Potion_Body potion = new Potion_Body() //default potion
            {
                color = "clear",
                weight = 1.00,
                flatness = 0
            };
            while(qNum <= 20)
            {
                Console.Clear();
                Cooking.Brew(potion, qNum);
                qNum++;
                Potion_Body.potionRules(potion.flatness);
            }
            Console.WriteLine($"Congratulations! You made a {Potion_Body.bubbleTest(potion.flatness)}, " +
                $"{potion.color} {Potion_Body.nameAssignment(potion.color)} potion! " +
                $"It weighs {potion.weight} pounds.");
        }
    }
}
