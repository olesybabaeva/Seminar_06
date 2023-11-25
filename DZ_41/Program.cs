// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: "); 
// задаем количество чисел в массиве
int size = Convert.ToInt32(Console.ReadLine()); 

int[] number = new int[size];
int PositiveNum = 0;

for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine($"Введите элемент массива {i}:\t");
    number[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Массив: [{String.Join(",", number)}]");

for (int i = 0; i < number.Length; i++)
{
    if(number[i] > 0)
    {
        PositiveNum++;
    }
}
Console.WriteLine($"Чисел больше 0: {PositiveNum}");