<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	lock ( syncObject ) {
        Write( ); // test - same thread
    }
}

private static Object syncObject = new Object( );

private static void Write( ) {
    lock ( syncObject ) {
        Debug.WriteLine( "test" );
    }
}
