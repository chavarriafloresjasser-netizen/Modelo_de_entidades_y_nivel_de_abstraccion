public class Jugador : Persona
{
    public int Fichas { get; private set; }
    public Mano Mano { get; private set; }

    public Jugador(string nombre, int fichas) : base(nombre)
    {
        Fichas = fichas;
        Mano = new Mano();
    }

    public void Apostar(int cantidad)
    {
        if (cantidad > Fichas)
            throw new Exception("No tienes suficientes fichas"); // Regla de negocio

        Fichas -= cantidad;
    }

    public void RecibirCarta(Carta carta)
    {
        Mano.AgregarCarta(carta);
    }

    public void MostrarMano()
    {
        Console.WriteLine($"Mano de {Nombre}:");
        Mano.Mostrar();
    }
}