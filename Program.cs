// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел M: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];                        //создание пустого массива заданного размера
Num(size);
int cou = CountNum(array);
Console.WriteLine($"Введено чисел больше 0: {cou} ");

int CountNum(int[] array){
    int count = 0;                          //функция подсчета значений >0
    for (int i = 0; i < size; i++)
    {
       if(array[i] > 0) count += 1;
    }
    return count;
}

void Num(int size){                         //функция ввода чисел и заполнение ими пустого массива
    for (int i = 0; i < size; i++)
    {
       Console.Write($"Введите {i+1} число: ");
       array[i] = Convert.ToInt32(Console.ReadLine());
    }
}



// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Cross(double b1, double k1, double b2, double k2){        //функция вычисления координат точки пересечения
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    if(k1 == k2 ) Console.WriteLine("Прямые параллельны");
    else{
        Console.Write($"Точка пересечения прямых ({x};{y})");
    }
}

Console.Write("Введите b1: ");                          //ввод данных
int b1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine()); 
Cross(b1, k1, b2, k2);