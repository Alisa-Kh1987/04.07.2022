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
//int[] CreateRandomArray(int min, int max) // если в скобках прописать int N - количество элементов, min и max - минимум и максимум массива
//{
//    int [] RandomArray = new int [8]; //создание массива и указание его размерности (8-размерность)
//    for (int i = 0; i < 8; i++)
//        {   
//            RandomArray [i] = new Random().Next(min, max + 1); //обращ к массиву RA с индексом i (та ячейка, в которую мы кладем значение (РАНДОМНОЕ!!!))
//            Console.Write(RandomArray[i] + ", "); //выводим на экран случайно сгенерированные 8 чисел
//        }
//        return RandomArray;
//}
////вывод на экран (= на печать) массива
//void ShowArray(int[] array)
//{   Console.Write(" -> ["); //оформляем массив [скобками
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + ", ");
//    }
//    Console.Write("]"); //завершаем оформление скобками]
//    Console.WriteLine();
//}
//Console.Clear();  //чтобы автоматически при запуске программы консоль очищалась
///основная программа

//Console.WriteLine("Введите первое число случайно генерируемого диапазона");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
//int max = Convert.ToInt32(Console.ReadLine());
//    //сохраняем в новый массив
//int[] myRandomArray = CreateRandomArray(min, max);
//сюда отправляем, чтобы вывести на экран
//ShowArray(myRandomArray);


//Практическое задание r семинару 4.

//Задача № 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Console.WriteLine("Input A: ");
//    int A = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Input B: ");
//    int B = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//    while (i<B)
//        {i=i+1;
//        }
//    Console.WriteLine(Math.Pow(A,i));

//Задача № 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Console.WriteLine("Input N: ");
//int N = Convert.ToInt32 (Console.ReadLine ());
//int sum = 0;
//while (N!=0) {
//    int a = N % 10;
//    sum = sum + a;
//    N = N / 10;
//    }
//Console.WriteLine(sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//int[] CreateRandomArray(int min, int max)
//{
//    int [] RandomArray = new int [8];
//    for (int i = 0; i < 8; i++)
//        {   
//            RandomArray [i] = new Random().Next(min, max + 1); 
//            Console.Write(RandomArray[i] + ", ");
//        }
//        return RandomArray;
//}

//void ShowArray(int[] array)
//{   Console.Write(" -> ["); 
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + ", ");
//    }
//    Console.Write("]"); //завершаем оформление скобками]
//    Console.WriteLine();
//}
//Console.Clear();

//Console.WriteLine("Введите первое число случайно генерируемого диапазона");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
//int max = Convert.ToInt32(Console.ReadLine());
   
//int[] myRandomArray = CreateRandomArray(min, max);
//ShowArray(myRandomArray);