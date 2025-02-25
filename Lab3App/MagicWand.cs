﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string description) : base(description) { }

        public override void Display()
        {
            Console.WriteLine("Magic Wand " + Description + " is displayed");
        }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            DoAction();
        }

        public override void DoAction()
        {
            Console.WriteLine("Magic Wand is used");
        }
    }
}