<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	try{
		Console.WriteLine( ( (string)null + null + null) == null ); // False
		// (string)null === ""
	} 
	catch (Exception ex) {
		Console.WriteLine( ex.GetType( ) );
	}
}

// Define other methods and classes here
