<Query Kind="Program" />

void Main( ) {
	var actions = new List<Action>( );
	for ( var i = 0; i < 3; i++ ) {
		actions.Add( ( ) => Console.WriteLine( i ) );
	}
	foreach( var action in actions ) {
		action( );
	}
	// 3
	// 3
	// 3
}