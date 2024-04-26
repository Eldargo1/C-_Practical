// Вывода на экран квадратов чисел от 1 до N

// void PrinSquares(int limit)
// {
//     int i = 0;
//     while(i > n)
//     {
//         Console.WriteLine($"{i*i} ");
//     }
// }

// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);

void PrintSquares(int limit)
{
    int i = 1;
    while(i < limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}


PrintSquares(5);
PrintSquares(10);
PrintSquares(15);