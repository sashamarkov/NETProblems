<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	string a = "i";
	string b = "I";
	Console.WriteLine( string.Compare( a.ToUpper( ), b.ToUpper( ) ) ); // 0
	Console.WriteLine( string.Compare( a, b, StringComparison.OrdinalIgnoreCase ) ); // 0
	
	Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("tr-TR");
	Console.WriteLine( string.Compare( a.ToUpper( ), b.ToUpper( ) ) ); // 1
	Console.WriteLine( string.Compare( a, b, StringComparison.OrdinalIgnoreCase ) ); // 0
}
