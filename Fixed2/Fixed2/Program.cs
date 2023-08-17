Console.WriteLine($"A:{AB.MyPropertyB}");

static class AB
{
    public static int MyPropertyA { get; set; } = 123;
    public static int MyPropertyB { get; set; } = MyPropertyA;
    static AB()
    {
        Console.WriteLine($"B:{MyPropertyB}");
        Console.WriteLine($"C:{MyPropertyA}");
    }
}
