   
Console.WriteLine("Из введенного пользователем массива строк сформируем массив из строк, длина которых меньше либо равна 3 символа");
Console.WriteLine();
int UserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}

int lenghtArray = UserData("Укажите количество элементов-строк в массиве: ");
Console.WriteLine();

Console.WriteLine();
string[] inputArray = new string[lenghtArray];

FillArray(inputArray);
Console.WriteLine("Первоначальный массив:");

PrintArray(inputArray);

int resultArrayLenght = FinalArrayLen(inputArray);
string[] resultArray = new string[resultArrayLenght];
int counter = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] != string.Empty)
    {
        resultArray[counter] = inputArray[i];
        counter++;
    }
}
Console.WriteLine();
Console.WriteLine("Итоговый массив:");

PrintArray(resultArray);

int FinalArrayLen(string[] array)
{
    int wordLen = 3;
    int counter = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > wordLen)
        {
            array[i] = string.Empty;
            counter--;
        }
    }
    return counter;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Задайте {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
} 