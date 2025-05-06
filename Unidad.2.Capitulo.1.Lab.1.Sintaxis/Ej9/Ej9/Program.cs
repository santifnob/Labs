namespace Ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un numero de filas: ");

            int filas = int.Parse(Console.ReadLine());
            int columnas = (filas * 2) - 1;
            int puntoMedio = columnas /2;

            int desplazamiento = 0;

            for (int i = 0; i < filas; i++)
            {
                string cadena = string.Empty;
                
                for (int j = 0; j < columnas; j++)
                {
                    if (j >= (puntoMedio - desplazamiento) && j<= (puntoMedio + desplazamiento)) cadena = cadena + "*";
                    else cadena = cadena + " ";
                }

                Console.WriteLine(cadena);

                desplazamiento++;
            }
        }
    }
}