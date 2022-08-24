
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 5;
int a2 = 10;
int a3 = 50;
int b1 = 200;
int b2 = 100;
int b3 = 60;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(b1, b2, b3);
// int max = Max(max1, max2, 0);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), 0);
Console.WriteLine(max);
*/

/*
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggerDigit(int number) // void - если нет return
{
    int ed = number % 10;
    int dec = number / 10;
    int result;
    if (ed > dec) result = ed;
    else result = dec;

    return result;
}

int randNumber = new Random().Next(10, 100);
int result = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {result}");
*/
/*
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

string DelTwoNum(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int cot = number / 100;
    string res = Convert.ToString(cot) + Convert.ToString(ed);
    return (res);
}
int randNumber = new Random().Next(100, 1000);

string result = DelTwoNum(randNumber);
Console.WriteLine($"случайное тречзначное число {randNumber}, результат задачи {result}");
*/
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
void SecondMultipleFirst(int first, int second)
{
    int res = first % second;
    if (res == 0) Console.WriteLine($" Второе число {second} кратно первому {first}");
    else Console.WriteLine($"Остаток от деления равен {res}");
}

Console.WriteLine("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());


SecondMultipleFirst(first, second);
*/
/*
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
bool Multiple(int num, int a, int b)
{
    if (num / a == 0 & num / b == 0) return true;
    else return false;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Multiple(num, 7, 23);
Console.WriteLine(res);

*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void Scware(int a, int b)
{
    int res1 = a * a;
    int res2 = b * b;
    if (res1 == b ^ res2 == a) Console.WriteLine("yes");
    else Console.WriteLine("no");

}

Console.WriteLine("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Scware(first, second);