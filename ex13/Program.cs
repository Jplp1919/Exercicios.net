var listDuplicada = new List<String>() { "hugh", "Jackson", "Albrert", "hugh", "Jackson", "Albrert" };


var listNaoDuplicada = listDuplicada.Distinct().ToList();   

foreach (var item in listNaoDuplicada)
{
    Console.WriteLine(item);
}