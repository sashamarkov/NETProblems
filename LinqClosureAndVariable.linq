<Query Kind="Program" />

void Main()
{
	var list = new List<string> {"Foo", "Bar", "Baz"};
	var startLetter = "F";
	var query = list.Where( c => c.StartsWith( startLetter ) );
	startLetter = "B";
	query = query.Where( c => c.StartsWith( startLetter ) );
	Console.WriteLine( query.Count( ) ); // 2
}

// Define other methods and classes here
