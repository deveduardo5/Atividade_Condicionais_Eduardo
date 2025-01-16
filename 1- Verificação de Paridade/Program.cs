// 1- Verificação de Paridade - Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve verificar se o número é par ou ímpar. Utilize a condição if para determinar o resultado e exiba uma mensagem apropriada.

Console.WriteLine("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}
