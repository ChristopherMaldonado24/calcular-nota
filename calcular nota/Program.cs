public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bienvenidos al progarama calculador de notas");

        Console.WriteLine("ingrese la nota del primer parcial");
        int N1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese la nota del segundo parcial");
        int N2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese la nota del tercer parcial");
        int N3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese la nota del cuarto parcial");
        int N4 = Convert.ToInt32(Console.ReadLine());

        double Total = N1 + N2 + N3 + N4;

        double Final = Total / 4;

        Console.WriteLine(" su promerdio es de: " + Final);
        Console.WriteLine(" Observación ");
        if (Final < 70)
        {
            Console.WriteLine(" Usted esta Reprobado ");
        }

        if (Final > 70 & Final < 81 )
        {
            Console.WriteLine(" Bueno ");
        }

        if (Final > 81 & Final < 91 )
        {
            Console.WriteLine(" Muy Bueno ");
        }
        
        if (Final > 91)
        {
            Console.WriteLine(" Excelente ");
        }
    }
}