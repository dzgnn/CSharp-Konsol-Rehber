using System;
using System.ComponentModel;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisakenar = 3;
            dikdortgen.uzunkenar = 5;

            Console.WriteLine("alan : {0}", dikdortgen.AlanHesapla());

            // DikdortgenStruct dikdortgenStruct = new DikdortgenStruct();
            DikdortgenStruct dikdortgenStruct;
            dikdortgenStruct.kisakenar = 5;
            dikdortgenStruct.uzunkenar = 10;
            Console.WriteLine("alan : {0}", dikdortgenStruct.AlanHesapla());
        }
    }

    class Dikdortgen
    {

        public int kisakenar;

        public int uzunkenar;

        public long AlanHesapla(){

            return this.kisakenar * this.uzunkenar;
        }
    }


    struct DikdortgenStruct
    {
        public int kisakenar;

        public int uzunkenar;


        public long AlanHesapla(){


            return this.kisakenar * this.uzunkenar; 
        }

    }
}