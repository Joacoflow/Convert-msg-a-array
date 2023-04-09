using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__ESCRIBA_UN_MENSAJE_Y_LO_DEVUELVO_COMO_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string mensaje;
            Console.Write("Ingrese un mensaje: ");
            mensaje=Console.ReadLine();

            char[] caracter = mensaje.ToCharArray();

            string texto = "c[" + caracter.Length + "] = ";

            for (int i = 0; i < caracter.Length; i++)

            {
                texto += "[" + caracter[i] + "] ";

            }

            Console.WriteLine(texto);
            Console.ReadKey();


        }
    }
}
