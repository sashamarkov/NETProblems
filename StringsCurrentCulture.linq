<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
	Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture( "ru-RU" );
	Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( "en-US" );
	var dateTime = new DateTime( 2014, 12, 31, 13, 1, 2 );
	Console.WriteLine( dateTime ); //12/31/2014 1:01:02 PM - en-US culture
}

// Define other methods and classes here
