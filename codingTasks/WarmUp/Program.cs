using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Program
    {
       static float Volume(float a, float b, float c) => a * b * c;
        static float Area(float a, float b, float c) => a * 2 + b * 2 + c * 2;
        static float VolumeAA(float a, float b, float c, int h) => a * h * b * c;
        //ok, scratch that, not volume, area. Think girl, think!
        static void Main(string[] args)
        {
            float volA = 0, volB = 0, volC = 0;
            int count = 0;
            Console.WriteLine("Please enter the following values: ");
            Console.Write("Side a: ");
            volA = Convert.ToSingle(Console.ReadLine());
            Console.Write("Side b: ");
            volB = Convert.ToSingle(Console.ReadLine());
            Console.Write("Side c: ");
            volC = Convert.ToSingle(Console.ReadLine());
            Console.Write("Number of boxes: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume of single box is: {0}", Volume(volA, volB, volC));
                        
            Console.ReadKey();

        }

        


    }
}
