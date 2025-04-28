using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.nombre = "Pepe";
            persona1.MostrarInfo();

            Persona persona2 = new Persona("Stephy", 23, 96005042);
            persona2.MostrarInfo();
            Console.WriteLine(persona1.getEdad());
            Console.WriteLine(persona2.getEdad());
            persona1.setEdad(40);
            persona2.setEdad(32);
            Console.WriteLine(persona1.getEdad());
            Console.WriteLine(persona2.getEdad());
            Console.ReadKey();


            Calculadora calculadora1 = new Calculadora();
            calculadora1.marca = "Casio";
            calculadora1.modelo = "cientifica";
            calculadora1.esCientifica = true;

            Console.WriteLine(calculadora1.Suma("La suma de los numeros ingresados es: ", 9, 15));
            Console.WriteLine(calculadora1.esPar(151210));
            Console.ReadKey();

        }
    }
    //Ejercicio 1
    public class Persona
    {
        public string nombre;
        private int edad;
        public int dni;


        public Persona()
        {
            this.nombre = "Nicolas";
            this.edad = 31;
            this.dni = 37846967;
        }

        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + this.nombre + " Edad: " + this.edad + " DNI: " + this.dni);
        }          

    }

    //Ejercicio 2

    public class Calculadora
    {
        public string marca;
        public string modelo;
        public bool esCientifica;


        public int Suma(int a, int b)
        {
            return a + b;
        }

        public double Suma(double a, double b, double c)
        {
            return a + b + c;
        }

        public int Suma(String mensaje, int a, int b)
        {
            Console.WriteLine(mensaje);
            return a + b;
        }

        public bool esPar(int a)
        {
            if(a%2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
  
}
