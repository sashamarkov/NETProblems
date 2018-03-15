<Query Kind="Program" />

void Main( ) {
	var numbers = GetSmallNumbers( );
	var evenNumbers = numbers.Select( n => n * 2 );
	Console.WriteLine( evenNumbers.FirstOrDefault( ) ); // No exceptions!
}

public static IEnumerable<int> GetSmallNumbers( ) {
	yield return 1;
	throw new Exception( );
	yield return 2;
}
