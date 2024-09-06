namespace cs_labs;

class Program
{
    static void Main(string[] args)
    {
        var algs = new Algs();

        // /* Alunos e salas */
        var students = new List<string>() { "Paula", "Bianca", "Priscila", "Renata", "Maria" };
        var classes = new List<string>() { "Sala A", "Sala B", "Sala C", "Sala D", "Sala E", "Sala F", "Sala G", "Sala H", "Sala I", "Sala J", "Sala L", "Sala M", "Sala N", "Sala O", "Sala P", "Sala Q", "Sala R", "Sala S", "Sala T", "Sala U", "Sala V", "Sala X", "Sala Z" };

        var studentClasses = algs.StudentClasses(students, classes).ToList();

        if (studentClasses.Count == 4 &&
            studentClasses[0] == "Sala B: Bianca" &&
            studentClasses[1] == "Sala M: Maria" &&
            studentClasses[2] == "Sala P: Paula, Priscila" &&
            studentClasses[3] == "Sala R: Renata"
        )
            Console.WriteLine("Success");
        else
            Console.WriteLine("Fail");

        // /* Carros */
        var hrs = algs.HoursToIntersect(0, 100, 100, 50);
        if (hrs == 2)
            Console.WriteLine("Success");
        else
            Console.WriteLine("Fail");

        var kms = algs.KilometersToIntersect(0, 100, 100, 50);
        if (kms == 200)
            Console.WriteLine("Success");
        else
            Console.WriteLine("Fail");

        /* Fatorial */
        var fac = algs.Factorial(5);
        if (fac == 120)
            Console.WriteLine("Success");
        else
            Console.WriteLine("Fail " + fac.ToString());

        /*=================================================================*/

        /* Lucky Number */
        var lucky = algs.LuckyNumber([1, 2, 2, 3, 3, 3, 3, 4, 5, 5, 5, 5, 5, 6]);
        if (lucky == 5)
            Console.WriteLine("Success");
        else
            Console.WriteLine("Fail " + lucky.ToString());
    }
}
