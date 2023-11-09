var listNames = new List<String>() { "hugh", "Jackson", "Albrert", "Johnson", "Igor", "Luan", "Wesley", "João" };

listNames.Insert(0, "first");

listNames.Add("last");

foreach (var name in listNames)
{
    Console.WriteLine(name);
}
