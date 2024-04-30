using amoliaz.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// implementacion que implementa a MenuInterfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
        
            try
            {
                Console.WriteLine("0. Cerrar");
                Console.WriteLine("1. Registro de llegada");
                Console.WriteLine("2. Listado de consulta");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                return eleccion;
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
                throw;
            }
            
        }

        public int menusecundario()
        {
            try
            {
                Console.WriteLine("0. Volver ");
                Console.WriteLine("1. Mostrar consultas");
                Console.WriteLine("2. Imprimir  consultas");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                return eleccion;
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
                throw;
            }
            
        }

        public void menuConsulta()
        {
            try
            {
                Console.WriteLine("0. Psicología");
                Console.WriteLine("1. Traumatologia");
                Console.WriteLine("2. Fisioterapia; ");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == 0)
                {
                    Program.opcion = "Psicología";
                }
                else if (eleccion == 1)
                {
                    Program.opcion = "Traumatologia";
                }
                else if (eleccion == 2)
                {
                    Program.opcion = "Fisioterapia";
                }
                else
                {
                    Program.opcion = "";
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
    }
}
