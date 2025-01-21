// 9 - Dia da Semana (usando if-else) - Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro.

Console.WriteLine("Digite com um número de 1 a 7 para saber o dia da semana: ");
int dia = int.Parse(Console.ReadLine());

if (dia < 0)
{
    Console.WriteLine(dia + " não é um dia da semana.");
}
else if (dia == 1)
{
    Console.WriteLine("Domingo");
}
else if (dia == 2)
{
    Console.WriteLine("Segunda-feira");
}
else if (dia == 3)
{
    Console.WriteLine("Terça-feira");
}
else if (dia == 4)
{
    Console.WriteLine("Quarta-feira");
}
else if (dia == 5)
{
    Console.WriteLine("Quinta-feira");
}
else if (dia == 6)
{
    Console.WriteLine("Sexta-feira");
}
else if (dia == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine(dia + " não é um dia da semana.");
}