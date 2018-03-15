<Query Kind="Program" />

void Main() {
	Foo<int>.Bar++;
	Console.WriteLine( Foo<double>.Bar ); // 0
}

class Foo<T> {
    public static int Bar;
}