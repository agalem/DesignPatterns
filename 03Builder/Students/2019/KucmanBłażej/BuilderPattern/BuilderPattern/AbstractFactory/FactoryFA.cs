﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.AbstractFactory
{
    public class FactoryFA : AbstractFactory
    {
        public FactoryFA(IFactory factory) : base(factory)
        {
        }
    }
}
