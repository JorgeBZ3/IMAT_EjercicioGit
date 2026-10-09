namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID = 202305420;
            string idTexto = ID.ToString();

            int primero = int.Parse(idTexto[0].ToString());
            int ultimo = int.Parse(idTexto[idTexto.Length - 1].ToString());

            Console.WriteLine("La multiplicación del primer y último dígito del ID " + ID + " es: "+ Multiply(primero, ultimo));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}