using System.Text;

var l1 = new List<String>();


Console.WriteLine("Quantas palavras?");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.WriteLine("Digite uma palavra");
    l1.Add(Console.ReadLine());
}

string maior = "";
StringBuilder stb = new StringBuilder();
bool maisDeUmaPalavra = false;
foreach (var item in l1)
{
    if (item.Length > maior.Length)
    {
        maior = item;
        maisDeUmaPalavra = false;
        stb.Clear();
        stb.Append(item);
    }
    else if (item.Length == maior.Length)
    {
        stb.Append(" e ");
        stb.Append(item);
        maisDeUmaPalavra = true;
    }



}


if (maisDeUmaPalavra)
{
    Console.WriteLine($"A maiores palavras são {stb}");
}
else
{
    Console.WriteLine($"A maior palavra é {stb}");
}

