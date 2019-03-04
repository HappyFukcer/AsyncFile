using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace TaskPractice
{
    class FilaAsync
    {
        public string Path { get; }

        public FilaAsync(string path)
        {
            Path = path;
        }

        public void ReadFile()
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                sr.ReadLine();
            }
        }

        public void WriteFile(object obj)
        {
            string s = (string)obj;
            try
            {
                using (StreamWriter sr = File.AppendText(Path))
                {
                    sr.WriteLine(s);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Thread[] thread = new Thread[10];

            for (int i = 0; i < thread.Length; i++)
            {
                thread[i] = new Thread(new ParameterizedThreadStart(new FilaAsync("file.txt").WriteFile));
            }

            for (int i = 0; i < thread.Length; i++)
            {
                thread[i].Start("Hello" + i);
            }

            Console.ReadKey();

        }

    }
}
