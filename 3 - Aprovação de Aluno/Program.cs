// 3 - Aprovação de Aluno - Escreva um programa que pergunte a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele é "Reprovado". Exiba a situação do aluno na tela.

Console.WriteLine("Digite a primeira nota : ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota : ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota : ");
double numero3 = double.Parse(Console.ReadLine());

double media = (numero1 + numero2 + numero3) / 3;

if (media >= 6)
{
    Console.WriteLine($"Aprovado {media}");
}
else
{
    Console.WriteLine($"Reprovado {media}");
}
