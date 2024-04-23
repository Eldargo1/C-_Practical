// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой
// гири.

int[] array = {2,10,7,3,9};
int i = 0;
int max = 0;
while(i < array.Length)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.Write(max);

//  выполнил задание с циколм for
// int[] array = {2,10,7,3,9};
// int max = array[0];
// for(int j = 0; j < array.Length; j = j + 1)
// {
//     if(array[j] > max)
//     {
//         max = array[j];
//     }
// }
// Console.Write(max);


//  выполнил задание с циколм foreach
// int[] array = {2,10,7,3,9};
// int max = array[0];
// foreach(int e  in array)
// {
//     if(e > max)
//     {
//         max = e;
//     }
// }
// Console.Write(max);

// Сделал для себя взял радномное число 
// массива и на каждый индекс массива поставил 
// радномное число

// int N = new Random().Next(1,10);
// Console.WriteLine(N);
// int [] array = new int [N]; //10
// int i = 0;
// // int max = 0;
// while(i < array.Length)
// {
//    if(array[i] == 0)
//     {
//         int RNum = new Random().Next(10,90);
//         array[i] = RNum;
//         Console.Write(array[i]+ " ");
//     }
//     i = i + 1;
// }


// Сделал для себя взял радномное число гирь 
// и на каждый гире обозначил  рандомную массу гири
// и нашел какая из них тяжолая

// int N = new Random().Next(1,10);
// Console.WriteLine(N);
// int [] array = new int [N]; //10
// int i = 0;
// // int max = 0;
// while(i < array.Length)
// {
//    if(array[i] == 0)
//     {
//         int RNum = new Random().Next(10,90);
//         array[i] = RNum;
//         Console.Write(array[i]+ " ");
//     }
//     i = i + 1;
// }
// int index = 0;
// int max = 0;
// while(index < array.Length)
// {
//     if(array[index] > max)
//     {
//         max = array[index];
//         Console.WriteLine();
//     }
//     index = index + 1;
// }

// Console.WriteLine(max);