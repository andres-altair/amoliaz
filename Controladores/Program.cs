using amoliaz.Dtos;
using amoliaz.Servicios;

namespace amoliaz.Controladores
{
    /// <summary>
    /// clase principal
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo principal
        /// </summary>
        /// <param name="args"></param>
       
        
        public static string rutaS = string.Concat("citasConAsistencia-", hoy.ToString("ddMMyyyy"), ".txt");
        public static string ruta = string.Concat("C:\\Users\\profesor\\Desktop\\" , rutaS);
       // public static string ruta = string.Concat("C:\\Users\\profesor\\Desktop\\", rutaS);

        public static string rutaSlog = string.Concat("log-", hoy.ToString("ddMMyyyy"), ".txt");
        public static string rutaLog = string.Concat("C:\\Users\\profesor\\Desktop\\" ,rutaS);
        
        
        public static string opcion;
        public static List<CitasDto> listaCita = new List<CitasDto>();
        public static DateTime hoy = DateTime.Now;
        public static void Main(string[] args)
        {
            LecturaFicheroInterfaz li = new LecturaFicheroImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            li.lecturaFichero();

            
            bool abrir = false;
            int eleccion1;
            int eleccion2;
            /*try
            {

            }catch(Exception ex)
            {
                Console.WriteLine("ha habido un error en la aplicacion, intentelo mas tarde");
                StreamWriter sw = new StreamWriter(Program.rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
            }*/
            do
            {
                eleccion1 = mi.menuPrincipal();
                switch (eleccion1)
                {
                    case 0:
                        abrir = true
                            ; break;
                    case 1:
                        oi.registro();
                        break
;
                    case 2:
                        eleccion2 = mi.menusecundario();
                        switch (eleccion2)
                        {
                            case 0:
                                break;
                            case 1:
                                mi.menuConsulta();
                                oi.mostrarConsultas();
                                break;
                            case 2:
                                oi.imprimirConsulta();
                                break;


                            default:
                                Console.WriteLine("eleccion no reconocida");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("eleccion no reconocida");
                        break;
                }

            }
            while (!abrir);
            
        }
    }
}