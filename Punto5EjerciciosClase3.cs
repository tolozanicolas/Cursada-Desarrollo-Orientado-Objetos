using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5EjerciciosClase3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Biblioteca
    {
        public string nombre;
        public string ubicacion;
        public string horarioApertura;
        public string horarioCierre;
        public string nombreBibliotecario;
        public bool tieneWifi;
        public bool aceptaMercadoPago;

        public void agregarLibroAInventario()
        {
            Console.WriteLine($"Se ingresa nuevo ejemplar al inventario de la biblioteca {this.nombre}");
        }

        public void prestarLibro()
        {
            if(this.aceptaMercadoPago)
            {
                Console.WriteLine($"Se procede a prestar el libro {this.nombre} con el seguro pago via mercadopago");
            }
        }

        public void devolverLibro()
        {
            Console.WriteLine($"Yendo entre los horarios {this.horarioApertura} y {this.horarioCierre}, se puede devolver el libro sin problemas");
        }

        public void buscarLibro()
        {
            Console.WriteLine("Se procede a buscar el libro indicado");
        }
    }
    

}
