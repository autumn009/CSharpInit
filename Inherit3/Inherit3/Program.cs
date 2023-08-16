var x = new B();
Console.WriteLine($"x.MyProperty={x.MyProperty}");

class A
{
    internal virtual int MyProperty { get; set; } = 1;
    internal A() => Console.WriteLine($"A constructed MyProperty={MyProperty}");
}
class B : A
{
    internal override int MyProperty { get; set; } = 2;
}
