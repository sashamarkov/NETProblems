<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	// ошибка компиляции
    //B obj1 = new A();
    //obj1.Foo();

    B obj2 = new B( );
    obj2.Foo( ); // Class B

    A obj3 = new B( );
    obj3.Foo( ); // Class B
}

class A {
    public virtual void Foo( ) {
        Console.WriteLine( "Class A" );
    }
}

class B : A {
    public override void Foo( ) {
        Console.WriteLine( "Class B" );   
    }
}
