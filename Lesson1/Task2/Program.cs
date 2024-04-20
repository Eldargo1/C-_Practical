// Пример 2. Создать целочисленный и вещественные переменные.Вычислить их сумму, произведение,частное.Результаты вывести на экран.
int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);

long l1 = 6;
long sum2 = i1+ l1;
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = i1 + d1;
Console.WriteLine(sum3);

int product1 = i1 * i2; // product  с англиского произведение . * - это умножение 
long product2 = i1 * l1;
double product3 = i1 * d1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);


int quotient1 = i1 / i2; // quotiont  с ангиского - часть. / - это деление
Console.WriteLine(quotient1); // тут получем резултат оно равно = 0. Однакого должно быть при  делений 0.8.это из за того что целый тип данных не пред полагает хранение дробной части.

// для хранение дробной части необходимо хотя бы 1 из аперантов имел вещественный тип(float ил double)

d1 = 6;
double quotient2 = i1 / d1;
Console.WriteLine(quotient2);