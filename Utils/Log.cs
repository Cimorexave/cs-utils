namespace Utils;

public static class Log {
    public static void print (this string source, string? label) {
        if (label == null) Console.WriteLine(source);
        else {
            Console.WriteLine($"{label} => {source}");
        }
    }
}