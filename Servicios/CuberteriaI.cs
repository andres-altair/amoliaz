using amoliaz.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace amoliaz.Servicios
{
    /// <summary>
    /// interfaz que se encarga de las modificaciones y creacion de elementos
    /// <author>amd 041223
    /// </summary>
    internal interface CuberteriaI
    {
        /// <summary>
        /// metodo que se encarga de añadir elemtos 
        ///  <author>amd 041223</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void añadirElemeto(List<elemetoDto> listaAntigua);

        /// <summary>
        /// metodo que elimina elemetos
        /// <author>amd 041223</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void eliminarElemento(List<elemetoDto> listaAntigua);

    }
}
