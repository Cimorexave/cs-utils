namespace Utils;

public static class Log {
    private static int callsCount = 0;
    public static void print (this string source, string? label) {
        if (label == null) Console.WriteLine(source);
        else {
            Console.WriteLine($"{label} => {source}");
        }
    }
    public static void count () {
        Console.WriteLine(++callsCount);
    }
    public static void log(string msg = "Here! ----->") {
        Console.WriteLine(msg);
    }
}