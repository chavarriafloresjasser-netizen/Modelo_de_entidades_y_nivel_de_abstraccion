
class Program
{
    static void Main(string[] args)
    {
        Contenido c1 = new Contenido("Avengers", 120, "Accion", "Pelicula");
        Contenido c2 = new Contenido("Stranger Things", 50, "Ciencia Ficcion", "Serie");

        Usuario user = new Usuario("Jonathan", "jonathan@email.com");

        c1.MostrarDetalles();
        Console.WriteLine();

        user.AgregarALista(c1);
        user.AgregarALista(c2);

        Console.WriteLine();

        user.VerLista();

        Console.WriteLine();

        user.VerContenido(c1);
    }
}