for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
    if (i >= 3) A.MyProperty++;
}
Console.WriteLine($"A.MyProperty={A.MyProperty}");

class A
{
    internal static int MyProperty { get; set; } = 100;
    static A() => Console.WriteLine("A constructed");
}
class B
{
    internal static int MyProperty { get; set; } = 200;
    static B() => Console.WriteLine("B constructed");
}