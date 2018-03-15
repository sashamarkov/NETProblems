<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main( ) {
	var x = new { Items = new List<int> {1, 2, 3}.GetEnumerator( ) }; // из геттера каждый раз возвращается копия структуры
	while ( x.Items.MoveNext( ) ) {
		Console.WriteLine( x.Items.Current ); 
	}
	// 0
	// 0
	// 0
	// 0
	// ...
}

