using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_making_prototype
{
    class Potion_Body
    {
        public string color;
        public double weight;
        public int flatness; //0=flat, 20=bubbly

        public static int potionRules(int flat)
        {
            if (flat > 20) { flat = 20; }
            return flat;
        }
        public static string bubbleTest(int flat)
        {
            if(flat <= 0)
            {
                return "flat";
            }
            else if (flat > 0 && flat <= 5)
            {
                return "slightly bubbly";
            }
            else if (flat > 5 && flat <= 10)
            {
                return "fizzy";
            }
            else if (flat > 10 && flat < 20)
            {
                return "very fizzy";
            }
            else
            {
                return "gushing";
            }
        }
        public static string nameAssignment(string color)
        {
            if (color == "red") { return "rosey"; }
            else if (color == "blue") { return "midnight"; }
            else if (color == "gold") { return "sparkly"; }
            else if (color == "yellow") { return "bright"; }
            else if (color == "white") { return "hallow"; }
            else if (color == "light blue") { return "heroic"; }
            else if (color == "grey") { return "mysterious"; }
            else if (color == "light brown") { return "firm"; }
            else if (color == "purple") { return "beauty"; }
            else if (color == "black") { return "lunar"; }
            else { return "dull"; }
        }
    }
}
