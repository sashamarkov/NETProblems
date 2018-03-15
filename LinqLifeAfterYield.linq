<Query Kind="Program" />

void Main( ) {
	foreach( var str in Foo( ) ) { 
		Console.WriteLine( str );
	}
	//Bar
	//Baz
}

IEnumerable<string> Foo( ) {
	yield return "Bar";
	Console.WriteLine( "Baz" );
}

