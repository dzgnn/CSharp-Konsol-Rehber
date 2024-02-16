
namespace Directory // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bas:
            DirectoryFunctions islem = new DirectoryFunctions();


            Console.WriteLine("REHBERE HOŞGELDİN!");
            Console.WriteLine("(1) -Telefon numarasi kaydet");
            Console.WriteLine("(2) -Telefon numarasi sil");
            Console.WriteLine("(3) -Telefon numarasi güncelle");
            Console.WriteLine("(4) -Kisileri Listele");
            Console.WriteLine("(5) -Rehberde arama");
            Console.Write("Lütfen bir islem sayisi giriniz : ");
            
            int secim = int.Parse(Console.ReadLine());
        
            switch (secim)
            {
                case 1:
                    islem.add();
                    Console.WriteLine("******");
                    
                    goto Bas;
                case 2:
                    islem.delete();
                    Console.WriteLine("****");
                    
                    goto Bas;
                case 3:
                    islem.update();
                    Console.WriteLine("****");
                    
                    goto Bas;
                case 4:
                    islem.listele();
                    Console.WriteLine("****");
                    goto Bas;
                case 5:
                    islem.search();
                    Console.WriteLine("****");  
                    goto Bas;  
            }
        }
    }
}