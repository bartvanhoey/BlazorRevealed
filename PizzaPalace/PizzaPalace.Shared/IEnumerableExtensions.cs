using System.Collections;

namespace PizzaPalace.Shared
{
    public static class IenumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable) => enumerable.GetEnumerator().MoveNext();
    }
}