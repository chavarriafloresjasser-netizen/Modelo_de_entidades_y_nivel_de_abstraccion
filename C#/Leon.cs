public class Leon : Animal
{
    public Leon(string nombre, int edad, double peso)
        : base(nombre, "León", edad, peso)
    {
    }

    public override void HacerSonido()
    {
        System.Console.WriteLine(Nombre + " ruge ");
    }
}