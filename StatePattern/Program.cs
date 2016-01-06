using System;
namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor instance = new Actor();
            //Console.WriteLine("Build Over" + instance.GetType().ToString() );
            Console.WriteLine("Build Over" + instance.GetCurrentState().ToString() );
            do
            {
                while (!Console.KeyAvailable)
                {
                    instance.Update();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
