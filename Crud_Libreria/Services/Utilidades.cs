using System.Security.Cryptography;
using System.Text;

namespace Crud_Libreria.Services
{
    public class Utilidades
    {
        public static string EncriptarClave(string clave)
        {
            // Inicializa un StringBuilder para construir la cadena hexadecimal del hash
            StringBuilder sb = new StringBuilder();

            // El bloque using asegura que la instancia de SHA256 se libere adecuadamente
            // Crea una instancia de SHA256 para calcular el hash
            using (SHA256 hash = SHA256.Create())
            {
                // Define la codificación UTF-8
                Encoding encode = Encoding.UTF8;

                // Convierte la clave a un arreglo de bytes usando UTF-8
                byte[] bytesDeClave = encode.GetBytes(clave);

                // Calcula el hash SHA-256 del arreglo de bytes
                byte[] resultado = hash.ComputeHash(bytesDeClave);

                // Convierte cada byte del hash a su representación hexadecimal
                foreach (byte b in resultado)
                {
                    sb.Append(b.ToString("x2"));
                }
            }

            // Devuelve la cadena hexadecimal resultante del hash
            return sb.ToString();
           
        }
    }
}
