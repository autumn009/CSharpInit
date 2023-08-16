Console.WriteLine($"A.X={A.X}");

static class A
{
    internal static int X;
    internal static int Y;
    static A()
    {
        X = B.Z;
        Y = 2;
    }
}
static class B
{
    internal static int Z;
    static B()
    {
        Z = A.Y;
    }
}
