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
        string codigoElemento = "idElemento + cantidadElemento";
        string nombreElemememto = "aaaa";
        string descripcionElemento = "aaaa";
        int cantidadElemento = 0;

        public elemetoDto(long idElemento, string codigoElemento, string nombreElemememto, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemememto = nombreElemememto;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemememto { get => nombreElemememto; set => nombreElemememto = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        public elemetoDto() { }
        override
        public string ToString()
        {
            string elemento = "nombre del lemento:  " + this.nombreElemememto
               + "  cantidad del elemento:   " + this.cantidadElemento;
            return elemento;    
        }  
        
    }   

}
