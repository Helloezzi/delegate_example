using System;

namespace DelegateTest
{
    public class Cat
    {
        public delegate void EndRunEventHandler(string result);
        public event EndRunEventHandler EndRunEvent;

        public void Run(int time)
        {
            for(int i = 0; i < time; i++)
            {
                Console.WriteLine("cat running..." + i);
            }

            EndRunEvent.Invoke($"result : {time}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.EndRunEvent += Cat_EndRunEvent;
            cat.Run(100);
            Console.ReadLine();
        }

        private static void Cat_EndRunEvent(string result)
        {
            Console.WriteLine(result);
        }
    }
}
