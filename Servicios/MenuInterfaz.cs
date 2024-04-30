using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// interfaz que se encarga de los menus
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que se encarga de la eleccion del menu principal
        /// </summary>
        /// <returns> eleccion del usuario</returns>
        public int menuPrincipal();
        /// <summary>
        /// metodo que se encarga de la eleccion del menu secundario
        /// </summary>
        /// <returns>eleccion del usuario</returns>
        public int menusecundario();
        /// <summary>
        /// metodo que se encarga de la eleccion del menu consulta
        /// </summary>
        /// <returns>eleccion del usuario</returns>
        public void menuConsulta();
    }
}
