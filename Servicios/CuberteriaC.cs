using amoliaz.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// implemtacion que implementa a la interfaz CuberteriaI
    /// <author>amd 041223</author>
    /// </summary>
    internal class CuberteriaC : CuberteriaI
    {
        public void añadirElemeto(List<elemetoDto> listaAntigua)
        {
            elemetoDto elemto = crearElemento();
            listaAntigua.Add(elemto);
            Console.WriteLine(elemto.ToString());
        }

        /// <summary>
        /// metodo que crear un nuevo elemento
        ///  <author>amd 041223</author>
        /// </summary>
        /// <returns>devuel un objeto elementoDto</returns>
        private elemetoDto crearElemento() 
        { 
            elemetoDto crear = new elemetoDto();
            Console.WriteLine("Escribe el id"); 
            crear.IdElemento=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Escribe el nombre");
            crear.NombreElemememto = Console.ReadLine();
            Console.WriteLine("Escribe la descripcion");
            crear.DescripcionElemento = Console.ReadLine();
            Console.WriteLine("Escribe la cantidad");
            crear.CantidadElemento= Convert.ToInt32(Console.ReadLine());  
            return crear;   
        }

        /// <summary>
        /// metodo que pide el id y lo devuelve
        /// <author>amd 041223</author>
        /// </summary>
        /// <returns>id del elemto</returns>
        private int pedirId()
        {
            Console.WriteLine("¿cual es el id?");
            int Id = Convert.ToInt32(Console.ReadLine());
            return Id;  
        }

        /// <summary>
        /// metodo que pide la cantidad a eleiminar
       /// <author>amd 041223</author>
        /// </summary>
        /// <returns>numero a eliminar</returns>
        private int Eliminar()
        {
            Console.WriteLine("¿cuantos quieres eliminar?");
            int eliminar = Convert.ToInt32(Console.ReadLine()); 
            return eliminar;    
        }

        public void eliminarElemento(List<elemetoDto> listaAntigua)
        {
            int eliminar; 
            int Id = pedirId();
            foreach(elemetoDto elemeto in listaAntigua)
            {
                if (elemeto.IdElemento.Equals(Id))
                {
                    eliminar = Eliminar();
                    elemeto.CantidadElemento = elemeto.CantidadElemento - eliminar;
                    Console.WriteLine(elemeto.ToString());
                }
                else { Console.WriteLine("no existe el id"); }
            }

        }
    }
}
