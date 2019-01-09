using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\hp\Desktop\space.txt";

            using (var reader = new StreamReader(filePath))
            {
                int spaceCount = 0;
                string line;
                while(( line = reader.ReadLine()) != null)
                {
                    if (line.Contains(" "))
                    {
                        for (int i = 0; i < line.Length-1; i++)
                        {
                            if(line[i]==' ')
                            {
                                spaceCount+=1;
                            }
                        }
                    }            
                }
                Console.WriteLine(spaceCount);
            }
        }
    }
}
