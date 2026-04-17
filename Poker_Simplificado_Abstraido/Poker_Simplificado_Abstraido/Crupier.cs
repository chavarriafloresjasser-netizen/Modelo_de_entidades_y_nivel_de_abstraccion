public class Crupier : Persona
{
    public Crupier(string nombre) : base(nombre) { }

    public void RepartirCartas(List<Jugador> jugadores, Baraja baraja)
    {
        foreach (var jugador in jugadores)
        {
            for (int i = 0; i < 5; i++)
            {
                jugador.RecibirCarta(baraja.Repartir());
            }
        }
    }
}