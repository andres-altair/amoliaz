using amoliaz;
using amoliaz.Dtos;
using amoliaz.Servicios;
namespace amoliaz 
{
    /// <summary>
    /// clase es tipo programa
    /// <author>amd 041223</author>
    /// </summary>

    class Pogram
    {
        /// <summary>
        /// clase pricipal
        /// <author>amd 041223</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<elemetoDto> cuberteria = new List<elemetoDto>();
            MenuI mi = new MenuC();
            CuberteriaI ci = new CuberteriaC();
            int eleccion;
            bool abrir = false;
            while (!abrir)
            {
                eleccion = mi.mostrarMenu();
                switch (eleccion)
                {
                    case 0:
                        Console.WriteLine("cerrado");
                        abrir = true;
                        break;
                    case 1:
                        Console.WriteLine("1. añadir elemento");
                        ci.añadirElemeto(cuberteria);
                        break;
                    case 2:
                        Console.WriteLine("2. eliminar elemento");
                        ci.eliminarElemento(cuberteria);
                        break;
                    default:
                        Console.WriteLine("eleccion no correcta");
                        break;

                }

            }
        }   
    }
        
}
