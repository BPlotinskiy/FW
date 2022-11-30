// Написать программу, которая из имеющегося массивастрок формирует массив из строк, длина которых меньше либо равна 3 символа.


string[] array = {"helloy", "2", "world", "11", "/'"};
var newArray = new string[array.Length];
var Size = 0;

foreach (var value in array)
{
    if (value.Length <= 3)
    {
        newArray[Size] = value;
        Size++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, newArray, 0, Size));