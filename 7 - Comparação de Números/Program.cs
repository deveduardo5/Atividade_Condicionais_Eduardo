// 7 - Comparação de Números - Escreva um programa que solicita dois números ao usuário e determina qual deles é maior. Utilize if, else if e else para exibir a mensagem adequada. 

Console.WriteLine("Digite primeiro numero:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite segundo numero:");
double num2 = double.Parse(Console.ReadLine());

if (num1 >= num2)
{
    Console.WriteLine($"O numero {num1} é maior que o numero {num2}");
}
else
{
    Console.WriteLine($"O numero {num2} é maior que o numero {num1}");
}