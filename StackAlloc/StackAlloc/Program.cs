using System.Runtime.CompilerServices;

Sub();

[SkipLocalsInit]
void Sub()
{
    unsafe
    {
        var buffer = stackalloc int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(buffer[i]);
        }
    }
}
