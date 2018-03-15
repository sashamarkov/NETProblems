<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	Foo( ); //params object[]
	Foo( null ); //params object[]
	Foo( new Bar( ) ); //params T[]
	Foo( new Bar( ), new Bar( ) ); //params T[]
	Foo( new Bar( ), new object( ) ); // object, object
}

void Foo( object a ) {
	Console.WriteLine( "object" );
}

void Foo( object a, object b ){
	Console.WriteLine( "object, object" );
}

void Foo( params object[] args ) {
	Console.WriteLine( "params object[]" );
}

void Foo<T>( params T[] args ){
	Console.WriteLine( "params T[]" );
}
class Bar { }
