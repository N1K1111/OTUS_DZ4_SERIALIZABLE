using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ4_SERIALIZABLE
{
    internal class Serializer
    {
        public string SerializeToCsv<T>(T obj)
        {
            var fields = typeof(T).GetFields();
            var values = new List<string>();
            foreach ( var field in fields )
            {
                values.Add(field.GetValue(obj).ToString());
            }
            return string.Join(",", values.ToArray());
        }

        public T DeserializeToCsv<T>(string csvString)where T : new()
        {
            var fields = typeof(T).GetFields();
            var values = csvString.Split(',');
            var obj = new T();

            for (int i = 0; i < fields.Length; i++)
            {
                fields[i].SetValue(obj, Convert.ChangeType(values[i], fields[i].FieldType));
            }
            return obj;

        }
    }
}
