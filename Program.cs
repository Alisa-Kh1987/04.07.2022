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

//создание случайного массива через инт
//int[] CreateArray()
//{
//    Console.WriteLine("Введите количество элементов массива");
//    int size = Convert.ToInt32(Console.ReadLine());
//    int[] RandomArray = new int[size];
//    for (int i = 0; i < size; i++)
//    {   
 //       Console.WriteLine($"Введите {i+1} элемент массива");
//        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//void ShowArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//}
//Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);


