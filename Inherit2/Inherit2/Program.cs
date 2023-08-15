var x = new B();

class A
{
    protected virtual int MyProperty { get; set; } = 1;
    internal A() => Console.WriteLine($"A constructed MyProperty={MyProperty}");
}
class B : A
{
    protected override int MyProperty { get; set; } = 2;
    internal B() => Console.WriteLine($"B constructed MyProperty={MyProperty}");
}
