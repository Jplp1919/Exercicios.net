
using System.Collections.Generic;
using System.Xml.Linq;

var listNumbers = new List<int>() { 1, 3, 7, 19, 27, 3 };


var listNames = new List<String>() { "hugh", "Jackson", "Albrert", "Johnson", "Igor", "Luan", "Wesley", "João" };

var sortedList = listNames.OrderBy(x => x).ToList();

foreach (var name in sortedList)
{

    Console.WriteLine(name);
}

Console.WriteLine("Agora revertido");


List<String> sortedListDesc = listNames;

sortedListDesc.Sort();
sortedListDesc.Reverse();

foreach (var name in sortedListDesc)
{

    Console.WriteLine(name);

}

var listNames2 = new List<String>() { "hugh", "Jackson", "Albrert", "Johnson", "Igor", "Luan", "Wesley", "João", "hugh", "Jackson", "Albrert", "Johnson", "Igor", "Luan", "Wesley", "João" };

Console.WriteLine("Sem repetidos");

List<String> listUnique = listNames2.Distinct().ToList();

foreach (var name in listUnique)
{

    Console.WriteLine(name);

}
