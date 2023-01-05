// Написать программу, которая их имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

string[] array1 = {"world", "-3", "add", "good", "monday"};
string[] array2 = new string[array1.Length];

NewMassiv(array1, array2);
PrintArray(array1);
Console.Write("-> "); 
PrintArray(array2);

void NewMassiv(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if (array1[i].Length < 4)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}
