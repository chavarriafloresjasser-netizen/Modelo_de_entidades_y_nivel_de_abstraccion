
/// <summary>
/// Clase abstracta que representa un animal dentro delzoológico
/// </summary>
public abstract class Animal
{
    //  Atributos privados (encapsulación)
    private string nombre;
    private string especie;
    private int edad;
    private double peso;

    //  Propiedades (get y set)
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Especie
    {
        get { return especie; }
        set { especie = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    //  Constructor
    public Animal(string nombre, string especie, int edad, double peso)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Peso = peso;
    }

    //  Métodos (comportamiento)
    public void Comer()
    {
        System.Console.WriteLine(nombre + " está comiendo.");
    }

    public void Dormir()
    {
        System.Console.WriteLine(nombre + " está durmiendo.");
    }

    public abstract void HacerSonido();

    public void MostrarInfo()
    {
        System.Console.WriteLine("Nombre: " + nombre);
        System.Console.WriteLine("Especie: " + especie);
        System.Console.WriteLine("Edad: " + edad);
        System.Console.WriteLine("Peso: " + peso);
    }
}