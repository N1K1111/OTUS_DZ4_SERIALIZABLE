using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ4_SERIALIZABLE
{
    [Serializable]
    public class Foo
    {
        int num1, num2, num3, num4,num5;

        public Foo(int num1, int num2, int num3, int num4, int num5)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.num5 = num5;
        }
    }
}
