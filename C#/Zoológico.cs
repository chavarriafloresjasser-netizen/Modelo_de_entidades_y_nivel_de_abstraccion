public class Zoologico
{
    private Animal[] animales;
    private int contador;

    public Zoologico(int capacidad)
    {
        animales = new Animal[capacidad];
        contador = 0;
    }

    public void AgregarAnimal(Animal animal)
    {
        if (contador < animales.Length)
        {
            animales[contador] = animal;
            contador++;
        }
        else
        {
            System.Console.WriteLine("Zoológico lleno");
        }
    }

    public void MostrarAnimales()
    {
        for (int i = 0; i < contador; i++)
        {
            animales[i].MostrarInfo();
            animales[i].HacerSonido();
            System.Console.WriteLine("----------------");
        }
    }
}