using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public interface IHello
    {
        void SayHello();
    }

    class PolishHello : IHello
    {
        public void SayHello() => Console.WriteLine("Witaj swiecie!");  
    }

    class EnglishHello : IHello
    {
        public void SayHello() => Console.WriteLine("Hello world!");
    }

    class GermanHello:IHello
    {
        public void SayHello() => Console.WriteLine("Hallo Welt!");
    }

    class SpanishHello:IHello
    {
        public void SayHello() => Console.WriteLine("¡Hola Mundo!");
    }

    class FrenchHello:IHello
    {
        public void SayHello() => Console.WriteLine("Bonjour monde!");
    }

    class ItalianHello:IHello
    {
        public void SayHello() => Console.WriteLine("Ciao mondo!");
    }
}
