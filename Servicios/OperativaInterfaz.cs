using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// interfaz encargada de las opraciones
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// metodo que comprueba si tiene cita
        /// </summary>
        public  void registro();
        /// <summary>
        /// metodo que muestra las consultas 
        /// </summary>
        public void mostrarConsultas();
        /// <summary>
        /// metodo que escribe en fichero las consultas de hoy realizada
        /// </summary>
        public void imprimirConsulta();
    }
}
