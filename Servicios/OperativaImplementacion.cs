using amoliaz.Controladores;
using amoliaz.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// implementacion que implementa a RegistroInterfaz
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        /// <summary>
        /// metodo que se encarga de pedir y verifucar el dni
        /// </summary>
        /// <returns> dni del usuario</returns>
        private string pedirDni()
        {
            bool seguir = false;
            string dniPedido;
            do
            {
                char[] letras = ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J',
                    'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'];

                Console.WriteLine("escribe tu dni");
                dniPedido = Console.ReadLine();
                char[] separado = dniPedido.ToCharArray();
                char letra = separado[8];
                string dniNimero = string.Concat(separado[0], separado[1], separado[2],
                    separado[3], separado[4], separado[5], separado[6], separado[7]);
                int numero = Convert.ToInt32(dniNimero);
                if (letras[numero % 23] == letra)
                {
                    seguir = true;
                }
            } while (!seguir);
            return dniPedido;
        }

        public void registro()
        {
            try
            {
                string dni = pedirDni();
                CitasDto c = new CitasDto();
                DateTime hoy = DateTime.Now;
                string hoyString = hoy.ToString("dd-MM-yyyy");
                string FechaLista = c.FechaCita.ToString("dd-MM-yyyy");
                if (c.Dni.Equals(dni) && hoy.Equals(FechaLista))
                {
                    Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. " +
                        "Su especialista le avisará.");
                    c.Asistencia = true;
                }
                else
                {
                    Console.WriteLine("No dispone de cita previa para hoy.");
                    c.Asistencia= false;
                }
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
                throw;
            } 
        }

        public void mostrarConsultas()
        {
            try
            {
                Console.WriteLine("escribe la fecha (dd-MM-yyyy)");
                DateTime fechaConsultar = Convert.ToDateTime(Console.ReadLine());
                CitasDto c = new CitasDto();
                if (c.FechaCita == fechaConsultar && c.Especialidad.Equals(Program.opcion))
                {
                    string mostrar = string.Concat("Nombre completo: ", c.Nombre, " ", c.Apellidos, ", ",
                    "Hora ", c.FechaCita.ToString("HH:mm"));
                    Console.WriteLine(mostrar);
                }
                else
                {
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                }
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
                throw;
            }
            
            
        }

        public void imprimirConsulta()
        {
            try
            {
                Console.WriteLine("escribe la fecha (dd-MM-yyyy)");
                DateTime fechaImprimir = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("escribe la especialidad (Psicología; Fisioterapia; Traumatologia");
                string especialidad = Console.ReadLine();

                StreamWriter sw = new StreamWriter(Program.ruta);
                foreach (CitasDto c in Program.listaCita)
                {
                    if(c.FechaCita==fechaImprimir && c.Asistencia == true && c.Especialidad==especialidad)
                    {
                        string linea = string.Concat(c.Dni, ";", c.Nombre, ";", c.Apellidos, ";", c.Especialidad,
                        ";", c.FechaCita, ";", c.Asistencia);
                        sw.WriteLine(linea);
                    }
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
                Console.WriteLine("error al conectarse con ficheros");
            }
            
        }
    }
}
