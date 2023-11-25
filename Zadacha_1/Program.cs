// Задача 37. Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний элемент, второй
// и предпоследний и тд. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, 0, 10);
PrintArray(array); // Тут ДО "void-a": ориг. массив
Console.WriteLine("Результат через копирование массива: ");
PrintArray(CopyArray(array));
Console.WriteLine("Результат через изменение искомого массива: ");
ReverseArray(array);
PrintArray(array); // Тут после "void-a": перевернутый 
// PrintArray(GetMultiplyArray(array));
// Массив на size элементов, элемент - число от 0 до 10 вкл.
int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        // Next(0,2) => 0, 1
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"Массив: [{String.Join("; ", arr)}]");
}

// 1 способ "поворота": создать копию массива,
// копия массива = перевернутый "оригинальный массив"

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];  // copy = [0,0]
    // Размер копии = размеру оригинала
    // i - индекс "первого" эл. для нового массива copy
    // j - индекс посл. эл. из старого массива array
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        copy[i] = array[j];
        // array = [10,20]
        // copy[0] = array[1]; copy = [20,0], array[1]=20
        // i++(1), j-- (0)
        // copy[1] = array[0]; copy = [20,10], array[0]=10
    }
    return copy;
}

// 2 способ: "поворот" массива без создания доп. массивов 
void ReverseArray(int[] arr)
{
    for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        int temp = arr[i]; // arr[0], [1,2,3,4,5], temp = 1
        arr[i] = arr[j]; // arr[0] = arr[j], 
        // первый элемент = последнему: [5,2,3,4,5]
        arr[j] = temp; // [5,2,3,4,temp], temp = 1
        // [5,2,3,4,1]
    }
}

int[] GetMultiplyArray(int[] arr)
{
    int newSize = arr.Length / 2 + arr.Length % 2;
    int[] newArray = new int[newSize];
    for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        newArray[i] = arr[i] * arr[j];
    }
    // Решаем проблему с "серединкой"(3): [1,2,3,4,5]
    // newArray = [5, 8, 0](3 должна быть) 
    if (arr.Length % 2 == 1) // размер массива - нечетное число?
    {
        newArray[newArray.Length - 1] = arr[arr.Length / 2];
        // arr = [1,2,3,4,5], arr[2] = 3
        // newArray[2] = arr[2], [5, 8, 3]
    }
    return newArray;
}




