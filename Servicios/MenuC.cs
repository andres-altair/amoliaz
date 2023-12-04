using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// implemtacion que implementa a la interfaz MenuI
    /// <author>amd 041223</author>
    /// </summary>
    internal class MenuC : MenuI
    {
        public int mostrarMenu()
        {
            Console.WriteLine("0. cerrar menu");
            Console.WriteLine("1. añadir elemento");
            Console.WriteLine("2. eliminar elemento");
            int eleecion = Convert.ToInt32(Console.ReadLine());
            return eleecion;
            
        }
    }
}
