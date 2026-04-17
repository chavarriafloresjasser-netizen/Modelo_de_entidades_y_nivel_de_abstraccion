public class Lobo : Animal
{
    public Lobo(string nombre, int edad, double peso)
        : base(nombre, "Lobo", edad, peso)
    {
    }

    public override void HacerSonido()
    {
        System.Console.WriteLine(Nombre + " aúlla ");
    }
}