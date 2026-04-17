using System;
    public abstract class VehiculoBase
    {
        private string _matricula;
        private double _kilometraje;

        
        public string Matricula
        {
            get { return _matricula; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("La matrícula no puede estar vacía.");
                _matricula = value; 
            }
        }

        public double Kilometraje
        {
            get { return _kilometraje; }
            set 
            { 
                // Validación: El kilometraje no puede bajar (responsabilidad de la entidad)
                if (value < _kilometraje)
                    Console.WriteLine("Error: El kilometraje ingresado es menor al actual.");
                else
                    _kilometraje = value;
            }
        }

        public decimal TarifaDiaria { get; set; }

        // Método abstracto: cada tipo de vehículo calcula su costo distinto
        public abstract decimal CalcularCosto(int dias);
    }

    // Clase Principal: Auto
    public class Auto : VehiculoBase
    {
        public override decimal CalcularCosto(int dias)
        {
            return TarifaDiaria * dias;
        }
    }

    class Program
    {
        static void Main()
        {
            Auto miAuto = new Auto();
            
           
            miAuto.Matricula = "ABC-123"; 
            miAuto.TarifaDiaria = 50.0m;
            miAuto.Kilometraje = 1000;

            
            miAuto.Kilometraje = 800; 

            Console.WriteLine($"Vehículo: {miAuto.Matricula}");
            Console.WriteLine($"Costo por 5 días: ${miAuto.CalcularCosto(5)}");
        }
    }