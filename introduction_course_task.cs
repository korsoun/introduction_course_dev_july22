// Контрольное задание.
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.

Console.WriteLine("Пожалуйста, введите элементы исходного массива через пробел.");
string[] generalArray = Console.ReadLine().Split().ToArray();

Console.WriteLine();
Console.Write("Искомый массив с элементами длиной не более 3-х символов: ");
ArrayOutput(GetShortElementArray(generalArray));

string[] GetShortElementArray(string[] primaryArray)
{
    string shortElements = String.Empty;
    for (int i = 0; i < primaryArray.Length; i++)
    {
        if (primaryArray[i].Length < 4) shortElements = $"{shortElements}{primaryArray[i]} ";
    }
    shortElements = shortElements.Trim();
    string[] shortElementsArray = shortElements.Split().ToArray();
    return shortElementsArray;
}

void ArrayOutput(string[] outputingArray)
{
    Console.Write("[");
    for (int i = 0; i < outputingArray.Length - 1; i++)
    {
        Console.Write($"{outputingArray[i]} ");
    }
    Console.Write($"{outputingArray[outputingArray.Length - 1]}]");
}