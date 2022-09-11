// Задача 1: Программа запрашивает натуральное число M, 
// пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел будете вводить? ");
int a = int.Parse(Console.ReadLine());
int result=0;

for (int i=0;i<a;i++)
{
    Console.WriteLine("Введите число: ");
    int b= int.Parse(Console.ReadLine());
    if (b>0) {
        result=result+1;
    }
}
Console.WriteLine("Положительных чисел : " +result);
