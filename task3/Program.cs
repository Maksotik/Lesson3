//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
int i = 1;
int cube;

Console.Write("Результат - ");
while( i <= number){
    cube = i * i * i;
    i++;
    Console.Write("{0}   ", cube);
}
Console.WriteLine();