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

    /* Fatorial */
    public int Factorial(int n)
    {
        if (n <= 1) return n;

        return n * this.Factorial(n - 1);
    }

    /* Palindromo */
    public bool Palindromo(string txt)
    {
        return txt == new string(txt.Reverse().ToArray());
    }

    /* Encontre os indices no array */
    public int[] FindIndex(int[] arr, int num)
    {
        return arr.Select((n, i) =>
        {
            if (num == n)
                return i;
            else
                return -1;
        }).Where(f => f != -1).ToArray();
    }

    /* Encontre o maior */

    /* Encontre o menor */

    /* Encontre o n elemento fibonacci */
    public int Fibonacci(int idx)
    {
        if (idx <= 1) return idx;

        return this.Fibonacci(idx - 2) + this.Fibonacci(idx - 1);
    }

    /* Gera P.A. */
    public int[] PA(int prog, int size)
    {

        var res = new int[size];
        res[0] = 1;

        for (int i = 1; i < size; i++)
            res[i] = res[i - 1] + prog;

        return res;
    }

    /* Valida P.A. */
    public bool IsPA(int[] arr)
    {
        if (arr.Length <= 1)
            return false;

        var factor = arr[1] - arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] == factor)
                continue;
            else
                return false;
        }
        return true;
    }

    /* Valida P.G. */
    public bool IsPG(int[] arr)
    {
        if (arr.Length <= 1)
            return false;

        var factor = arr[arr.Length - 1] / arr[arr.Length - 2];

        for (int i = arr.Length - 1; i > 1; i--)
        {
            if (arr[i] / arr[i - 1] == factor)
                continue;
            else
                return false;
        }
        return true;
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