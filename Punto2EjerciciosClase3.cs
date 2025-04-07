using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2EjerciciosClase3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Vehiculo
    {
        public string modelo;
        public string marca;
        public int anio;
        public string color;
        public string numeroSerieMotor;
        public string numeroSerieChasis;


        public void arrancarVehiculo()
        {
            Console.WriteLine("Arranco el vehiculo...");
        }

        public void detenerVehiculo()
        {
            Console.WriteLine("Detengo el vehiculo...");
        }

        public void acelerarVehiculo()
        {
            Console.WriteLine("Acelero el vehiculo...");
        }

        public void frenarVehiculo()
        {
            Console.WriteLine("Freno el vehiculo...");
        }
    }


    public class Motocicleta : Vehiculo
    {
        public string tipoMoto;
        public int cantidadHP;
        public int cantidadTorque;

        public void hacerWillie()
        {
            Console.WriteLine("Hago una tremenda willy.-");
        }
    }

    public class Patrullero : Vehiculo
    {
        public int nroInterno;
        public string dependenciaAsignada;
        public int nroTicketCombustible;
        public bool tieneBlindaje;

        public void sonarSirena()
        {
            Console.WriteLine("Suena la sirena del móvil.-");
        }
    }

    public class CamionetaReparto : Vehiculo
    {
        public string empresa;
        public bool tieneSistemaRefrig;
        public int nroHabilitacion;
        public bool tieneRecorridoFijo;

        public void realizarRecorrido()
        {
            Console.WriteLine("Se realiza el recorrido diario.-");
        }
    }


}
