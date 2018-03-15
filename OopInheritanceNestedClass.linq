<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

void Main( ) {
	new Baz( );
}

internal class Foo {
    protected class Quux {
        public Quux( ) {
            Console.WriteLine( "Foo.Quux()" );
        }
    }
}

internal class Bar : Foo {
    private new class Quux {
        public Quux( ) {
            Console.WriteLine( "Bar.Quux()" );

        }
    }
}


class Baz : Bar {
    public Baz( ) {
        new Quux( ); //Foo.Quux()
    }
}