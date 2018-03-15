<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

[ThreadStatic]
static readonly int Foo = 42;

void Main( ) {
	var thread = new Thread( ( ) => Console.WriteLine( Foo ) ); //0
	thread.Start( );
	thread.Join( );
}

// Define other methods and classes here
