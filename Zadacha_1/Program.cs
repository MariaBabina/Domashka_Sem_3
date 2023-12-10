//  Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [20,90].Пример массив [10 21 14 93 23] => 2

int [] array = new int [10];
Random random = new Random(); 
for (int i = 0; i < array.Length; i++)
{
    array [i] = random.Next (0,101);
    System.Console.Write(array[i]+" ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] >= 20 && array[i] <= 90)
    {
        count++;
    } 
}
Console.WriteLine(count);

