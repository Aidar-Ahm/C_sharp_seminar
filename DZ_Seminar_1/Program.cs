// Задача2. Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"max={number1} min={number2}");
}
else 
{
    Console.WriteLine($"max={number2} min={number1}");
}


// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max = number1;
// if (max  < number2)
// {
//     max = number2;
// }
// if (max < number3)
//     {
//         max = number3;
//     }
// Console.WriteLine($"max={max}");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number%2==0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }


//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = 2;
// if (number > 1 )
// { 
//     while (number2 <= number)
//     {
//         Console.Write($"{number2}, ");
//         number2 = number2+2;
//     }
// }
// else
// {
//     Console.WriteLine("Некоректное число");
// }


//Задача 7 HARD: - идет за 2 необязательных Напишите программу,
// которая принимает на вход целое число любой разрядности и на выходе показывает
// третью цифру слева этого числа или говорит, что такой цифры нет.
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// if (number > 99)
// {
//     while (number > 999)
//     {
//         number = number/10;
//     }
//     result = number%10;
//     Console.WriteLine($"третье число {result}");
// } 
// else
// {
//     Console.WriteLine("Некоректное число, третьей цифры нет");
// }