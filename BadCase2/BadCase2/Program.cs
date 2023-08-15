Console.WriteLine($"A:{B.MyProperty}");

static class A
{
    public static int MyProperty { get; set; } = 123;
    static A() => Console.WriteLine($"B:{B.MyProperty}");
}

static class B
{
    public static int MyProperty { get; set; } = A.MyProperty;
    static B() => Console.WriteLine($"C:{A.MyProperty}");
}

