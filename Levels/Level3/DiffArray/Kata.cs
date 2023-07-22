using System.Linq;

namespace Levels.Level3.DiffArray
{
    public class Kata<T>
    {
        public static T[] ArrayDiff(T[] a, T[] b)
        {
            return a.Where(item => !b.Contains(item)).ToArray();
        }
    }
}