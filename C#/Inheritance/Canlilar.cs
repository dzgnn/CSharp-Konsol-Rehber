public class Canlilar
{
    protected void Beslenme(){
        Console.WriteLine("Canlilar beslenir.");
    }

    protected void Solunum(){
        Console.WriteLine("Canlilar Solunum yapar.");
    }

    public virtual void Tepki(){

        Console.WriteLine("Canlılar tepki verir");
    }
}