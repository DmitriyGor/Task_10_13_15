/* 
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
Random rnd = new Random(); 
int rndNum = rnd.Next(100, 1000); // 100 - 999
Console.WriteLine("random number from a segment 100 - 999:  " + rndNum); // случайное число из сегмента 100 - 999
*/

Console.Write ("Enter a three-digit number:  "); // Введите трехзначное число
int Number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 = int.Parse
int A = Number % 100 / 10; // 234

Console.WriteLine("in " + Number + " the second digit: "   + A );
