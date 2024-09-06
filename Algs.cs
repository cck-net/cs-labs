public class Algs
{
    /* Alunos e salas */
    public IEnumerable<string> StudentClasses(List<string> names, List<string> rooms)
    {
        foreach (var r in rooms)
        {
            var tempNames = names.FindAll(n => n[0].Equals(r[5]));

            if (tempNames.Count > 0)
            {
                yield return string.Concat(r, ": ", string.Join(", ", tempNames));
            }
        }
    }

    /* Carros */
    public int HoursToIntersect(int s0, int v0, int s1, int v1)
    {
        return (s0 - s1) / (v1 - v0);
    }

    public int KilometersToIntersect(int s0, int v0, int s1, int v1)
    {
        return (s0 + v0) * this.HoursToIntersect(s0, v0, s1, v1);
    }

    public int Factorial(int n)
    {
        if (n <= 1) return n;

        return n * this.Factorial(n - 1);
    }

    /*=================================================================*/

    /* Lucky Number */
    public int LuckyNumber(int[] nums)
    {
        return nums
            .GroupBy(n => n)
            .ToDictionary(g => g.Key, g => g.Count())
            .Where(d => d.Key.Equals(d.Value))
            .Last().Key;
    }
}