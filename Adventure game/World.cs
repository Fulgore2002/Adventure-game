using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    public class World
    {
        public List<Area> Location = new List<Area>();

        public World()
        {
            Location.Add(new Area() { Name = "Montain Vesuvius" });
            Location.Add(new Area() { Name = "Sky is the Limit" });
            Location.Add(new Area() { Name = "MoWhitehouse" });
            Location.Add(new Area() { Name = "Columbia" });
        }

        public string GetLocationList()
        {
            string output = "\nLocations\n";
            int number = 1;
            foreach (Area area in Location)

            {
                output += $"  {number}. {area.Name}\n";

                number++;
            }

            return output;
        }
    }
}

