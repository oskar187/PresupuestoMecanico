namespace Multiplataforma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new OSWindows() -- Imprimir MAC
            //new OSMacintosh() -- Imprimir MAC
            Aplication app = new Aplication(new OSWindows());
            app.CrearIU();
            app.Paint();
        }
    }
}