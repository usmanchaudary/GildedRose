﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ItemName : System.Attribute
    {
        public readonly string Name;
        
        public ItemName(string name)
        {
            this.Name = name;
        }
    }
}
