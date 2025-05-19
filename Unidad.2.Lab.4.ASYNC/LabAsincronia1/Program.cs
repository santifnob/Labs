using System.Diagnostics;

namespace LabAsincronia1
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            CompararSincronoVsAsincrono();
        }

        public static void SimularOperacionPesada() {
            Thread.Sleep(3000);
        }

        public static async Task SimularOperacionPesadaAsyng(Stopwatch sw)
        {
            await Task.Delay(3000); Console.WriteLine("Termino el delay. Tiempo de ejecucion: " + sw.ElapsedMilliseconds + " ms"); 
            //Le agregue el output para darme cuenta que en el fondo se esta ejecutando y se muestre si el input lo hice despues del lapso del delay
        }

        public static void CompararSincronoVsAsincrono()
        {
            Console.WriteLine("Inicio");
            Stopwatch stopwatch = Stopwatch.StartNew();
            SimularOperacionPesada();
            Console.WriteLine("Fin Sincrono. Demora de: " + stopwatch.ElapsedMilliseconds + "ms");
            SimularOperacionPesadaAsyng(stopwatch);
            Console.WriteLine("Ingresar texto: "); Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("Fin Total. Demora de: " + stopwatch.ElapsedMilliseconds + "ms");
}


    }
}
