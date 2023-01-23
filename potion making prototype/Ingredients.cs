using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_making_prototype
{
    class Ingredients
    {
        public static Dictionary<string, string> foodColor = new Dictionary<string, string>
        {
            {"troll hair", "blue"},
            {"pixie dust", "gold"},
            {"rose petals", "red"},
            {"dragon's flame", "yellow"},
            {"wisp essence", "white"},
            {"flash frozen water", "light blue"},
            {"goblin tusk", "grey"},
            {"cookie crumbs", "grey"},
            {"a gram of gold", "gold"},
            {"ale", "light brown"},
            {"slime goop", "light blue"},
            {"jasmine", "purple"},
            {"passion", "red"},
            {"sulfur", "yellow"},
            {"black rose petals", "black"},
            {"shade essence", "black"},
            {"boar tusk", "white"},
            {"chimera tail", "light brown"},
            {"hawk talons", "light brown"},
            {"backfat oil", "yellow"}
        };
        public static Dictionary<string, double> foodMass = new Dictionary<string, double>
        {
            {"troll hair", 2.0},
            {"pixie dust", 0.12},
            {"rose petals", 0.05},
            {"dragon's flame", 1.3},
            {"wisp essence", 0.01},
            {"flash frozen water", 0.63},
            {"goblin tusk", 1.6},
            {"cookie crumbs", 0.3},
            {"a gram of gold", 0.02},
            {"ale", 0.05},
            {"slime goop", 1.0},
            {"jasmine", 0.04},
            {"passion", 2.0},
            {"sulfur", 1.5},
            {"black rose petals", 0.06},
            {"shade essence", 0.01},
            {"boar tusk", 1.68},
            {"chimera tail", 3.0},
            {"hawk talons", 1.02},
            {"backfat oil", 2.04}
        };
        public static Dictionary<string, int> foodBubbles = new Dictionary<string, int>
        {
            {"troll hair", -2},
            {"pixie dust", 3},
            {"rose petals", -1},
            {"dragon's flame", 5},
            {"wisp essence", 1},
            {"flash frozen water", 2},
            {"goblin tusk", 1},
            {"cookie crumbs", -2},
            {"a gram of gold", -1},
            {"ale", 3},
            {"slime goop", 1},
            {"jasmine", -1},
            {"passion", 3},
            {"sulfur", -2},
            {"black rose petals", -1},
            {"shade essence", 1},
            {"boar tusk", 1},
            {"chimera tail", -2},
            {"hawk talons", -2},
            {"backfat oil", 4}
        };
    }
}
