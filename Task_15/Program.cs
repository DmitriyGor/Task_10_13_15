/* 
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Enter a number indicating the day of the week:  "); 
// Введите цифру, обозначающую день недели

int dayOfTheWeek = Convert.ToInt32(Console.ReadLine ());

if  (dayOfTheWeek <= 7)
    {
        if  (dayOfTheWeek <= 5)
        {
            Console.WriteLine(dayOfTheWeek + " - working day");  //  рабочий день
        }
        else
        {
            Console.WriteLine(dayOfTheWeek + " - weekend");  // выходной
        }
    }
else
    {
        Console.WriteLine("the number is entered incorrectly, days of the week ONLY 1 - 7 "); 
        // цифра введена неверно, дни недели ТОЛЬКО 1 - 7
    }
   