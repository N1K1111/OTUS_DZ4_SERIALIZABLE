﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ4_SERIALIZABLE
{
    internal class F
    {
        public int i1, i2, i3, i4, i5;
        public static F Get() => new F {i1=1, i2=2, i3=3, i4=4, i5=5 };
    }
}
