Console.WriteLine($"A:{AB.MyPropertyB}");

static class AB
{
    private const int initialValue = 123;
    public static int MyPropertyA { get; set; } = initialValue;
    public static int MyPropertyB { get; set; } = initialValue;
    static AB()
    {
        Console.WriteLine($"B:{MyPropertyB}");
        Console.WriteLine($"C:{MyPropertyA}");
    }
}
