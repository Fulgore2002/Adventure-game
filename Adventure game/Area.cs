﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Adventure_game
{
    public class Area
    {
        public string Name;
        public BitmapImage LocationImage;

        public Area()
        {

            LocationImage = new BitmapImage(new Uri("LocationPlaceholder.bmp", UriKind.Relative));
        }

        public string PlayerVisit()
        {
            return $"Welcome to \"{Name}\"";
        }
    }
}
