//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void Checkkoord(int x, int y) //void ничего не возвращает
// {
//     if (x > 0 && y > 0) Console.WriteLine("Это первая четверть");
//     else if (x < 0 && y > 0) Console.WriteLine("Это вторая четверть");
//     else if (x > 0 && y < 0) Console.WriteLine("Это четвертая четверть");
//     else if (x < 0 && y < 0) Console.WriteLine("Это третья четверть");
//     else Console.WriteLine("Точка находится в начале координат");
// }

// string Checkkoord2(int x, int y) // тип string параметры int x, int y
// {
//     string res;
//     if (x > 0 && y > 0) res = "Это первая четверть";
//     else if (x < 0 && y > 0) res = "Это вторая четверть";
//     else if (x > 0 && y < 0) res = "Это четвертая четверть";
//     else if (x < 0 && y < 0) res = "Это третья четверть";
//     else res = "Точка находится в начале координат";
//     return res;
// }

// //обработка исключений. делаем try, если не получается переходим в catch]
// try
// {
//     Console.WriteLine("Введите координату x");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату y");
//     int y = Convert.ToInt32(Console.ReadLine());
//     Checkkoord(x, y);
//     Console.WriteLine(Checkkoord2(x,y));
// }
// catch
// {
//     Console.WriteLine("Вы ввели не целое число");
// }


//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// void Checkkoord(int nomer)
// {
//     if (nomer == 1) Console.WriteLine("диапозон координат x>0 y>0");
//     else if (nomer == 2) Console.WriteLine("диапозон координат x<0 y>0");
//     else if (nomer == 3) Console.WriteLine("диапозон координат x>0 y<0");
//     else if (nomer == 4) Console.WriteLine("диапозон координат x<0 y<0");
//     else Console.WriteLine("Неправильно введен номер четверти");
// }

// string Checkkoord2(int nomer)
// {
//     string res;
//     if (nomer == 1) res = "диапозон координат x>0 y>0";
//     else if (nomer == 2) res = "диапозон координат x<0 y>0";
//     else if (nomer == 3) res = "диапозон координат x>0 y<0";
//     else if (nomer == 4) res = "диапозон координат x<0 y<0";
//     else res = "Неправильно введен номер четверти";
//     return res;
// }

// try
// {
//     Console.WriteLine("Введите номер четверти");
//     int nomer = Convert.ToInt32(Console.ReadLine());
//     Checkkoord(nomer);
//     Console.WriteLine(Checkkoord2(nomer));
// }
// catch
// {
//     Console.WriteLine("Вы вводите не номер");
// }


//Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double pointrass(int x1, int y1, int x2, int y2)
// {
//     double rass;
//     rass = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
//     return rass;
// }

// try
// {
//     Console.WriteLine("Введите x координату первой точки");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите y координату первой точки");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите x координату второй точки");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите y координату второй точки");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Расстояние между двумя точками {pointrass(x1, y1, x2, y2)}");
// }
// catch
// {
//     Console.WriteLine("Вы вводите несуществующие координаты");
// }

//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чиселот 1 до N.

void quadseries(int num)
{
    if (num<0) num=num*(-1);
    for (int i = 1; i <= num; i++)
    {
        Console.Write($" {i * i}");
    }
}
try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    quadseries(num);
}
catch
{
    Console.WriteLine("Вы ввели не число");
}