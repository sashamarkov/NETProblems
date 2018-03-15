<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	int i = 1;
    object obj = i;
    ++i;
    Console.WriteLine( i ); // 2
    Console.WriteLine( obj ); // 1
}
