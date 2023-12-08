/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
string stringNumber = "Привет"; // Строчка - массив символов
Console.WriteLine(stringNumber[2]); и
*/
// "1234" - подходит, потому что состоит только из цифр
// "12Привет" - не подходит


Console.WriteLine("Enter the number: "); // Введите число
string stringNumber = Console.ReadLine();

// var stringNumber = "32679"; // var - ключевое слово, определяет тип данных
// var res = 100 / 458748 * 10.5;
int number; // Если строчка состоит только из чисел, то в переменную попадает наше число
// TryParse (строчка, out переменная) -- out переменная, сохраняем число
bool isNumber = int.TryParse (stringNumber, out number);
// isNumber = true, то строка состоит только из чисел, number = числу из строчки
// isNumber = false, то в строке присутствуют символы, number = 0
if (isNumber) // isNumber == true
{
    Console.WriteLine("The translation was successful, the line contains ONLY numbers");
    // Перевод прошел успешно, в строчке есть ТОЛЬКО цифры
    Console.WriteLine(number);
    if(stringNumber.Length >= 3)
    {
        Console.WriteLine("Third digit of the number: " + stringNumber[2]); 
        // Третья цифра числа
    }
    else
    {
        Console.WriteLine("There is NO third digit"); // Третьей цифры нет
    }
}
else // isNumber == false
{
    Console.WriteLine("Error! There are other characters in the line"); 
    // Ошибка! В строчке присутствуют другие символы
    Console.WriteLine(number);
}





