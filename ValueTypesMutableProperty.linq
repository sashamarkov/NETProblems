<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main( ) {
	var bar = new Bar { Foo = new Foo( ) };
	bar.Foo.Change( 5 );
	Console.WriteLine( bar.Foo.Value ); // 0
}

public class Bar{
	public Foo Foo{get; set;}
}

public struct Foo { 
	public int Value; 
	
	public void Change( int newValue ) {
		Value = newValue;
	}
}