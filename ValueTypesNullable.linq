<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main( ) {
    var s = (short)123;
    //var j = s as int?; // Ошибка компиляции
    var j = (int?)s; 
    Console.WriteLine( j ); // 123
}
