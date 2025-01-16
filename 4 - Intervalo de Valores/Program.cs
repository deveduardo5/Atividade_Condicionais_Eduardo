// 4 - Intervalo de Valores - Crie um programa que verifique se um número digitado pelo usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para verificar se o número está no intervalo e exiba uma mensagem informando o resultado

Console.WriteLine("Digite um número : ");
int numero = int.Parse(Console.ReadLine());

if (numero < 1)
{
    Console.WriteLine($"O número não está entre 1 e 100: {numero}.");
}
else if (numero <= 100)
{
    Console.WriteLine($"O número está entre 1 e 100: {numero}.");
}

else
{

    Console.WriteLine($"Número acima de 100: {numero} ");
}