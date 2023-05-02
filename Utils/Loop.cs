namespace Utils;

public class Loop {
    public static void iForEach<T>(this IEnumerable<T> enumerable, Action<T, int?> action)
    {
        int index = 0;
        foreach (T item in enumerable)
        {
            action(item, index++);
        }
    }
}
