using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Program
    {

        static void Main(string[] args)
        {

            HelloProcessor helloProcessor = new HelloProcessor();
            ELanguages[] eLanguages = (ELanguages[])Enum.GetValues(typeof(ELanguages));

            foreach (var elang in eLanguages)
            {
                helloProcessor.SayHello(elang);
            }
            Console.ReadKey();
        }
    }
}
