var x1 = new A();
var x2 = new B();

class A
{
    public virtual string a { get; set; } = "A";
    public virtual void Sub() => Console.WriteLine($"({a})");
    public A() => Sub();
}

class B : A
{
    public override string a { get; set; } = "B";
    public override void Sub() => Console.WriteLine($"[{a}]");
}
