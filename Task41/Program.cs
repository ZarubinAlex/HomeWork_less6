// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string letter){

    Console.Write($"Введите количество чисел, {letter}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetFillArray(int size){

    int[] arr = new int[size];

    for (int i=0; i < arr.Length; i++){

        Console.Write($"Число {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int positivInArray(int[] arr){

    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count++;
    }

    return count;
}


void PrintArray(int[] arr){

    Console.WriteLine(string.Join(", ", arr));
}


Console.Clear();
int m = InputInt("M");
int[] arr = GetFillArray(m);
//PrintArray(arr);
Console.WriteLine();
System.Console.WriteLine($"Количество чисел больше нуля: {positivInArray(arr)}");

