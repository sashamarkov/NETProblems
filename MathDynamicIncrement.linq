<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	byte foo = 1;
	dynamic bar = foo;
	Console.WriteLine( bar.GetType( ) ); // System.Byte
	bar += foo;
	Console.WriteLine( bar.GetType( ) ); // System.Int32
}
