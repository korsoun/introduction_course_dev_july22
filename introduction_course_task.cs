// Контрольное задание.
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.

Console.WriteLine("Пожалуйста, введите элементы исходного массива через пробел.");
string[] generalArray = Console.ReadLine().Split().ToArray();

Console.WriteLine();
Console.Write("Искомый массив: ");
ArrayOutput(GetShortElementArray(generalArray));
