Console.WriteLine($"X.A={X.A}");
Console.WriteLine($"X.B={X.B}");
Console.WriteLine($"X.C={X.C}");

static class X
{
    public static int A = Sub(123) + C;
    public static int B { get; set; } = Sub(456);
    public static int C = Sub(789) + A;
    public static int Sub(int s)
    {
        Console.WriteLine($"Sub {s}");
        return s;
    }
}
