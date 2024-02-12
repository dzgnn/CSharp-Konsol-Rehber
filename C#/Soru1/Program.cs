using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            ArrayList listeasal = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ", i+1);
                int sayi = int.Parse(Console.ReadLine());

                if (sayi==1)
                    liste.Add(sayi);
                else if (sayi==2)
                    listeasal.Add(sayi);    
                

            for (int n = 2; n < sayi-1; n++)
            {
                if (sayi % n == 0){
                    
                    liste.Add(sayi);
                    break;}
                else
                {
                    listeasal.Add(sayi);
                    break;
                }
            }

            }
            
            Console.WriteLine("ASAL SAYILAR");
            foreach (var assa in listeasal)
            {
                
                Console.WriteLine(assa);
            }

            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            foreach (var notasa in liste)
            {
                
                Console.WriteLine(notasa);
            }
        }

        
    }
}