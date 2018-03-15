<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	Console.WriteLine( 1 + 2 + 'A' ); // 68
	Console.WriteLine( 1 + 'A' + 2 ); // 68
	Console.WriteLine( 'A' + 1 + 2 ); // 68
}