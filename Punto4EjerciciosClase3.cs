using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3EjerciciosClase3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Libro
    {
        public string titulo;
        public string autor;
        public int anioPublicacion;
        public string genero;
        public string tipoTapa;
        public bool tieneGraficas;
        public bool estaEnvuelto;
        public void abrirLibro()
        {
            if (this.estaEnvuelto)
            {
                Console.WriteLine("El libro esta envuelto, no se puede abrir ahora");
            }
            else
            {
                Console.WriteLine($"Ya que no tiene envoltorio, abro el libro {this.titulo} sin problemas");
            }
        }

        public void cerrarLibro()
        {
            Console.WriteLine($"Este libro del autor {this.autor} es de tapa {this.tipoTapa}, mejor lo cierro para leerlo después.");
        }

        public void leerLibro()
        {
            if(this.tieneGraficas)
            {
                Console.WriteLine($"Este libro tiene muchas graficas interesantes, voy a leerlo.");
            }
        }
    }
    

}
