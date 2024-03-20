namespace ejercicioFichero3
{

    class Program
    {

        static void Main(string[] args)
        {

            string fichero = "C:\\Users\\csi22-jzarcia\\Desktop\\textoACambiar.txt";


            try
            {
                Console.WriteLine("En que linea deseas escribir: ");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());


                string[] lineas = File.ReadAllLines(fichero);
                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {
                    Console.WriteLine("Que desea escribir: ");
                    string nuevoTexto = Console.ReadLine();

                    lineas[numeroLinea - 1] = nuevoTexto;

                    File.WriteAllLines(fichero, lineas);
                }
                else
                {
                    Console.WriteLine("La linea en la que desea escribir esta fuera de rango");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer o escribir en el archivo: " + e.Message);
            }

            

        }

    }

}