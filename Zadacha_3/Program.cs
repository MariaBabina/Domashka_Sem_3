// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива. 
//массив [2.2 0.4 9.11 7.2 78.98] => 78.58 массив [1.22 4.5 3.33] => 3.28
 
Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];
Random random = new Random(); //создаем объект типа Random с именем random,
// который можно использовать для генерации случайных чисел.

for (int i = 0; i < array.Length; i++)
{ 
    double randomValue = Math.Round(random.NextDouble() * 100,2);
    // Генерируем вещественное число с ненулевой дробной частью
    
    while (randomValue % 1 == 0) // Проверяем, что дробная часть не равна нулю
    {
        randomValue = Math.Round(random.NextDouble() * 100,2);
    }
    array[i] = randomValue;
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++) 
{
    if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
    
}
double diff = Math.Round(max-min,2);
Console.WriteLine(diff);
