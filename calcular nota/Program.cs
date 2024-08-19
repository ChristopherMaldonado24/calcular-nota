public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" bienvenidos al progarama calculador de notas ");

        Console.WriteLine(" Ingrese su nombre ");
        string Nombre = Console.ReadLine();

        Console.WriteLine(" Ingrese el nombre de la materia ");
        string Asignatura = Console.ReadLine();

        Console.WriteLine(" ingrese la nota del primer parcial ");
        int N1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ingrese la nota del segundo parcial ");
        int N2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ingrese la nota del tercer parcial ");
        int N3 = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine(" ingrese la nota del cuarto parcial ");
        int N4 = Convert.ToInt32(Console.ReadLine());

        double Total = (N1 + N2 + N3 + N4)/4;

        Console.WriteLine(" su promerdio es de: " + Total);
        Console.WriteLine(" Observación ");
        if (Total < 70)
        {
            Console.WriteLine(" Usted esta Reprobado ");
            Console.ReadKey();
        }

        if (Total > 70 & Total < 81 )
        {
            Console.WriteLine(" Bueno ");
            Console.ReadKey();
        }

        if (Total > 81 & Total < 91 )
        {
            Console.WriteLine(" Muy Bueno ");
            Console.ReadKey();
        }
        
        if (Total > 91)
        {
            Console.WriteLine(" Excelente ");
            Console.ReadKey();
        }
    }
}