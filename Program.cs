using System;
using abstraindo_rpg_dotnet.src.Entities;

namespace abstraindo_rpg_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 22, "Knight");
            Wizard Jennica = new Wizard("Jennica", 23, "White Wizard");
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jennica.Attack());
        }
    }
}
