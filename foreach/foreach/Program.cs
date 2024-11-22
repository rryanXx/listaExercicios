using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listaamigo = { "ryan","fer","maria","didi" };

            Console.WriteLine("os nome dos amigos sao");
            foreach(string nome_amigos in listaamigo )
            {
                Console.WriteLine(nome_amigos);

            }

            Console.ReadKey();












        }
    }
}
