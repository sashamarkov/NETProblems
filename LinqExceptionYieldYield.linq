<Query Kind="Program" />

void Main()
{
	var numbers = GetSmallNumbers( );
	var evenNumbers = numbers.Select( n => n * 2 );
	Console.WriteLine( evenNumbers.FirstOrDefault( ) ); // Exception here!
}


public static IEnumerable<int> GetSmallNumbers( ) {
	throw new Exception( );
	yield return 1;
	yield return 2;
}

// Define other methods and classes here
