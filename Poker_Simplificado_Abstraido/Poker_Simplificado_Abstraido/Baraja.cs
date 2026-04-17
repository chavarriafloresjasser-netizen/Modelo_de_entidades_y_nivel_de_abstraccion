public class Baraja
{
    private List<Carta> cartas;
    private Random random = new Random();

    public Baraja()
    {
        cartas = new List<Carta>();
        Inicializar();
    }

    private void Inicializar()
    {
        foreach (Palo palo in Enum.GetValues(typeof(Palo)))
        {
            foreach (Valor valor in Enum.GetValues(typeof(Valor)))
            {
                cartas.Add(new Carta(palo, valor));
            }
        }
    }

    public void Barajar()
    {
        cartas = cartas.OrderBy(x => random.Next()).ToList();
    }

    public Carta Repartir()
    {
        if (cartas.Count == 0)
            throw new Exception("No hay más cartas");

        Carta c = cartas[0];
        cartas.RemoveAt(0);
        return c;
    }
}