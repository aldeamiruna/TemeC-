using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Tema4_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string textFile = "C:\\Users\\MA073495\\Desktop\\Cursuri\\C#\\Tema4\\Tema4_ex2\\vector.txt";

            using (StreamReader file = new StreamReader(textFile))
            {
                int counter = 0;
                string line;
                List<int> list = new List<int>();

                while ((line = file.ReadLine()) != null)
                {
                    list.Add(int.Parse(line));
                    counter++;
                }

                int[] arr = list.ToArray();
                Array.Sort(arr);
                file.Close();
                foreach(int item in arr)
                {
                    Console.WriteLine("item =" + item.ToString());
                }
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }
}
