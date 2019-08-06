using System;

namespace Proyecto_Senova
{
    class Program
    {
        static void Main(string[] args)
        {

            int Edad;
            int puntaje = 0;
            Proyecto miproyecto = new Proyecto();
            Proyecto miproyecto2 = new Proyecto();
            Proyecto miproyecto3 = new Proyecto();
            Proyecto miproyecto4 = new Proyecto("realidad aumentada",1549,"sistemas",12);
            Proyecto miproyecto5 = new Proyecto("Talento humano",65);
            //miproyecto3.IngresaDatos();
            //miproyecto3.imprimir();
            //miproyecto4.imprimir();
            miproyecto5.imprimir();


            //miproyecto.Area = "Sistemas";
            //miproyecto.Codigo = 1804643;
            //miproyecto.Duracion = 13;
            //miproyecto.Nombre = "Desarrollo de internet de las cosas IOT";
            //Console.WriteLine($"El area se llama:{miproyecto.Area}");
            //Console.WriteLine($"El codigo es: {miproyecto.Codigo}");
            //Console.WriteLine($"la duracion es de: {miproyecto.Duracion}horas");
            //Console.WriteLine($"Su nombre es:{miproyecto.Nombre}");


            Console.ReadLine();
            Console.ReadKey();






        }
    }
}
