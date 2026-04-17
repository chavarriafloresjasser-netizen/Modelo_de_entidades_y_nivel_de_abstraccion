using System;
using System.Collections.Generic;


// CLASE ABSTRACTA BASE

public abstract class DispositivoIoT
{
    // Atributos esenciales (abstracción)
    public string Id { get; set; }
    public string Nombre { get; set; }
    public bool Estado { get; set; }
    public string Ubicacion { get; set; }
    public bool Conectado { get; set; }

    // Constructor
    public DispositivoIoT(string id, string nombre, string ubicacion)
    {
        Id = id;
        Nombre = nombre;
        Ubicacion = ubicacion;
        Estado = false;
        Conectado = false;
    }

    // Métodos comunes
    public void Encender()
    {
        if (Conectado)
        {
            Estado = true;
            Console.WriteLine($"{Nombre} encendido.");
        }
        else
        {
            Console.WriteLine($"{Nombre} no está conectado.");
        }
    }

    public void Apagar()
    {
        Estado = false;
        Console.WriteLine($"{Nombre} apagado.");
    }

    public void Conectar()
    {
        Conectado = true;
        Console.WriteLine($"{Nombre} conectado.");
    }

    public void Desconectar()
    {
        Conectado = false;
        Console.WriteLine($"{Nombre} desconectado.");
    }

    public void ObtenerEstado()
    {
        Console.WriteLine($"Dispositivo: {Nombre}");
        Console.WriteLine($"Estado: {(Estado ? "Encendido" : "Apagado")}");
        Console.WriteLine($"Conectado: {(Conectado ? "Sí" : "No")}");
        Console.WriteLine($"Ubicación: {Ubicacion}");
        Console.WriteLine("--------------------------");
    }

    // Método abstracto (obliga a las clases hijas a implementarlo)
    public abstract void FuncionEspecifica();
}


// CLASE SENSOR

public class Sensor : DispositivoIoT
{
    public double Valor { get; set; }

    public Sensor(string id, string nombre, string ubicacion)
        : base(id, nombre, ubicacion)
    {
    }

    public override void FuncionEspecifica()
    {
        Valor = new Random().Next(0, 100);
        Console.WriteLine($"{Nombre} detecta valor: {Valor}");
    }
}


// CLASE ACTUADOR

public class Actuador : DispositivoIoT
{
    public Actuador(string id, string nombre, string ubicacion)
        : base(id, nombre, ubicacion)
    {
    }

    public override void FuncionEspecifica()
    {
        Console.WriteLine($"{Nombre} ejecuta una acción (ej: encender luz o abrir puerta).");
    }
}


// CLASE CASA INTELIGENTE

public class CasaInteligente
{
    private List<DispositivoIoT> dispositivos = new List<DispositivoIoT>();

    public void AgregarDispositivo(DispositivoIoT dispositivo)
    {
        dispositivos.Add(dispositivo);
    }

    public void MostrarDispositivos()
    {
        Console.WriteLine("=== DISPOSITIVOS EN CASA ===");
        foreach (var d in dispositivos)
        {
            d.ObtenerEstado();
        }
    }

    public void EjecutarFunciones()
    {
        Console.WriteLine("=== EJECUTANDO FUNCIONES ===");
        foreach (var d in dispositivos)
        {
            d.FuncionEspecifica();
        }
    }
}


// PROGRAMA PRINCIPAL

public class Program
{
    public static void Main()
    {
        // Crear casa inteligente
        CasaInteligente casa = new CasaInteligente();

        // Crear dispositivos
        Sensor sensorTemp = new Sensor("1", "Sensor de Temperatura", "Sala");
        Actuador luz = new Actuador("2", "Luz Inteligente", "Habitación");

        // Agregar a la casa
        casa.AgregarDispositivo(sensorTemp);
        casa.AgregarDispositivo(luz);

        // Conectar dispositivos
        sensorTemp.Conectar();
        luz.Conectar();

        // Encender dispositivos
        sensorTemp.Encender();
        luz.Encender();

        // Mostrar estado
        casa.MostrarDispositivos();

        // Ejecutar funciones específicas
        casa.EjecutarFunciones();

        // Apagar dispositivos
        sensorTemp.Apagar();
        luz.Apagar();

        casa.MostrarDispositivos();
    }
}
