using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    public class World
    {
        public List<Area> Locations = new List<Area>();

        public World()
        {

            Locations.Add(new Area() { Name = "Mountain Vesuius" });
            Locations.Add(new Area() { Name = "Sky is the limit" });
            Locations.Add(new Area() { Name = "Whitehouse" });
            Locations.Add(new Area() { Name = "Columbia (wheee)" });

        }

        public string GetLocationList()
        {
            string output = "\nLocations\n";
            int number = 1;
            foreach (Area area in Locations)
            {

                output += $"{number}. {area.Name}\n";

                number++;

            }

            return output;
        }

    }
}

