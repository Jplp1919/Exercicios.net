var listFruit = new List<String>() {  "Uva", "Laranja", "Tomate", "Maça"};
string fruit = "maça";
if (listFruit.Contains(fruit, StringComparer.OrdinalIgnoreCase)){
    Console.WriteLine("Sim");

}
else
{
    Console.WriteLine("Não");
}