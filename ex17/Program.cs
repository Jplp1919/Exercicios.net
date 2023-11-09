using ex17;
var conta = new ContaBancaria();

while (true)
{

    Console.WriteLine("1 - Deposito; 2 - Saque; 3 - Consultar Saldo 4 - Sair");
    
    var operacao = Convert.ToInt32(Console.ReadLine());

   if(operacao == 1)
    {
        Console.WriteLine("Quanto deseja despositar?");
        var valor = Convert.ToDecimal(Console.ReadLine());
        conta.Depositar(valor);

    } else if (operacao == 2)
    {
        Console.WriteLine("Quanto deseja sacar?");
        var valor = Convert.ToDecimal(Console.ReadLine());
        conta.Sacar(valor);
    } else if (operacao == 3)
    {
        Console.WriteLine(conta.ConsultarSaldo());  
    }
    else if (operacao == 4)
    {
        Console.WriteLine("Muito obrigado por usar o nosso banco!");
        break;
    }
    else
    {
        Console.WriteLine("Valor invalido");
        break;
    }

    Console.WriteLine("Deseja fazer mais alguma operação? 1 - Sim 2 - Não");

    operacao = Convert.ToInt32(Console.ReadLine());

    if (operacao == 2) {
        Console.WriteLine("Muito obrigado por usar o nosso banco!");
        break;
    }
    else
    {
        Console.WriteLine("Valor invalido");
        break;
    }


}