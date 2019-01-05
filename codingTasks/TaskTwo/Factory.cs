using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public enum ELanguages
    {
        pl,
        eng,
        esp,
        ger,
        fr,
        it
    }
    public class Factory
    {
        public  virtual IHello GetHello(ELanguages eLanguages)
        {
            IHello hello = null;
            switch (eLanguages)
            {
                case ELanguages.pl:
                    hello = new PolishHello();
                    break;
                case ELanguages.eng:
                    hello = new EnglishHello();
                    break;
                case ELanguages.esp:
                    hello = new SpanishHello();
                    break;
                case ELanguages.ger:
                    hello = new GermanHello();
                    break;
                case ELanguages.fr:
                    hello = new FrenchHello();
                    break;
                case ELanguages.it:
                    hello = new ItalianHello();
                    break;
                default:
                    break;
            }

            return hello;
        }

        
    }

    public class HelloProcessor
    {
        IHello hello = null;
        public void SayHello(ELanguages eLanguages)
        {
            Factory factory = new Factory();
            this.hello = factory.GetHello(eLanguages);
            this.hello.SayHello();

        }
    }
}
