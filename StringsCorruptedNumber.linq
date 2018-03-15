<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	// ??? "Foo" needed
	Console.WriteLine( -42 );
	
	var culture = ( CultureInfo )CultureInfo.InvariantCulture.Clone( );
	culture.NumberFormat.NegativeSign = "Foo";
	Thread.CurrentThread.CurrentCulture = culture;
	Console.WriteLine( -42 );
}