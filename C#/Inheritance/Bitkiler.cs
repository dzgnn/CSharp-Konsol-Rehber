public class Bitkiler:Canlilar
{
    protected void Fotosentez(){
        Console.WriteLine("Bitkiler Fotosentez yapar.");
    }

    public override void Tepki()
    {
        //base.Tepki();
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }
}
    public class TohumluBitkiler:Bitkiler
    {
    // public override void Tepki()
    // {
    //     //base.Tepki();
    //     Console.WriteLine("Tohumlu Bitkiler tohumla teppki de verir.");
    // }
    public TohumluBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Tepki();
        }
    public void TohumlaUreme(){
        Console.WriteLine("Tohumlu bitkiler tohumla ürerler.");
    }

    }
    public class digerBitkiler:Bitkiler{
        
        public void SporlaUreme(){
       Console.WriteLine("Diğer bitkiler Sporla Ürerler");
        }
    }

