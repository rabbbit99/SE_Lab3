using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "LINQ - это набор расширений для .NET, которые охватывают интегрированные в язык операции запроса, объединения и преобразования. Он расширяет синтакс языка C# для запросов и предоставляет библиотеки классов, позволяющие использовать преимущества этих возможностей.";

            var res = from n in s.ToLower().ToCharArray()
                      group n by n into g
                      let count = g.Count()
                      orderby count descending
                      select new { Letter = g.Key, Count = count };
            foreach (var item in res)
                Console.WriteLine(item);
        }
    }
}
