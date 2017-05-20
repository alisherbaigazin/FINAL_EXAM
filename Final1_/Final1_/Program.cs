using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final1_
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\1\Desktop\final_new\Final1_\Final1_\bin\Debug");
            FileSystemInfo[] fl = dir.GetFileSystemInfos();
            foreach(FileSystemInfo f in fl)
            {
                Console.WriteLine(f.Name);
                Console.ReadKey();
            }
            StreamReader file1 = new StreamReader(@"C:\Users\1\Desktop\final_new\Final1_\Final1_\bin\Debug\file1.txt");
            StreamReader file2 = new StreamReader(@"C:\Users\1\Desktop\final_new\Final1_\Final1_\bin\Debug\file2.txt");
            StreamReader file3 = new StreamReader(@"C:\Users\1\Desktop\final_new\Final1_\Final1_\bin\Debug\file3.txt");


            string[] ln1 = file1.ReadToEnd().Split();
            for(int i = 0; i < ln1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" ");
                }
            }
            string[] ln2 = file2.ReadToEnd().Split();
            for (int i = 0; i < ln2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            string[] ln3 = file3.ReadToEnd().Split();
            for (int i = 0; i < ln3.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
