// See https://aka.ms/new-console-template for more information
using refreturn;

Class1 c1 = new Class1();

Class2 c2 = new();

Console.WriteLine("Hello, World!");

int x = 124;

ref int foo(ref int input)
{
    int ret = input;
    return ref input;
}

Console.WriteLine($"x={x}");

ref int y = ref foo(ref x);

Console.WriteLine($"y={y}");

y = 33;

Console.WriteLine($"y={y}");

Console.WriteLine($"x={x}");



