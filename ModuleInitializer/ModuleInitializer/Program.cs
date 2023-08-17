using System.Runtime.CompilerServices;

Console.WriteLine("Running without A or B");

static class A
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.WriteLine("Init A called");
    }
    static A() => Console.WriteLine("Constructor A called");
}
static class B
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.WriteLine("Init B called");
    }
    static B() => Console.WriteLine("Constructor B called");
}
