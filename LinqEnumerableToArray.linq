<Query Kind="Program" />

void Main( ) {
	EnumerableToArray( );
	//GetString: Foo
	//EnumerableToArray: Foo
	//GetString: Bar
	//EnumerableToArray: Bar
	//GetString: Foo
	//GetString: Bar
}

public static string GetString( string s ) {
	Console.WriteLine("GetString: " + s);
	return s;
}
	
public static IEnumerable<string> GetStringEnumerable( ) {
	yield return GetString( "Foo" );
	yield return GetString( "Bar" );
}
	
public static string[] EnumerableToArray( ) {
	var strings = GetStringEnumerable( );
	foreach ( var s in strings ) {
		Console.WriteLine( "EnumerableToArray: " + s );
	}
	return strings.ToArray( );
}
