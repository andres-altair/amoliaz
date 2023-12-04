using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Dtos
{
    /// <summary>
    /// clase que representa el ente que  cuberteria
    /// <author>amd 041223</author>
    /// </summary>
    internal class elemetoDto
    {
        long idElemento = 0;
        string codigoElemento ;
        string nombreElemememto = "aaaa";
        string descripcionElemento = "aaaa";
        int  cantidadElemento = 0;
        

        public elemetoDto() { }

        public elemetoDto(string nombreElemememto, string descripcionElemento, int cantidadElemento, string codigoElemento)
        {
            this.nombreElemememto = nombreElemememto;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
            this.codigoElemento = codigoElemento;
        }

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string NombreElemememto { get => nombreElemememto; set => nombreElemememto = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }

        override
        public string ToString()
        {
            string elemento = "nombre del lemento:  " + this.nombreElemememto
               + "  cantidad del elemento:   " + this.cantidadElemento;
            return elemento;    
        }  
        
    }   

}
