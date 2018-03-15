<Query Kind="Program" />

void Main( ) {
	var list = new List<string> { "Foo", "Bar", "Baz" };
	var query = list.Where( c => c.StartsWith( "B" ) );
	list.Remove( "Bar" );
	Console.WriteLine( query.Count( ) ); // 1
}





