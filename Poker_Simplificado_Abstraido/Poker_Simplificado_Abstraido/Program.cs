class Program
{
    static void Main(string[] args)
    {
        Juego juego = new Juego();

        Jugador j1 = new Jugador("Juan", 100);
        Jugador j2 = new Jugador("Ana", 100);

        juego.AgregarJugador(j1);
        juego.AgregarJugador(j2);

        juego.Iniciar();

        juego.MostrarManos();

        juego.DeterminarGanador();

        Console.ReadLine();
    }
}
