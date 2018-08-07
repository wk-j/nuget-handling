using System;
using Newtonsoft.Json;

namespace MyApp1 {
    class Program {
        static void Main(string[] args) {
            var json = JsonConvert.SerializeObject(new { A = 100 });
            Console.WriteLine(json);
        }
    }
}
