// 5 - Verificação de Idade - Desenvolva um programa que solicite a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Utilize if e else para mostrar a mensagem apropriada.

Console.WriteLine("Digite sua idade : ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 0)
{
    Console.WriteLine($"Idade invalida: {idade}.");
}
else if (idade <= 17)
{
    Console.WriteLine($"Menor de idade: {idade}.");
}

else
{

    Console.WriteLine($"Maior de idade: {idade} ");
}