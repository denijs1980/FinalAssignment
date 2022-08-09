// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string [] startingArray = new string[] {"piece", "chunk", "8", "***"};
string[] resultArray = new string [0];

foreach (var item in startingArray)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref resultArray, resultArray.Length + 1);
    resultArray [resultArray.Length-1] = item;
    }
}

Console.WriteLine($"[{String.Join("; ", resultArray)}]");