// Напишите программу, которая принимает на вход ЛЮБОЕ число типа int и проверяет,
// является ли оно палиндромом, с помощью массива.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int [] array = new int [digit_counter(number)]; // Создаем массив, размер задает функция
int i = array.Length; // Переменная используется для счетчика последней ячейки, в следующем цикле.
int max_index = array.Length - 1; // Переменная для указания индекса последней ячейки цикла for

// Цикл в котором мы заполняем массив цифрами введенного числа
while( i != 0 ){   
    i--;  
    array [i] = number % 10;
    number /= 10; 
}

// Цикл в котором мы сравниваем ячейки массива(первую с последней, всторую с предпоследней и.т.д.)
for ( int count = 0; count <= max_index; count++ ){

if( array[count] == array[max_index] )
    max_index--;
else{
    Console.WriteLine("Введенное число НЕ является палиндромом! "); 
    return;   
} 

}
Console.WriteLine("Введенное число палиндром!");

// Метод подсчета количества цифр в числе.
int digit_counter(int N){   
int i = 0;
while( N != 0 ){
    N /= 10;
    i++;
}return i;
}
