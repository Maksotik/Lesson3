// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Функция которая выводит строку с текстом и возвращает числовое значение переменной
int string_to_number(string message){
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int X1 = string_to_number( "Введите точку Х1 - " );
int Y1 = string_to_number( "Введите точку Y1 - " );
int Z1 = string_to_number( "Введите точку Z1 - " );
int X2 = string_to_number( "Введите точку X2 - " );
int Y2 = string_to_number( "Введите точку Y2 - " );
int Z2 = string_to_number( "Введите точку Z2 - " );

int A = (X2 - X1) * (X2 - X1);
int B = (Y2 - Y1) * (Y2 - Y1);
int C = (Z2 - Z1) * (Z2 - Z1);

double sum = Math.Sqrt(A + B + C); // Функция квадратного корня 

Console.WriteLine(sum);



