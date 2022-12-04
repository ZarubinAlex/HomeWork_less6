// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return double.Parse(Console.ReadLine());
}

double[] CalculationXY(double b1, double k1, double b2, double k2){

    double[] arr = new double[3];

    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;

    if(k1-k2 == 0 || k1*arr[0] + b1 != k2*arr[0] + b2) arr[2] = -1;// третий элемент - сообщение об ошибке
    return arr;
}


Console.Clear();
double b1 = InputInt("b1");
double k1 = InputInt("k1");
double b2 = InputInt("b2");
double k2 = InputInt("k2");

Console.WriteLine();
double[] arrXY = CalculationXY(b1,k1,b2,k2);

if(arrXY[2] == -1) 
    Console.WriteLine("Нет решения");
else{
    Console.WriteLine($"X: {arrXY[0]}, Y: {arrXY[1]}");
    Console.WriteLine();
}