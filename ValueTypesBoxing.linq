<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

struct Foo { 
	int value; 
	public override string ToString( ) {
		if( value == 2 ) {
			return "Baz";
		}
		return (value++ == 0) ? "Foo" : "Bar";
	}
}

void Main( ) {
	var foo = new Foo( );
	Console.WriteLine( foo ); // Foo
	Console.WriteLine ( foo ); // Foo
	object bar = foo; // boxing
	object qux = foo; // boxing
	object baz = bar; // boxing
	Console.WriteLine( baz ); // Foo
	Console.WriteLine( bar ); // Bar
	Console.WriteLine( baz ); // Baz
	Console.WriteLine( qux ); // Foo
}

// Define other methods and classes here
