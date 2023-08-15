var x = new C();

static class Util
{
    internal static string Sub(string x)
    {
        Console.WriteLine($"Sub({x}) called");
        return x;
    }
}

class A
{
    internal string x1 = Util.Sub("x1");
    internal string y1 { get; set; } = Util.Sub("y1");
    internal A() => Console.WriteLine("A constructed");
}
class B:A
{
    internal string x2 = Util.Sub("x2");
    internal string y2 { get; set; } = Util.Sub("y2");
    internal B() => Console.WriteLine("B constructed");
}
class C:B
{
    internal string x3 = Util.Sub("x3");
    internal string y3 { get; set; } = Util.Sub("y3");
    internal C() => Console.WriteLine("C constructed");
}
