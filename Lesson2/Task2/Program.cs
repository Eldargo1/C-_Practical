// Создать массив и заполнить его целыми
// числами от 1 до N (N – произвольное
// натуральное число). Вывести элементы
// массива на экран.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int i=0;
// while(i < N)
while(i < array.Length)
{
    array[i] = i + 1;
    Console.Write(array[i]+ " ");
    i = i + 1;
}
//  сам выполнил задание с рандомным числом

// int N = new Random().Next(10,90);
// Console.WriteLine(N);
// int [] array = new int [N];
// int i = 0;
// while(i < array.Length)
// {
//     array[i]= i +1;
//     Console.Write(array[i]+ " ");
//     i = i + 1;
// }
