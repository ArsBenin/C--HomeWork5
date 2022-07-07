/*
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();
for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(100, 999);
}

return arr;
}
void PrintArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}

int EvenNumber(int[] arr)
{
int ammount = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2==0)
    ammount++;
}

return ammount;
}


Console.WriteLine("Введите размерность массива");
int dimension = int.Parse(Console.ReadLine());
int [] array = GetArray(dimension);
PrintArray(array);
int Even = EvenNumber(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в заданном массиве = {Even}");
