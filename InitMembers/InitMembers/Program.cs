var x = new X() { D = 3 };
Console.WriteLine($"x.A={x.A}");
Console.WriteLine($"x.B={x.B}");
Console.WriteLine($"x.C={x.C}");
Console.WriteLine($"x.D={x.D}");

class X
{
    internal int A;
    internal int B=1;
    internal int C=1;
    internal int D=1;
    public X()
    {
        C = 2;
        D = 2;
    }
}
