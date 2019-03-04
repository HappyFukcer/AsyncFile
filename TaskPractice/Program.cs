using System;
using System.Threading.Tasks;

namespace TaskPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            First();
            await Second();
            Third();
            Forth();
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }

        static async Task First()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                    Console.Write(1);
            });
        }

        static async Task Second()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                    Console.Write(2);
            });
        }

        static async Task Third()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                    Console.Write(3);
            });
        }

        static async Task Forth()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                    Console.Write(4);
            });
        }
    }
}
