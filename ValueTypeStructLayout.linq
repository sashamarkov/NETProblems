<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	Console.WriteLine( Marshal.SizeOf( typeof( Foo ) ) ); // 8
	Console.WriteLine( Marshal.SizeOf( typeof( Bar ) ) ); // 8
	Console.WriteLine( Marshal.SizeOf( typeof( Qux ) ) ); // 5
}

public struct Foo {
	public byte Byte1;
	
	public int Int1;
}

public struct Bar {
	public byte Byte1;
	
	public byte Byte2;
	
	public byte Byte3;
	
	public byte Byte4;
	
	public int Int1;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Qux {
	public byte Byte1;
	
	public int Int1;	
}