<Query Kind="Program" />

void Main( ) {
	Console.WriteLine( GetSmallNumbers().First( ) ); 
	// Foo
	// 1
}


public static IEnumerable<int> GetSmallNumbers( ) {
	try {
		yield return 1;
		yield return 2;
	}
	finally {
		Console.WriteLine( "Foo" );
	}
}
