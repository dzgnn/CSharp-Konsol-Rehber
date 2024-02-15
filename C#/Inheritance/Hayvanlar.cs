public class Hayvanlar:Canlilar{

    protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adapte olurlar.");   
    }

    public override void Tepki()
    {
        base.Tepki();
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}
    public class Kuslar:Hayvanlar{

        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Tepki();
        }
        public void Ucma(){

            Console.WriteLine("Kuşlar Uçar");
        }

    }

    public class Surungenler:Hayvanlar{

        public void Surunme(){

            Console.WriteLine("Sürüngenler sürünür.");
        }
    }


