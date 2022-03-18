// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// С помощью строки, с отрицательными числами не работает

Console.WriteLine("Введите число-> ");
string number = Console.ReadLine();

if(number.Length == 5){
    
    if(number[0] == number[4] && number[1] == number[3]){
        Console.WriteLine("Число {0} является палиндромом.", number);
    }else Console.WriteLine("Число {0} не является палиндромом", number);

}else Console.WriteLine("Число не пятизначное!");
