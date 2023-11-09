var listNumbers = new List<int>() { 1, 3, 7, 18, 27, 3, 55, 2, 4, 8 };
Console.WriteLine("Dividir por ");
int divider = Convert.ToInt32(Console.ReadLine());

foreach (int i in listNumbers)
{
    Console.WriteLine(i/divider);
}



