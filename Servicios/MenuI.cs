using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// interfaz encargadav de mostrar un  mebu y recoger la elecciion elegida
    /// <author>amd 041223</uthor>
    /// </summary>
    internal interface MenuI
    {
        /// <summary>
        /// metodo que se encarga de mostrar un menu y recoge la eleccion
        /// <author>amd 041123</author>
        /// </summary>
        /// <returns>eleccion del usuario</returns>
        public int mostrarMenu();
    }
}
