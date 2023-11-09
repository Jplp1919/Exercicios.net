
using ex12;

Produto p1 = new Produto("Pasta dental", 4.5, 20);

Produto p2 = new Produto("Sabonete", 5, 34);

Produto p3 = new Produto("Desodorante", 18.5, 12);

Produto p4= new Produto("Chiclete", 0.3, 120);


var l1 = new List<Produto>() { p1, p2, p3, p4};


var filter = l1.Where(produto => produto.Preço > 4.6);


foreach (var l in filter)
{
        Console.WriteLine(($"Nome: {l.Nome}, valor: {l.Preço}, estoque {l.Estoque}"));
   
}