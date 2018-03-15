<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	Action<int, int> print = ( a, b ) => Console.WriteLine( "{0,2} = {1,2} * {2,3} + {3,3}  ", a, b, a/b, a%b );
	Console.WriteLine(" a = b * ( a/b ) + ( a%b )");
	print( 7, 3 ); // 7 =  3 *   2 + 1  
	print( 7, -3 ); // 7 = -3 *  -2 + 1  
	print( -7, 3 ); // -7 =  3 *  -2 + -1
	print( -7, -3 ); // -7 = -3 *   2 +  -1
}
