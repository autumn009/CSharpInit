Console.WriteLine($"B.a={B.a}");

class A
{
    //public int a = b; // 書けない
    public int b = 1;
}
static class B
{
    public static int a = b;
    public static int b = 1;
}
