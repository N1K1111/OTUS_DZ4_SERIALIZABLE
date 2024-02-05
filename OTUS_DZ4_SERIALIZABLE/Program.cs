using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace OTUS_DZ4_SERIALIZABLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bar bar = new Bar(1,2,3,4,5);
            
            BinaryFormatter bf = new BinaryFormatter();


            using (var stream = new FileStream("data.csv",FileMode.Create)) 
            {
                bf.Serialize(stream, bar);
            }
            */

            var obj = F.Get();
            var serializer = new Serializer();

            // Замер времени функции сериализации
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            List<string> list = new List<string>();
            for (int i = 0; i < 100_000; i++)
            {
                list.Add(serializer.SerializeToCsv(obj));

            }

            stopwatch.Stop();
            var elapsed = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Время на сериализацию: {elapsed} мс");

            // Замер времени JSON сериализации
            var stopwatchJson = new Stopwatch();
            stopwatchJson.Start();

            List<string> list2 = new List<string>();
            for (int i = 0; i < 100_000; i++)
            {
                list2.Add(JsonConvert.SerializeObject(obj));

            }

            stopwatchJson.Stop();
            var elapsedJson = stopwatchJson.ElapsedMilliseconds;

            Console.WriteLine($"Время на JSON сериализацию: {elapsedJson} мс");

            // Замер времени функции десериализации
            var stopwatchDeserialization = new Stopwatch();
            stopwatchDeserialization.Start();

            foreach (var item in list)
            {
                var deserializedObj = serializer.DeserializeToCsv<F>(item);

            }

            stopwatchDeserialization.Stop();
            var elapsedDeserialization = stopwatchDeserialization.ElapsedMilliseconds;

            Console.WriteLine($"Время на десериализацию: {elapsedDeserialization} мс");

            // Замер времени JSON десериализации
            var stopwatchJsonDeserialization = new Stopwatch();
            stopwatchJsonDeserialization.Start();

            foreach(var item in list2)
            {
                F deserializedJsonObj = JsonConvert.DeserializeObject<F>(item);

            }

            stopwatchJsonDeserialization.Stop();
            var elapsedJsonDeserialization = stopwatchJsonDeserialization.ElapsedMilliseconds;

            Console.WriteLine($"Время на JSON десериализацию: {elapsedJsonDeserialization} мс");

        }
    }
}
