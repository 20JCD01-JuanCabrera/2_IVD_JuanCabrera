internal class Program
{
    //Verificar si un numero es positivo es positivos o negativo
    private static void Main(string[] args)
    {
        //Entrada
        Console.WriteLine("===Números Positivos o Negativos===");
        int num;
        Console.Write("Dame un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        //Proceso
        //Salidas
        if (num >= 0)
        {
            Console.WriteLine("Es un número positivo");
        }
        else
        {
            Console.WriteLine("Es un número negativo");
        }   
        
    }
}