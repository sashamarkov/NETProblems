<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	object sync = new object( );
    var thread = new Thread( ( ) => {
    	try {
        	Work( );
    	}
    	finally {
        	lock ( sync ) {
    			Monitor.PulseAll( sync );
        	}
    	}
    } );
    thread.Start( );
    lock ( sync ) {
    	Monitor.Wait( sync );
    }
    Console.WriteLine( "test" ); // test
}

private static void Work( ) {
	Thread.Sleep( 1000 );
}