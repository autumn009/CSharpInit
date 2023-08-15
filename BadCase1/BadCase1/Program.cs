var x1 = new A();
var x2 = new B();

class A
{
    public string a = "A";
    public virtual void Sub() => Console.WriteLine($"({a})");
    public A() => Sub();
}

class B : A
{
    public override void Sub() => Console.WriteLine($"[{a}]");
    public B() => a = "B";
}
