<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var foo = new Foo( new ReaderWriterLockSlim( ) );
	GC.Collect( );
	GC.WaitForPendingFinalizers( );
	//~Foo: start
	//Exception: SynchronizationLockException
	//~Foo: finish
	// 
}

class Foo{
	private readonly ReaderWriterLockSlim lockSlim;
	
	public Foo( ReaderWriterLockSlim lockSlim ) {
		this.lockSlim = lockSlim;
		lockSlim.EnterReadLock( );
	}
	
	~Foo( ) {
		Console.WriteLine("~Foo: start");
		try{
			if( lockSlim != null ){
				lockSlim.ExitReadLock( );
		    }
		}	
		catch( Exception e ) {
			Console.WriteLine( "Exception: " + e.GetType( ).Name );
		}
		Console.WriteLine( "~Foo: finish" );
	}
}

// Define other methods and classes here
