﻿using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    
    public class ObjectPrefer(Preferred pre):Attribute
    {
        public Preferred preferred = pre;
    }
}
