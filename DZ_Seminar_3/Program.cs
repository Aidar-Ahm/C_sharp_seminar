// //Задача 19
// //Напишите программу, которая принимает на вход пятизначное число и проверяет,
// //является ли оно палиндромом. Через строку решать нельзя.


// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<100000 && num >0)
// {
//     if (num/10000 == num%10 && num/1000%10 == num/10%10) Console.WriteLine("Число является палиндромом");
//     else Console.WriteLine("Число не является палиндромом");
// }
// else Console.WriteLine("Число введено не верно");


// //Задача 21
// //Напишите программу, которая принимает на вход координаты двух точек и находит
// //расстояние между ними в 3D пространстве.

// void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double d = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow(z1-z2,2));
//     Console.WriteLine($"Расстояние между двумя точками равно {d}");
// }
// try
// {
//     Console.WriteLine("Введите координаты первой точки");
//     double x1 = Convert.ToDouble(Console.ReadLine());
//     double y1 = Convert.ToDouble(Console.ReadLine());
//     double z1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите координаты второй точки");
//     double x2 = Convert.ToDouble(Console.ReadLine());
//     double y2 = Convert.ToDouble(Console.ReadLine());
//     double z2 = Convert.ToDouble(Console.ReadLine());
//     Distance(x1,y1,z1,x2,y2,z2);
// }
// catch
// {
//     Console.WriteLine("Координаты введены неверно");
// }


// //Задача23
// //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Quad(int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         Console.Write($"{i * i} ");
//     }
// }
// try
// {
//     Console.WriteLine("Введите число");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Quad(N);
// }
// catch
// {
//     Console.WriteLine("Число введено не верно");
// }

// //Задача 21 - HARD необязательная
// //Напишите программу, которая принимает на вход координаты двух точек и находит 
// //расстояние между ними в N-мерном пространстве. 
// //Сначала задается N с клавиатуры, потом задаются координаты точек.


void Distance(double[] arr1, double[] arr2, int n)
{
    double d = 0;
    for (int In = 0; In < n; In++)
    {
        d = d + (Math.Pow((arr1[In] - arr2[In]), 2));
    }
    double dis = Math.Sqrt(d);
    Console.WriteLine($"Расстояние между двумя точками равно {dis}");
}
void FirstKoord(double[] arrr1, int n1)
{
    Console.WriteLine("Введите координаты первой точки");
    for (int i = 0; i < n1; i++)
    {
        arrr1[i] = Convert.ToDouble(Console.ReadLine());
    }
}
void SecondKoord(Double[] arrr2, int n2)
{
    Console.WriteLine("Введите координаты второй точки");
    for (int j = 0; j < n2; j++)
    {
        arrr2[j] = Convert.ToDouble(Console.ReadLine());
    }
}
try
{
    Console.WriteLine("Введите размерность");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] array1 = new double[N];
    double[] array2 = new double[N];
    FirstKoord(array1, N);
    SecondKoord(array2, N);
    Distance(array1, array2, N);
}
catch
{
    Console.WriteLine("Что то пошло не так, проверьте правильность ввода координат");
}

//Задача 19 - HARD необязательная
//Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
//является ли оно палиндромом. Через строку нельзя решать само собой.
// int Razr(int n)
// {
//     int i = 1;
//     while (n > 10)
//     {
//         n=n / 10;
//         i++;
//     }
//     return i;
// }
// string Check(int num, int n)
// {
//     for (int i = 1; i <= n ; i++)
//     {   
//         int num1 = Convert.ToInt32(num / Math.Pow(10, n - 1));
//         if (num1 == num % 10)
//         {
//             num = Convert.ToInt32(num % Math.Pow(10, n - 1) / 10);
//             n=n-2;
//         }
//         else return ("Введенное число  не является палиндромом");
//     }
//     return ("Введенное число является палиндромом");
// }    
// try
// {
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int N = Razr(number);
// Console.WriteLine(Check(number,N));
// }
// catch
// {
//     Console.WriteLine("Что то пошло не так, проверьте число");
// }