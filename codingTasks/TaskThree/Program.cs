using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            FilesGenerator filesGenerator = new FilesGenerator();
            string path = "..//..//..//TaskThreeFiles//";
            if (Directory.Exists(path)) Directory.Delete(path, true);
            Directory.CreateDirectory(path);
            string[] filesList = Directory.GetFiles(path);

           
            foreach (string fl in filesList)
            {
                Console.WriteLine(fl.Replace(path, ""));
                
            }
            Console.WriteLine("...");
            Console.ReadKey();
            filesGenerator.FileGenerate();
            foreach (string fl in filesList)
            {
                Console.WriteLine(fl);
            }
            Console.ReadKey();

        }
    }
}
