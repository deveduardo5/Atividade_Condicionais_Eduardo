// 8 - Verificação de Votação - Crie um programa que pergunte a idade de uma pessoa e determine se ela pode votar (idade >= 16). Utilize uma condição if para exibir a mensagem correspondente. 

Console.WriteLine("Digite sua idade : ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 0)
    Console.WriteLine($"Idade invalida: {idade}.");
else if (idade >= 16 && idade <= 17)
{
    Console.WriteLine($"Voto permitido mas não obrigatório:{idade}.");
}
else if (idade >= 18 && idade <= 69)
{
    Console.WriteLine($"Voto obrigatório:{idade}.");
}

else
{
    Console.WriteLine($"Voto permitido mas não obrigatório:{idade}.");
}