public class Carta
{
    public Palo Palo { get; private set; }
    public Valor Valor { get; private set; }

    public Carta(Palo palo, Valor valor)
    {
        Palo = palo;
        Valor = valor;
    }

    public override string ToString()
    {
        return $"{Valor} de {Palo}";
    }
}