﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals;
public abstract class Animal
{
    protected Animal(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
