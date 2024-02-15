using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

        
        TohumluBitkiler bugday = new TohumluBitkiler();
        bugday.TohumlaUreme();
        

        Console.WriteLine("*********");

        Kuslar kartal = new Kuslar();
        kartal.Ucma();

        }
    }
}