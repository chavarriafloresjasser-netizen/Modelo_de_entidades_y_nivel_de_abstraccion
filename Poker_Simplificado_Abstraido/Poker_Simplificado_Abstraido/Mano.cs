public class Mano
{
    private List<Carta> cartas = new List<Carta>();

    public void AgregarCarta(Carta carta)
    {
        if (cartas.Count >= 5)
            throw new Exception("Máximo 5 cartas"); // Regla de negocio

        cartas.Add(carta);
    }

    public int ObtenerPuntaje()
    {
        return cartas.Sum(c => (int)c.Valor);
    }

    public void Mostrar()
    {
        foreach (var c in cartas)
            Console.WriteLine(c);
    }
}