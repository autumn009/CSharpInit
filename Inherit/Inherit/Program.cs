var x = new C();

class A
{
    internal A() => Console.WriteLine("A constructed");
}
class B:A
{
    internal B() => Console.WriteLine("B constructed");
}
class C:B
{
    internal C() => Console.WriteLine("C constructed");
}
