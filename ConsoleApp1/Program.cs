namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;

                string path = @"C:\Users\HP 800 G2\Desktop\Busqueda.txt";

                archivo = new StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error con la lectura del archivo!");
            }
            finally
            {
                if(archivo != null)
                    archivo.Close();
                Console.WriteLine("La conexion con el archivo ha sido cerrada!");
            }
        }
    }
}