        public class Contenido
    {
        // Atributos básicos del contenido
        private string _titulo;
        private int _duracion;
        private string _genero;
        private string _tipo;

        // Constructor para inicializar los datos
        public Contenido(string titulo, int duracion, string genero, string tipo)
        {
            _titulo = titulo;
            _duracion = ValidarDuracion(duracion); 
            _genero = genero;
            _tipo = tipo;
        }

        // Método que evita valores inválidos en la duración
        private int ValidarDuracion(int valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Duración inválida, se ajusta a 1 minuto.");
                return 1;
            }
            return valor;
        }

        // Propiedad del título
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        // Propiedad de solo lectura para la duración
        public int Duracion
        {
            get { return _duracion; }
        }

        // Propiedad del género
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        // Tipo de contenido 
        public string Tipo
        {
            get { return _tipo; }
        }

        // Muestra la información del contenido
        public void MostrarDetalles()
        {
            Console.WriteLine("Contenido: " + _titulo);
            Console.WriteLine("Duración: " + _duracion + " min");
            Console.WriteLine("Género: " + _genero);
            Console.WriteLine("Tipo: " + _tipo);
        }

        // Simula la reproducción del contenido
        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo: " + _titulo);
        }

        // Simula la pausa del contenido
        public void Pausar()
        {
            Console.WriteLine("Pausado: " + _titulo);
        }
    }
    // Datos básicos del usuario
    public class Usuario
    {
        
        private string _nombre;
        private string _email;

        // Lista de contenidos guardados
        private List<Contenido> _lista;

        // Constructor del usuario
        public Usuario(string nombre, string email)
        {
            _nombre = nombre;
            _email = email;
            _lista = new List<Contenido>();
        }

        // Propiedad del nombre
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Propiedad del correo
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Agrega un contenido a la lista
        public void AgregarALista(Contenido contenido)
        {
            _lista.Add(contenido);
            Console.WriteLine(contenido.Titulo + " agregado a la lista.");
        }

        // Muestra los contenidos guardados
        public void VerLista()
        {
            Console.WriteLine("Lista de contenidos:");
            foreach (Contenido c in _lista)
            {
                Console.WriteLine("- " + c.Titulo);
            }
        }

        // Simula que el usuario está viendo contenido
        public void VerContenido(Contenido contenido)
        {
            Console.WriteLine(_nombre + " está viendo: " + contenido.Titulo);
            contenido.Reproducir();
        }
    }
