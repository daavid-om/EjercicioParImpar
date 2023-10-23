using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParImpar.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del programa
    /// </summary>
    internal class ProgramaImplementacion : ProgramaInterfaz
    {
        public void parImpar()
        {
            int numero = pedirNum();

            if (numero % 2 != 0)
            {
                Console.WriteLine("Es impar");
            }
            else{
                Console.WriteLine("Es par");
            }

        }
        /// <summary>
        /// Método que pide al usuario un número
        /// </summary>
        /// <returns></returns>
        private int pedirNum() 
        {
            int numero;

            Console.WriteLine("Escriba un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }

}
