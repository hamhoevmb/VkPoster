﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using VkNet.Model;

namespace VkPoster.Model
{
    public class GroupDto
    {
        public BitmapImage Image { get; set; }
        public string Description { get; set; }
        public string Name { get; internal set; }
    }
}
