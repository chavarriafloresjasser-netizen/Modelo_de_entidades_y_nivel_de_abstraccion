public class Program
{
    public static void Main()
    {
        Zoologico zoo = new Zoologico(5);

        Leon leon1 = new Leon("Simba", 5, 190);
        zoo.AgregarAnimal(leon1);

        Elefante elefante1 = new Elefante("Dumbo", 10, 500);
        zoo.AgregarAnimal(elefante1);

        Lobo lobo1 = new Lobo("Alfa", 4, 50);
        zoo.AgregarAnimal(lobo1);


        zoo.MostrarAnimales();
    }
}