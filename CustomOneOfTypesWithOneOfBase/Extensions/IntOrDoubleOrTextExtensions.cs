using System.Globalization;

namespace CustomOneOfTypesWithOneOfBase.Extensions;

internal static class IntOrDoubleOrTextExtensions
{
    internal static void PrintType(this IntOrDoubleOrText intOrDoubleOrText)
        => intOrDoubleOrText
            .Match(
                i => $"{i,-4}  is  'int'",
                d => $"{d,-4}  is  'double'",
                t => $"{t,-4}  is  'text'")
            .Print();

    internal static IntOrDoubleOrText AsIntOrDoubleOrText(this string number)
    {
        if (!double.TryParse(number, CultureInfo.InvariantCulture, out double doubleNumber))
        {
            return number;
        }

        if (doubleNumber == (int)doubleNumber)
        {
            return (int)doubleNumber;
        }

        return doubleNumber;
    }
}
