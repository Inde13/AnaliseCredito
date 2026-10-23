// Um cliente quer solicitar um empréstimo. 
// Receba o valor solicitado, a quantidade de parcelas desejada e a renda mensal comprovada. 
// Só autorize empréstimos cuja parcela não ultrapasse 30% da renda (desconsidere os juros).

Console.Clear();

double vlSolicitado, rendaMensal, vlParcela, porcentagemParcela;
int qtParcelas;

Console.WriteLine("-= Consulta Empréstimo =-\n");

Console.Write("Digite o valor que deseja solicitar: R$ ");
vlSolicitado = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de parcelas a pagar: ");
qtParcelas = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de sua renda mensal: R$ ");
rendaMensal = Convert.ToDouble(Console.ReadLine());

vlParcela = vlSolicitado / qtParcelas;
porcentagemParcela = vlParcela / rendaMensal;

Console.WriteLine("\n-= Resultado =-\n");

Console.WriteLine($"Valor das parcelas: R$ {vlParcela:N2}");
Console.WriteLine($"Valor da renda mensal: R$ {rendaMensal:N2}");
Console.WriteLine($"Porcentagem da parcela sobre a renda: {porcentagemParcela*100:N2}%");

if (porcentagemParcela <= .3) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nEmpréstimo autorizado!");
} else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nEmpréstimo não autorizado!");
    
    Console.ResetColor();
    Console.WriteLine("A porcentagem das parcelas sobre a renda mensal excede 30%.");
}

Console.ResetColor();
