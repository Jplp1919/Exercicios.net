var listNumbers = new List<int>() { 1, 3, 7,  18, 27, 3, 55, 2, 4};

listNumbers.Sort();
bool par;


int length = listNumbers.Count;


int middle = (length / 2) +1;

if (length % 2 == 0)
{
    par = true;
} else
{
    par = false;
}


if (par)
{
    Console.WriteLine(@$"Os pontos médios são
                      {listNumbers[middle]} e  {listNumbers[middle+1]}");
}
else
{
    Console.WriteLine($"O ponto médio é {listNumbers[middle]}");
}