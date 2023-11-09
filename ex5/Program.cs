var l1 = new List<int>();

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite um numero");
    l1.Add(Convert.ToInt32(Console.ReadLine()));
}


int smallest;
int secondSmallest;

smallest = l1[0];

secondSmallest = l1.Last();

foreach (int i in l1)
{
    if (i < smallest)
    {
        smallest = i;
    }
}

foreach (int i in l1)
{
    if (i < secondSmallest && i > smallest)
    {
        secondSmallest = i;
    }
    
}

Console.WriteLine($"o segundo menor é {secondSmallest}");