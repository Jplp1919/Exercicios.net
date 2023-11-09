using System.Text;

var l1 = new List<int>() { 1, 3, 7, 18};

var l2 = new List<int>() { 5, 9, 75, 8 };

StringBuilder stb = new StringBuilder();


var l3 = new List<string>();   

for (int i = 0; i < l1.Count && i< l2.Count; i++)
{
    stb.Append(l1[i]);
    stb.Append(l2[i]);
    Console.WriteLine(stb);

    l3.Add(stb.ToString());

    stb.Clear();

}