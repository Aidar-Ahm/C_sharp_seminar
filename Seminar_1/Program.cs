// Напишите программу, которая на вход принимает число и выдает 
//его квадрат (число умноженноена само себя).
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number*number;
// Console.WriteLine($"Квадрат числа равен {square}");


//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2*number2)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }

//Задача №3. Напишите программу, которая будет выдавать название дня недели 
//по заданному номеру.
// Console.WriteLine("Введите номер дня");
// int day = Convert.ToInt32(Console.ReadLine());
// switch(day)
// {
//     case 1 : Console.WriteLine("Понедельник");
//     break;
//     case 2 : Console.WriteLine("Вторник");
//     break;
//     case 3 : Console.WriteLine("Среда");
//     break;
//     case 4 : Console.WriteLine("Четверг");
//     break;
//     case 5 : Console.WriteLine("Пятница");
//     break;
//     case 6 : Console.WriteLine("Суббота");
//     break;
//     case 7 : Console.WriteLine("Воскресенье");
//     break;
//     default : Console.WriteLine("Неправильный номер");
//     break;
// }  


//Задача №5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count=-number;
// while (count<=number)
// {
//     Console.Write($"{count}, ");
//     count++;
// }


//Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1000 && number>99)
{
    Console.WriteLine($"{number%10}");
}
else
{
    Console.WriteLine("Неверное число");
}