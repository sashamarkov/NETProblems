<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	a += Foo( ); 
	Console.WriteLine( a ); // 1 a = a + Foo(  )
}

int a = 0;

int Foo( ){
	a = a + 42;
	return 1;
}
