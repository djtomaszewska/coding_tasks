using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskThree
{
    public class FilesGenerator
    {
        string path = "..\\..\\.\\TaskThreeFiles\\", rName = RandomName(RandomNumber(1, 6));    
        string[] extension = { ".txt", ".xml", ".zip" };
        private static Random random = new Random();

        public string Path { get => path; set => path = value; }

        static int RandomNumber(int min, int max)
        {
            Random rNumber = new Random();
            return rNumber.Next(min, max);
        }
        public static string RandomName(int nameLength)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, nameLength).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        string PathCreate()
        {

            return Path;
        }

        public void FileGenerate()
        {
            int counter = 0;
            while (counter <= 4)
            {
                /*if (File.Exists("..\\..\\..\\TaskThreeFiles\\" + rName + extension[0]))
                    File.Delete("..\\..\\..\\TaskThreeFiles\\" + rName + extension[0]);*/
                
                    File.Create("..\\..\\..\\TaskThreeFiles\\" + rName + extension[0]);
                counter++;
            }
            while (counter <=9)
            {
                /*if (File.Exists("..\\..\\..\\TaskThreeFiles\\" + rName + extension[1]))
                    File.Delete("..\\..\\..\\TaskThreeFiles\\" + rName + extension[1]);*/
                
                    File.Create("..\\..\\..\\TaskThreeFiles\\" + rName + extension[1]);
                counter++;
            }
            while (counter<=14)
            {
                /*if (File.Exists("..\\..\\..\\TaskThreeFiles\\" + rName + extension[2]))
                    File.Delete("..\\..\\..\\TaskThreeFiles\\" + rName + extension[2]);*/
                
                    File.Create("..\\..\\..\\TaskThreeFiles\\" + rName + extension[2]);
                counter++;
            }
        }

    }
            
       
    }

