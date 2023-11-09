using System.Collections.Generic;

var listNumbers = new List<int>() { 1, 3, 7, 18, 27, 3, 55, 2, 4, 8 };

listNumbers.RemoveAll(i => i % 2 == 0);

int sum = 0;

foreach (var number in listNumbers)
{
    sum += number;  
}
Console.WriteLine(sum);