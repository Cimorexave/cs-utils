namespace Utils;

public static class Parser {
    public static float parseFloat(this string source)
    {
        if (source.Contains(",")) return float.Parse(source.Replace(",","."));
        else return float.Parse(source);
    }
}