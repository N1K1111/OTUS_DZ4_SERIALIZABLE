using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ4_SERIALIZABLE
{
    internal class Bar : ISerializable
    {
        int[] array = new int[5];

        public Bar(int num1, int num2, int num3, int num4, int num5)
        {
            array[0] = num1;
            array[1] = num1;
            array[2] = num1;
            array[3] = num1;
            array[4] = num1;
        }

        public void Deserialization(SerializationInfo info, StreamingContext context)
        {
            //array = info.GetValue("Bar",typeof(array));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Bar",array);
        }
    }
}