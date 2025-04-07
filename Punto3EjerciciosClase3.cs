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

    public class Animal
    {
        public string especie;
        public int edadAdulta;
        public string genero;
        public string color;
        public string tipoAlimentacion;
        public string sonidoCaracteristico;
        public bool estaExtinto;


        public void alimentarse()
        {
            Console.WriteLine($"El {this.especie} se esta alimentando a base de {this.tipoAlimentacion}");
        }

        public void reproducirse()
        {
            Console.WriteLine($"El {this.especie} se reproduce a los {this.edadAdulta} años de edad, que es cuando alcanza la edad adulta.");
        }

        public void hacerSonidoCaracteristico()
        {
            Console.WriteLine($"El {this.especie} se comunica haciendo su sonido caracteristico: {this.sonidoCaracteristico}");
        }
    }


    public class Gato : Animal
    {
        public string raza;
        public string nombre;
        public bool estaCastrado;
        public bool tieneDuenio;

        public void rascarse()
        {
            Console.WriteLine($"El gato de nombre {this.nombre} se esta rascando las uñas con el sillon!");
        }
    }

    public class Gallina : Animal
    {
        public int cantidadHuevosPorDia;
        public string tipoCorral;

        public void ponerHuevos()
        {
            Console.WriteLine($"La gallina de color {this.color} está poniendo huevos. Por lo general suelen poner {this.cantidadHuevosPorDia} huevos por día");
        }
    }

    

}
