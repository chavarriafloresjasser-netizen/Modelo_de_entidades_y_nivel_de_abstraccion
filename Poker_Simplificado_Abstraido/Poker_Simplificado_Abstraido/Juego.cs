public class Juego
{
    private List<Jugador> jugadores;
    private Baraja baraja;
    private Crupier crupier;

    public Juego()
    {
        jugadores = new List<Jugador>();
        baraja = new Baraja();
        crupier = new Crupier("Dealer");
    }

    public void AgregarJugador(Jugador jugador)
    {
        jugadores.Add(jugador);
    }

    public void Iniciar()
    {
        baraja.Barajar();
        crupier.RepartirCartas(jugadores, baraja);
    }

    public void MostrarManos()
    {
        foreach (var jugador in jugadores)
        {
            jugador.MostrarMano();
            Console.WriteLine();
        }
    }

    public void DeterminarGanador()
    {
        var ganador = jugadores.OrderByDescending(j => j.Mano.ObtenerPuntaje()).First();

        Console.WriteLine($"El ganador es {ganador.Nombre} con {ganador.Mano.ObtenerPuntaje()} puntos");
    }
}