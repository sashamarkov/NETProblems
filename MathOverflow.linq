<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	var maxInt32 = Int32.MaxValue;
	var maxDouble = Double.MaxValue;
	var maxDecimal = Decimal.MaxValue;
	
	checked{
		Console.WriteLine("Checked Int32 increased max: ");
		try	{
			Console.WriteLine( maxInt32 + 42 );
		} 
		catch {
			Console.WriteLine( "OverflowException" ); // OverflowException
		}
		
		Console.WriteLine("Checked Double increased max: ");
		try	{
			Console.WriteLine( maxDouble + 42 ); // 1,79769313486232E+308
		} 
		catch {
			Console.WriteLine( "OverflowException" );
		}
		
		Console.WriteLine("Checked Decimal increased max: ");
		try	{
			Console.WriteLine( maxDecimal + 42 );
		} 
		catch {
			Console.WriteLine( "OverflowException" ); //OverflowException
		}
	}
	unchecked{
		Console.WriteLine("Unchecked Int32 increased max: ");
		try	{
			Console.WriteLine( maxInt32 + 42 ); // -2147483607
		} 
		catch {
			Console.WriteLine( "OverflowException" );
		}
		
		Console.WriteLine("Unchecked Double increased max: ");
		try	{
			Console.WriteLine( maxDouble + 42 ); // 1,79769313486232E+308
		} 
		catch {
			Console.WriteLine( "OverflowException" );
		}
		
		Console.WriteLine("Unchecked Decimal increased max: ");
		try	{
			Console.WriteLine( maxDecimal + 42 );
		} 
		catch {
			Console.WriteLine( "OverflowException" ); // OverflowException
		}
	}
}

// Define other methods and classes here
