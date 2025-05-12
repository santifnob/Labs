namespace MisClasesEJ5
{
    public class Juego
    {
        private int record = 0;

        public int Record
        {
            get => record;
            set
            {
            }
        }

        public static void ComenzarJuego()
        {
            Console.WriteLine("1 - Empezar una partida");
            Console.WriteLine("2 - Controlar record intentos");

        }

        public void CompararRecord(int intentos)
        {
            if (intentos == record)
            {
                Console.WriteLine("Nuevo record!");
                record = intentos;
            }
            
        }

        public bool Continuar()
        {
            bool resultado = false;

            Console.WriteLine("Desea continuar intentado? [S/N]");
            string opc = Console.ReadLine();
            
            if (opc.ToUpper() == "S")
            {
                resultado = true;
            }

            return resultado;   
        }
        

        public int PreguntarMaximo()
        {
            Console.WriteLine("Ingresar el numero maximo: ");
            int opc = int.Parse(Console.ReadLine());
            while (opc <= 0) {
                Console.WriteLine("El numero debe ser mayor a 0");
                    }
            return opc;

        }

        public int PreguntarNumero()
        {
            Console.WriteLine("Ingresar un numero: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}
