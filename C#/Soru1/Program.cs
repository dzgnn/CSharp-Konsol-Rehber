using System;
using System.Collections;
using Microsoft.VisualBasic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            ArrayList listeasal = new ArrayList();

            getPrimes(listeasal,liste);

            PrintResult(listeasal,liste);
        }

        public static void getPrimes(ArrayList Arrayasal, ArrayList Array1)
        {

            

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ", i+1);
                int sayi = int.Parse(Console.ReadLine());

                if (sayi==1)
                    Array1.Add(sayi);
                else if (sayi==2)
                    Arrayasal.Add(sayi);    
                

            for (int n = 2; n < sayi-1; n++)
            {
                if (sayi % n == 0){
                    
                    Array1.Add(sayi);
                    break;
                    
                    }
                else
                {
                    Arrayasal.Add(sayi);
                    break;
                }
            }     
            }

        }

        static void PrintResult(ArrayList Arrayasal, ArrayList ArrayList2){


            Console.WriteLine("ASAL SAYILAR");
            foreach (var assa in Arrayasal)
            {
                
                Console.WriteLine(assa);
            }

            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            foreach (var notasa in ArrayList2)
            {
                
                Console.WriteLine(notasa);
            }                    


        }
    
    }
    }
