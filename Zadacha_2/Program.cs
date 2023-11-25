// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с 
// сторонами такой длины.Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

// int a = 3;
// int b = 4;
// int c = 5;
// // IsTriangle - "это треугольник?"
// bool IsTriangle(int a, int b, int c)
// {
//     // 7>5 && 8>4 && 9>3 - тр. существует 
//     return ((a + b) > c && (a + c) > b && (b + c) > a);
// }
// if (IsTriangle(a, b, c)) // IsTriangle(a, b, c) == true
// {
//     Console.WriteLine("Треугольник СУЩЕСТВУЕТ");
// }
// else
// {
//     Console.WriteLine("Треугольник НЕ СУЩЕСТВУЕТ");
// }

// ______________________________________________

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Write("Введите количество чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
{
    return;
}
int[] resArray = GetFibonacciArray(N);
PrintArray(resArray);
int[] GetFibonacciArray(int size)
{
    int[] array = new int[size]; // [0,0...0]
    array[0] = 0;
    array[1] = 1; // 2 - номер элемента
    // index = i
    for (int index = 2; index < size; index++)
    {
        array[index] = array[index - 1] + array[index - 2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"Массив: [{String.Join("; ", arr)}]");
}
