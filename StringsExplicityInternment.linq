<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var x = "AB";
	var y = new StringBuilder( ).Append( 'A' ).Append( 'B' ).ToString( );
	var z = string.Intern( y );
	Console.WriteLine( x == y ); // True
	Console.WriteLine( x == z ); // True
	Console.WriteLine( (object)x == (object)y ); // False
	Console.WriteLine( (object)x == (object)z ); // True
}

// Define other methods and classes here
