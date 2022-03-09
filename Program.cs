using System;
using abstraindo_rpg_dotnet.Entities;

namespace abstraindo_rpg_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 22, "Knight");
            Console.WriteLine("Hello " + hero.Name + "!");
        }
    }
}
