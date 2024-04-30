using amoliaz.Controladores;
using amoliaz.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Servicios
{
    /// <summary>
    /// implementacion que implementa a LecturaFicheroInterfaz
    /// </summary>
    internal class LecturaFicheroImplementacion : LecturaFicheroInterfaz
    {
        public void lecturaFichero()
        {
            try
            {
                if (File.Exists(Program.ruta))
                {
                    string[] lineas = File.ReadAllLines(Program.ruta);
                    foreach (string c in lineas)
                    {
                        string[] campo = c.Split(";");
                        if (campo[5] == null)
                        {
                            CitasDto citas = new CitasDto
                            {
                                Dni = campo[0],
                                Nombre = campo[1],
                                Apellidos = campo[2],
                                Especialidad = campo[3],
                                FechaCita = Convert.ToDateTime(campo[4]),
                                Asistencia = false
                            };
                            Program.listaCita.Add(citas);
                        }
                        else
                        {
                            CitasDto citas = new CitasDto
                            {
                                Dni = campo[0],
                                Nombre = campo[1],
                                Apellidos = campo[2],
                                Especialidad = campo[3],
                                FechaCita = Convert.ToDateTime(campo[4]),
                                Asistencia = Convert.ToBoolean(campo[5])
                            };
                            Program.listaCita.Add(citas);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {

                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
                Console.WriteLine("error al conectarse con ficheros");
            }
            
        }
    }
}
