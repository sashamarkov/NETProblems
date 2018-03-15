<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var c = new C( );
    A a = c;

    a.Print2( ); // A
    a.Print1( ); // B
    c.Print2( ); // C
}

public class A {
	public virtual void Print1( ) {
    	Console.WriteLine( "A" );
    }
    public void Print2( ) {
       	Debug.WriteLine( "A" );
    }
}

public class B : A {
	public override void Print1( ) {
        Debug.WriteLine( "B" );
    }
}

public class C : B {
	public new void Print2( ) {
        Debug.WriteLine( "C" );
    }
}