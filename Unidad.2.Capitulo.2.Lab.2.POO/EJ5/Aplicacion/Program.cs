using MisClasesEJ5;

namespace Aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            


            Juego.ComenzarJuego();
            System.Console.WriteLine("Ingresar opc (0 para salir): ");
            string opc = Console.ReadLine();
            while (opc != "1" && opc != "2" && opc != "0") {
                System.Console.WriteLine("Ingresar opc (0 para salir): ");
                opc = Console.ReadLine();
            }

            while (opc == "1" || opc == "2")
            {
                if (opc == "1")
                {
                    Jugada jugada = new Jugada(juego.PreguntarMaximo());
                    do
                    {
                        int unNum = juego.PreguntarNumero();
                        jugada.Comparar(unNum);

                        if (jugada.Adivino)
                        {
                            juego.CompararRecord(jugada.Intentos);
                            break;
                        }

                    } while (juego.Continuar());
                }

                if (opc == "2")
                {
                    Console.WriteLine(juego.Record);
                }

                System.Console.WriteLine("Ingresar opc (0 para salir): ");
                opc = Console.ReadLine();
                while (opc != "1" && opc != "2" && opc != "0")
                {
                    System.Console.WriteLine("Ingresar opc (0 para salir): ");
                    opc = Console.ReadLine();
                }
            }
        }
    }
}
