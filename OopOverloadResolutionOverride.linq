<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

void Main( ) {
	new Bar( ).Quux( 42 ); //Bar.Quux(object)
	new Baz( ).Quux( 42 ); // Baz.Quux(params T[])
}

internal class Foo {

    public virtual void Quux( int a ) {
        Console.WriteLine( "Foo.Quux(int)" );
    }

}

internal class Bar : Foo {

    public override void Quux( int a ) {
        Console.WriteLine( "Bar.Quux(int)" );
    }

    public void Quux( object a ) {
        Console.WriteLine( "Bar.Quux(object)" );
    }

}

internal class Baz : Bar {

    public override void Quux( int a ) {
        Console.WriteLine( "Baz.Quux(int)" );
    }

    public void Quux<T>( params T[] a ) {
        Console.WriteLine( "Baz.Quux(params T[])" );
    }

}