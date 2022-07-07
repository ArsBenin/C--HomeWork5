/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/

// Метод ввод массива массива
double [] GetArray(int dimension)
{
double[] arr = new double[dimension];
for(int i=0; i < arr.Length; i++)
{  
   arr[i]= GetNumberElements();
}
return arr;
}
// Метод вывод массива
void PrintArray(double [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}
// Метод проверки ввода числа элементов массива
int GetNumberDemension()
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

// Метод проверки ввода чисел элементов массива
double GetNumberElements()
{
    double result = 0;
    Console.WriteLine("Введите элемент массива:");
    while(true)
    {
        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
            else
        {
            Console.WriteLine("Вы ввели не число. Введите элемент массива'");
        }
    }

    return result;
}

// Метод нахождения максимального элемента
double MaxNumb (double [] arr)
{
    double MaxNumber = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (MaxNumber < arr[i])
    MaxNumber = arr[i];
}
return MaxNumber;
}
// Метод нахождения минимального элемента
double MinNumb (double [] arr)
{
    double MinNumber = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (MinNumber> arr[i])
    MinNumber = arr[i];
}
return MinNumber;
}


int dimension = GetNumberDemension();
double [] array = GetArray(dimension);
Console.WriteLine();
PrintArray(array);
double MinElement = MinNumb (array);
double MaxElement = MaxNumb (array);
double Difference = MaxElement-MinElement;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным элементом массива {MaxElement} и минимальным элементов массива {MinElement} = {Difference}");
