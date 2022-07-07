/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();
for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(-100, 100);
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

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число элементов массива:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
            else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не натурально число. Введите корректное число элементов массива");
        }
    }

    return result;
}

int SummOddNumber(int [] arr)
{
    int Summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2!=0)
        Summ = Summ + arr[i];
    }
    return Summ;
}

int dimension = GetNumber();
int [] array = GetArray(dimension);
PrintArray(array);
int SummOdd = SummOddNumber (array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива стоящих на нечётных позициях = {SummOdd}");
