// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.Write("Ошибка ввода, повторите попытку");
    return;
}

int[] CreateArrayRndInt(int arrays)
{
    int[] array = new int[arrays];
    int i = 0;
    if (num <= 10)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    else
    {
        Console.WriteLine("Число элементов > 10, случайный метод заполнения:");
        while (i < num)
        {
            array[i] = new Random().Next(-100, 1000);
            i++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
}

int CountElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;

}

int[] arr = CreateArrayRndInt(num);
PrintArray(arr);
int countS = CountElem(arr);
Console.WriteLine($"Количество чисел больше 0 -> {countS}");