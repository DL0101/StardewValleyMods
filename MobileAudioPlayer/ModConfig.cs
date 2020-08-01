﻿using Microsoft.Xna.Framework;
using Netcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAudioPlayer
{
    public class ModConfig
    {
        public bool EnableMod { get; set; } = true;
        public Color BackgroundColor { get; set; } = Color.CornflowerBlue;
        public string ListLineOne { get; set; } = "{1}";
        public string ListLineTwo { get; set; } = "{2} - {3}";
        public Color LineOneColor { get; set; } = Color.White;
        public Color LineTwoColor { get; set; } = Color.LightGray;
        public float MarginX { get; set; } = 4;
        public int MarginY { get; set; } = 4;
        public Color HighlightColor { get; set; } = new Color(90, 139, 227, 255);
        public bool PlayAll { get; set; } = true;
        public bool LoopPlaylist { get; set; } = true;
        public float LineOneScale { get; set; } = 0.5f;
        public float LineTwoScale { get; set; } = 0.4f;
    }
}