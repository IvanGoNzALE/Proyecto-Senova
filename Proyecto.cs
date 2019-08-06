using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Senova
{
    class Proyecto
    {
        #region Atributos

        #endregion


        #region Propiedades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion

        #region Constructores
        public Proyecto (string nombre, double codigo, string area, int duracion  )
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {


        }
        public Proyecto (string area,int duracion)
        {

            Area = area;
            Duracion = duracion;
        }

        #endregion

        #region Metodos

        public void IngresaDatos()
        {
            Console.WriteLine("ingrese el nombre del proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("ingrese el codigo");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("ingerse el area");
            Area = Console.ReadLine();
            Console.WriteLine("ingrese la duracion");
            Duracion = int.Parse(Console.ReadLine());
        }
        public void imprimir()
        {
            Console.WriteLine($"El nombre es:{Nombre}");
            Console.WriteLine($"El codigo es:{Codigo}");
            Console.WriteLine($"El area es:{Area}");
            Console.WriteLine($"La duracion es de:{Duracion} horas");
        }
        #endregion
    }
}
