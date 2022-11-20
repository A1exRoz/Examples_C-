DateTime nowDate = DateTime.Now;
string someText = "Сегодня";
int number = 924;
Console.WriteLine(nowDate);
Console.WriteLine(someText);
Console.WriteLine(number);
Console.WriteLine($"{someText} {nowDate}. Число: {number}");
Console.WriteLine("{1}: {0:yyyy-MM-dd}, Число: {2}", nowDate, someText, number);
