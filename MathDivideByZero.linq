<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var zero = 0;
	try {
		Console.WriteLine( 42/0.0 ); //бесконечность
		Console.WriteLine( 42.0/0.0 ); // бесконечность
		Console.WriteLine( 42/zero ); //DivideByZeroException
	} 
	catch( DivideByZeroException ) {
		Console.WriteLine( "DivideByZeroException" );
	}
}
