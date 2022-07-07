//Console.WriteLine("Ввод числа N");
//int N = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for ( int i = 1; i <= N; i++)
//{
//    sum = sum + i;
//}
//Console.WriteLine(sum);

//c while
//Console.WriteLine("Ввод числа N");
//int N = Convert.ToInt32(Console.ReadLine());
//int sum = 1;
//int i = 0;
//while (i <= N)
//{
//    sum = sum + i;
//    i+=1;
//}
 //   Console.WriteLine(sum);

//с использованием метода int
//int sum_numbers(int num)
//{
//    int sum = 0;
//    for ( int i = 1; i <= num; i++)
//    {
//    sum = sum + i;
 //   }
 //   return sum;
//}
//    for ( int i = 1; i <= 5; i++)
//{
//Console.WriteLine ("Input N");
//int N = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(N + "->" + sum_numbers(N));
//}

//void sum_numbers(int num)
//{
 //   int sum = 0;
 //   for ( int i = 1; i <= num; i++)
 //   {
 //   sum = sum + i;
 //   }
 //   Console.WriteLine(num + "->" + sum);
//}
//    for (int i = 1; i <= 5; i++)
//{
//Console.WriteLine ("Input N");
//int N = Convert.ToInt32(Console.ReadLine());
//sum_numbers(N);
//}

//создание случайного массива
int[] CreateRandomArray(int N, int start, int end) //N - количество элементов, старт и энд - минимум и максимум массива
{
    int [] RandomArray = new int [N];
        for (int i = 0; i < N; i++)
        {   
            RandomArray [i] = new Random().Next(start, end + 1);
        }
        return RandomArray;
}
//вывод на экран массива
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Clear();  //чтобы автоматически при запуске программы консоль очищалась
///основная программа
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());
    //сохраняем в новый массив
int[] myRandomArray = CreateRandomArray(num, min, max);
//сюда отправляем, чтобы вывести на экран
ShowArray(myRandomArray);




