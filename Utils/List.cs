namespace Utils;

public static class List {
    public static List<T> Slice<T>(this IEnumerable<T> source, int start = 0, int end = 0)
    {
        start = (start >= 0) ? start : source.Count() + start;
        end = (end > 0) ? end : source.Count() + end;

        return source.Skip(start).Take(end - start).ToList();
    }
}