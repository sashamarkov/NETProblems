<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var w = new Wrap( );
    var wraps = new Wrap[3];
    for ( int i = 0; i < wraps.Length; i++ ) {
        wraps [ i ] = w;
    }

    var values = wraps.Select( x => x.Value );
    var results = Square( values );
    int sum = 0;
    int count = 0;
    foreach ( var r in results ) {
    	count++;
        sum += r;
    }
	// 1
	// 4 
	// 9
    Debug.WriteLine( "Count {0}", count ); //Count 3
    Debug.WriteLine( "Sum {0}", sum ); // Sum 14
	
	// 16
	// 25
	// 36
    Debug.WriteLine( "Count {0}", results.Count( ) ); // Count 3
	
	// 49
	// 64
	// 81
    Debug.WriteLine( "Sum {0}", results.Sum( ) ); //Sum 194
}

private static IEnumerable<int> Square( IEnumerable<int> a ) {
	foreach ( var r in a ) {
    	Console.WriteLine( r*r );
        	yield return r*r;
    }
}

private class Wrap {
	private static int init = 0;

    public int Value {
    	get { return ++init; }
    }
}