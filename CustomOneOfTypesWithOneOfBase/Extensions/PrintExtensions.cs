namespace CustomOneOfTypesWithOneOfBase.Extensions;

internal static class PrintExtensions
{
    public static T Print<T>(this T value)
    {
        Console.WriteLine($"\n{value}");

        return value;
    }
}
