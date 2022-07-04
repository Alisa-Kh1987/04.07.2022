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

//с использованием метода
int sum_numbers(int num)
{
    int sum = 0;
    for ( int i = 1; i <= num; i++)
    {
    sum = sum + i;
    }
    return sum;
}
    for ( int i = 1; i <= 5; i++)
{
Console.WriteLine ("Input N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(N + "->" + sum_numbers(N));
}