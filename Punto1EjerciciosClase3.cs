using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1EjerciciosClase3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Vehiculo
    {
        public string Marca;
        public string Modelo;
        public string Color;

        public void encenderVehiculo()
        {
            Console.WriteLine("Enciendo el vehiculo...");
        }

        public void apagarVehiculo()
        {
            Console.WriteLine("Apago el vehiculo...");
        }
    }

    public class Autobus : Vehiculo
    {
        public string empresa;
        public int linea;
        public int capacidadPasajeros;
        public int nroPuertas;
        public int nroAsientos;

        public void cargaPasajeros()
        {
            Console.WriteLine("Cargando pasajeros...");
        }

        public void descargaPasajeros()
        {
            Console.WriteLine("Descargando pasajeros...");
        }
    }


}
