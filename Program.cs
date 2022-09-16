namespace ProyectoIntegradorCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos();
            while (nombre == "" || apellido == "" || edad == "" || email == "")
            {
                Console.WriteLine("Usted ha dejado un campo vacío.");
                Datos();
                Confirmacion();
                Carrera();
                CheckGlobal();
                ConstanciaInscripcion();
            }
            Confirmacion();
            while (conf != "s")
            {
                Datos();
                Confirmacion();
                Carrera();
                CheckGlobal();
                ConstanciaInscripcion();
            }
            Carrera();
            while (carrera != 1 && carrera != 2 && carrera != 3)
            {
                Console.WriteLine("Código erroneo. Vuelva a insertar el código de la carrera.");
                Carrera();
                CheckGlobal();
                ConstanciaInscripcion();
            }
            CheckGlobal();
            while (conf != "s")
            {
                Carrera();
                CheckGlobal();
                ConstanciaInscripcion();
            }
            ConstanciaInscripcion();
        }

        public static string nombre, apellido, edad, email, conf, conf2, c1;
        public static byte carrera;

        

        public static void Datos()
        {


            Console.WriteLine("Por favor introduzca su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor introduzca su apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Por favor introduzca su edad");
            edad = Console.ReadLine();

            Console.WriteLine("Por favor introduzca su email");
            email = Console.ReadLine();


        }

        public static void Confirmacion()
        {
            Console.WriteLine("<<<Datos del alumno>>>");

            Console.WriteLine("Nombre: " + nombre);

            Console.WriteLine("Apellido: " + apellido);

            Console.WriteLine("Edad: " + edad);

            Console.WriteLine("Email: " + email);

            Console.WriteLine("Si sus datos son correctos presione 'S' para continuar, de lo contrario presione 'N' para cargarlos nuevamente.");

            conf = Console.ReadLine();

            conf.ToLower();
        }

        public static void Carrera()
        {
            Console.WriteLine("Seleciona el código de la carrera elegida:");

            Console.WriteLine("1- Programación .NET");

            Console.WriteLine("2- Programación JAVA");

            Console.WriteLine("3- Programación PHP");

            carrera = byte.Parse(Console.ReadLine());

            if (carrera == 1)
            {
                c1 = ".NET";
                Console.WriteLine("Usted ha seleccionado .NET");
            }
            else if (carrera == 2)
            {
                c1 = "JAVA";
                Console.WriteLine("Usted ha seleccionado JAVA");
            }
            else if (carrera == 3)
            {
                c1 = "PHP";
                Console.WriteLine("Usted ha seleccionado PHP");
            }

        }

        public static void CheckGlobal()
        {
            Console.WriteLine("Si sus datos son correctos presione 'S' para continuar, de lo contrario presione 'N' para cargarlos nuevamente.");

            conf2 = Console.ReadLine();

            conf2.ToLower();
        }

        public static  void ConstanciaInscripcion()
        {
            Console.WriteLine("<<<Constancia de inscripción>>>");

            Console.WriteLine("Alumno: " + nombre + " " + apellido);

            Console.WriteLine("Correo electrónico: " + email);

            Console.WriteLine("Carrera: " + c1);
        }
    }
}