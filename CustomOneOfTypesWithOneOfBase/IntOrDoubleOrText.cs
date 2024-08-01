using OneOf;

namespace CustomOneOfTypesWithOneOfBase;

internal class IntOrDoubleOrText : OneOfBase<int, double, string>
{
    private IntOrDoubleOrText(int number) : base(number) { }
    private IntOrDoubleOrText(double number) : base(number) { }
    private IntOrDoubleOrText(string number) : base(number) { }

    public static implicit operator IntOrDoubleOrText(int number) => new(number);
    public static implicit operator IntOrDoubleOrText(double number) => new(number);
    public static implicit operator IntOrDoubleOrText(string number) => new(number);
}
