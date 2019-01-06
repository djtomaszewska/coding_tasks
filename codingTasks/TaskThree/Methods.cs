using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskThree
{
    
    class Methods
    {
        string path = "..\\..\\..\\TaskThree_files\\";
        
        public void DisplayFiles()
        {
            string[] filesList = Directory.GetFiles(path);
            foreach (string fl in filesList)
            {
                Console.WriteLine(fl.Replace(path, ""));
            }
            Console.ReadKey();
        }

        public void DeleteXmlFiles()
        {

        }
    }
}
