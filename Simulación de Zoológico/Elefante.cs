public class Elefante : Animal
{
    public Elefante(string nombre, int edad, double peso)
        : base(nombre, "Elefante", edad, peso)
    {
    }

    public override void HacerSonido()
    {
        System.Console.WriteLine(Nombre + " hace sonido de trompeta ");
    }
}