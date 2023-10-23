using EjercicioParImpar.Servicios;

namespace EjercicioParImpar
{
    /// <summary>
    /// Clase principal 
    /// 231023 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Creamos los objetos
            ProgramaInterfaz pi = new ProgramaImplementacion();

            pi.parImpar();

        }
    }
}