namespace stringCadena_e_invertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una frase");
            string texto = Console.ReadLine();

            // Utilizando método InvertirManualmente
            string textoInvertidoManualmente = InvertirManualmente(texto);
            Console.WriteLine("Invertido manualmente: " + textoInvertidoManualmente);

            // Utilizando método invertir
            string textoInvertido = Invertir(texto);
            Console.WriteLine("Invertido utilizando Array.Reverse: " + textoInvertido);
        }

        private static string InvertirManualmente(string cadena)
        {
            string cadenaInvertida = "";
            foreach (char letra in cadena)
            {
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }

        private static string Invertir(string cadena)
        {
            char[] cadenaComoCaracteres = cadena.ToCharArray();
            Array.Reverse(cadenaComoCaracteres);
            return new string(cadenaComoCaracteres);
        }
    }
}
