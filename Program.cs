using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1
{
    class Program
    {
        static void Main(string[] args)
        {

            Mascota Malta = new Mascota();
            Malta.nombre = "Malta";
            Malta.tipoAnimal = "Gato";
            Malta.raza = "Sin raza";
            Malta.color = "atigrado";
            Malta.edad = 2;
            Malta.duenio = "Nicolas";

            Duenio Nicolas = new Duenio();
            Nicolas.nombre = "Nicolas";
            Nicolas.apellido = "Toloza";
            Nicolas.nombreMascota = "Malta";

            Nicolas.altaMascota();
            Malta.revisarMascota();
            Malta.indicarInternacionMascota();
            Nicolas.pagoTratamiento();
            Nicolas.bajaMascota();

            Console.ReadKey();

        }
    }

    public class Mascota
    {
        public string nombre;
        public string tipoAnimal;
        public string raza;
        public string color;
        public int edad;
        public string duenio;

        public void revisarMascota()
        {
            Console.WriteLine("Se procede a la revision de la mascota por parte de un veterinario...");
        }

        public void indicarTratamientoMascota()
        {
            Console.WriteLine("Se indica tratamiento a la mascota ingresada...");
        }

        public void indicarInternacionMascota()
        {
            Console.WriteLine("Se indica la internacion de la mascota por parte del veterinario...");
        }

    }

    public class Duenio
    {
        public string nombre;
        public string apellido;
        public string nombreMascota;

        public void altaMascota ()
        {
            Console.WriteLine("Ingresa mascota al sistema del centro veterinario...");
        
        }

        public void bajaMascota ()
        {
            Console.WriteLine("Realizando la baja de la mascota del sistema del centro veterinario...");
        }

        public void pagoTratamiento ()
        {
            Console.WriteLine("Realizando pago del tratamiento indicado...");
        }

        public void pagoInternacion()
        {
            Console.WriteLine("Realizando pago de la internacion...");
        }
     }


}
