<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var s = new S( );
    using ( s ) {
    	Console.WriteLine( s.GetDispose( ) ); // False - т.к. dispose = true; выполняется в finally{ }
    }
    Console.WriteLine( s.GetDispose( ) ); // False 
}

struct S : IDisposable {
	private bool dispose;

    public void Dispose( ) {
    	dispose = true;
    }

    public bool GetDispose( ) {
    	return dispose;
    }
}
