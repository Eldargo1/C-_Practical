# Записи с 1-го уроко лекций.
## Введение. Знакомство с языками программирование.
### Cоздание переменных
* Для создание переменных состоит из 3 этапов Например :
```sh
int value = 100;
```
```sh
int -это типа данных 
```
```sh
value - это имя переменной(идентификатор).На идентификатор накладывается ошроничение оно не должна начинатся с цифр, должно состоят из латинских букв, а также может начинатся с символов подчеркивание. 
```
```sh
100- это иницелизация, то есть присвоения переменной определенного значения.
```
```sh
Console.WriteLine()
```
* пишеться для вывода информаций на экран на языке С# 
Этот метод вывода выводит цифры друг под другом.
Если хотите вывести числа в строку используйте метод 
```sh
Console.Write()
```
```sh
// использцется для отключение кодов либо для коментарий в кодирований
```
### Основные типы данных на языке С#
```sh
Целые число(целочисенные)- Int либо long.Long позволяет хранить числа большего размера чем int
```
```sh
Вещественный тип - float или double. Позволяет хнарить дробные числа. double позволяет хранить числа большего размера чем float.
```
```sh
Символьный тип данных - char(character).Исользуется для хранение отдельных символов (цифры, Лат буквы, спец символы и.т.д) Переменные типа "char" ее занчение хранатся в одинарных ковычках например: char c = '!';
```
```sh
Строчный тип данных - string. Мы можем хранить какую то строчку например : string y = "Hello World".
```
```sh
Логический типа данных - bool.Позволяет сохранить всего лишь два занчение либо логическую истену (True) либо же логическое ложное значение (False).
```
### Если в сложений или в умножений либо в других вычеслительных операций 2 разные типа данных
Например :
```sh
int a = 5;
int b = 7;
?(что тут должно быть int ? double и.т.д)sum = a+b
```
 Какой типа данных должно быть у переменной sum ?
* Сложение, деление и.т.д это бинарная операция то есть в ней принимает участия 2 аперанта в данны случаее в ней принимает участие первое слагаемое (а) и аторое (b) дело в том что тип данных у этой операция сложений будет формироваться на основе типа данных аперантов, первого аперанта и второго.Если типа данных у аперантов совпадают то в этом случаее типа данных у результате (sum) будет совпадать с типам данных эти аперантов.В нашем случае аперанты (а)и (b) имеют тип данных int .По этому тип данных у переменной (sum) то есть урезультата у этого сложение будет int то есть она будет целочисленное. 
* 2 - ое правила.
Если типа данных у аперантов которые участвуют в бинарной операций разные то в этом случаее типа данных у результата будет формироваться как наеболее обьемный или наеболее вмистительный тип. Другими словами если участвует типа данных в операция (long) и (int) то тип данных у резльтата будет (long) поскольку диапозон значений у типа данных (long) значительно шире в разы больше нежели у (int).(Смотреть пример в папке Task1)

### Синтаксисы языка С#
```sh
if- для выполнение операция сравнение исользуется  этот оператор.После оператора (if)  в крушлых скобках (например (a>b) ) мы указываем условия.
```
```sh 
после конструкций if и после самого условия, если это условие верное,  в фигурных скобках ({}) мы указываем код который будет выполнен.
Если же это условие не верно код который содветсвует этой ветви выполнения размещаем после ключевого слово (else), помещаем его также в фигурных скобках ({}).(Смотреть пример в папке Task3)
```

### Цикл
```sh
Для создание цикла в большинство языках програмирование используется  оператор (While).После в фигурных скобках ({}) мы указываем тело цикла то есть те операция которые будут выполнятся на каждом повторения этого цикла.(Пример смотреть в Папке Task5)
```

# Запись с 2 - го урока лекции.
## Массивы.
* Массив - это структура данных хранящая набор однотипных элементов идентифицируемых по индексу.
* Масив может состоят из целых чисел, вещественных, может состоять из символов, а также из строк.
* Индекс элемента в массиве - это позтцтя элемента в массиве (Простым языком).
* Массив имеет имя - с помощью имени мы осуществляем обррощение к элементам массива.Если нам нужно изменить элмент или же просто прочитать то мы исполбзуем операцию оброщение к элементам по индексу.Например :
```sh
 array(это имя массива)[2]- квадратные скобки это оброщение к этому элменту 
```
* В языке С# создание массива состоит из 3 эатапов пример:
```sh
int[] array = new int [5];
```
* 1 этап - это указание типа данных для элемента массива пример :
```sh
int[] - также вместо int может быть (float,double и.т.д). Квадратные скобки ставится для указание того что создается массив а не обычное переменное
```
* 2- ой этап - это указание идентификатора пример:
```sh
array - то есть имя массива 
```
* 3 - й этап - это выделение памяти от элмента массива.
```sh
new int[5]- используем оператор "new" который нам выделит фрагмент памяти для хранение будщих элементов
```
* и еще есть 4-ый этап он заключается в связываний участков памяти который мы выделили с помощью опратора "new"  с именем массива с помощью оператора присваевание то есть "=" пример :
```sh
int array[] = new int[5]; 
```
* в языке С# элементы при созданий массива имеют значение по умолчанию если это числовой массив типа "int"  "long" то элментами являются нули.
```sh
int array[] = new int[5]; - в этом случаее в массиве 5 элментов с числовым значением 0
```
* Индексация в массиве начинается с 0

* теперь заполним массив произвольными целыми числами для измение элментов массива мы используем оператор индексаций то есть оброщяемся к элменту по его индкусц пример :
```sh
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
arr[3] = 4;
arr[4] = 5;
```

* Способ заполнение массива сразу же при ее созданий пример :
```sh
int[] arr = new int[5]{1,2,3,4,5}
```
* А также (в некоторых случаех) в C# можно использовать упрощенный синтаксис для создание массива пример:
```sh
int[] arr = {1,2,3,4,5} 
```
* в этом случаее команду "new " а нвыделение памяти можем не использовать по скольку число элментов у нас фиксировано и мы их указывваем сразу после создание массива. Способ удобный для создание не ольшых массивов когда зарнее известны их элементы.
* Смотреть пример в папке Lesson2 => Task2
* В место использования перменной (Смотреть в папке Lesson2 => Task2) которая хранить количество элементов массива мы можем воспользоваться своиством массива пример:
```sh
int[] array = new int[N];
int i=0;
while(i < N)
можно сделать
while(i < array.length)
```
с перва оброщаемся массиву по  его имени в данном случаее "array" и используем оператор "length" - то есть длина массива

* Если при запуске программы пройзошла ошибка и программа зацыклилась или выводит бесконечное число можно остоновить нажатием горячей клавишей
```sh
"Ctrl" + C
```
### Разновидность циколв
* Счетный цикл
* ДЛя создание счетного цикла используется (ключевое слово)команда "for"
но в отличий от цикла "while" где в круглых скобках мы указываем только условие, в цикле  "for"  указывается создание переменные счетчика(i<10) и изминение этой переменной то есть ее модефикация(i = i +1) пример:
```sh
for(int i = 0; i < 10; i = i + 1)
```
* Более подробное составные части цикла "for"
```sh
for(int = 0)- блок инициализация тут создается переменная счетчика и присвоение ей некторого началного значение 
2-ой блок условия
i < 10; - под условием мы понимаем выражение логического типа на оснований которого можем сказать верно оно или нет
3-й блок модификация 
i = i + 1 - модификация то есть изменение переменной счетчик
```
* Рекомендаций к выбарам цикла
* Цикл "for" часто используется когда требуется перебрать элементы массива вывод на экран или же подсчет сум, подсчет среднего арефметического ил посик элементов по каким либо критерием так цикл может использоваться когда нам известно верхняя граница числа итераций так же цикл может приминятся когда верхняя граница итераций фиксирована и известна до запуска программы 
* Цикл Foreach
 ```sh
foreach(int e in array)
 ```
 ```sh
ine e - переменная цикла
in array - массив 
 ```
 * Работает цикл следующим оброзом на каждый итераций в перемнную цикла "int e"помещается если точнее копируется очередной эл массива то есть на первой итераций переменную "int e" попадает 1-ый эл массива во второ итераций 2-ой элемент массива и.т.д пока все элементы массива не будут перебраны .Этот цикл работает практический как цикл "for" только в нем не используется индекс.
 * Отличие цикла "foreach" от цикла "for" ключевое отличие заключается в том что элементы  в цикле "foreach" они доступны только на чтение то есть нет возможности их изминять достигается это за счет того что элементы массива каждый раз копируется в переменную цикла.В цикле можно вывести элементы на экран почитать их сумму или среднее арефметическое кроме этого цикл предоставляет нам осуществить пойск каких либо элементов.
 ## Запись с 3-го урока.Функция
 *  Функция - блок кода,  который предназначен для решений конткретных задач
 * Функция может имеет некоторые входные данных из называют - параметрами
 * Также функция могут возвращят значение
 * Составные части функции
 ```sh
 int Square(int value)
 {
    int result = value * value;
    return result;
 }
 ```
* 1-ый элемент это имя функций
```sh
int Square (Square с переводе на англиский возвестив квадрат)
```
* 2-ой элемент параметры функций они указываются в круглых скобках () после имени.Параметр состоит из типа данных в данном случаее целочисленный тип(int) и имени. Это может быть целочисленное, весщественных типов , символа или даже массив.
Параметры это некоторые данные из вне то есть из внешнего окружение которая функция получает для своей работы.Параметр может быть один как на примере а может быть и несколько .Обрати внимание если парметров у нас более одного то пары тип данных и имя разделяются запятой.Параметры могут отсуствовать в этом случаее мы указываем пустые круглые скобки 
```sh
1-int Square(int value)
2-int Square(int value, int value2)
3-int Square(int value)
```
* 3-й элемент. Это тип возвращаемого значений. Функция может возвращять целое число или значение любого из известного нам типов данных.Для возврата значений используется оператор (return). После которого мы указываем переменную или значение в явном виде в данном примере мы возвращяем конкретную переменную 
```sh
int Square(int value) (int это тип  возвращаемого  значение)
 {
    int result = value * value;
    return result;(Return это команда возврата значений)
 }
```
* каким оброзом и куда происходит возврат значение мы расмотрим далее в примере
```sh
void ShowSquare(int value)
{
    int value = value * value;
    Console.WriteLine(result);
}
```
* В случаее если функция ничего не возвращает мы указываем тип данных (void) с англиского переводится пустота то есть пустой тип данных он указывается в том случаее если функция возвращаемого значение не имеет 
* в этом случаее оператор return может использоваться для завершение функций в этом случаее он будет указыватся без каких либо возвращаемых значений то есть после return мы не будем писать имя перемнной или же значений в явном виде в данной функций просто выводится на экран значение перемнной параметры которого была возведена в квадрат
* в зависимости имеет ли функция входные параметры а также возвращает что то функуию можно разделить на 4 группы
*1 группа функций без параметров функция может не иметь не входных параметров не возвращаемого значений пример
```sh
void ShowHelloMessage()
{
Console.WriteLine("Hello world")"
}
```

* 2-ая група функций без параметров но с возвращаемым значением
```sh
double GetPi()
{
return 3.14159
}
```
* 3 группа с параметрами без возвращаемого значения
```sh
void ShowMessage(string message)
{
    Console.WriteLine("Hello World");
}
```
*  4 группа с параметрами с возвращаемым значение
```sh
int AddValues(int a, int b)
{
    int result = a+b;
    return result;
}
```
* Синтексис запуска вызова функций следущее указывается имя функций нашим случаее это (CalculateFormula) и в круглых скобках передаем ей необходимый аргумент , если функция не имеет входных параметров то в этом случаее запуск ббуде следущее просто указание пустых круглых скобок. Когда мы функцию запускаем и передаем что то мы используем термин аргумент если мы функцию создаем то есть пишем ее определение в этом случаее мы будем использовать термин параметры 

```sh
 1 - CalculateFormula(1,2,3,4);
 2 - CalculateFormula();
```
* в каких случаех используется функция ?
* 1  пункт это возможность групировать логический связанные блоки кода в функций . Нпаример если у нас имеется фрагмент кода в котором осуществляется создание массива ввывод его элементов на экран и вычесление среднего аревмитического то 3 этих врагмента кода могут быть описаны в виде функций таким оброзом мы можем структурировать нашу программу 
* 2 -ой этап. По сути является следствием первого. То есть вазможность выделять логические блоки в коде позволяет нам разбивать задачу на некторые этапы и оформлять их в виде функций.Если выделенный этап оказалься достаточно сложным то и он в свою очередь может быть разбит на под этап.
* 3 и этап Упрощают повтрное использование кода
* 4- ый этап Позволяет сокращать код
* 5 -ый этап Повышает читаемость кода
* Что код грамотно офрмленный в виде функций может быть перенесён в друние прожкты
* А что такое грамотное оформление функций ?
* она сотоит из несокльких пунктов это
```sh
Понятное и точное наименование функций
Правильное подобранные  количество и типов параметров
Правильно выбранный типа возвращаемого значения 
Качественно написанное тело функции
```
* Способы передачи параматров в функию
* 1 -ый способ передача по значению
* Мы ее использовали ее для вывода элементов на экран с помощью консола (Console.Write, Console.WriteLine) так же мы ее испольщзовали на этом уроке при разработке функций когда мы передавали параметры в функций или одиночные переменные мы передавли их по значению. ТО есть это в полне нзнакомый  и обычный способ передачи параметров функций только она имеет название по значению.
Это способ используется по умолчанию если работаем со значимыми типами данных (int, long, float, double, char, bool) и передаем  их в функции 
Значемый типа перевод с англиского термина Value type.Суть его заключается в том что в переменный хранится именно значение определенного типа 
```sh
double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);
```
* Важная особенность которая следует учитовать при передачи параметров в функцию по значению. Дело в том что переменная которая передается в функию по значению не может быть в этой функции изменена это является следствием того что переменная перадается с помощбю копирование то есть тот аргумент который передается при вызове он по факту копируется в параметр.

Смотреть пример в папке Lesson3=> Task1

* 2 -ой Переадча по ссылке
* Можно ли изминить аргумент который передается в функцию ? Можно . это делается с помощью передачи парамтров по ссылке.В случаее когда мы передаем в функцию не значемый типа данных а ссылочные то такой способ передачи передатся автомтический.Ссылочные типа данных  в отличие от значемых хранят адресс обьектов памяти то есть они как бы ссылаются на этот обьект памяти .Один из нам знакомых типов данных это массив.Массив передается в функцию именно по ссылке что элементы массива который будут переданные в функцию могут быть в ней изменены.
* C# позволяет передавать значимые типа данных по ссылке (int, double, float , long, char) можно передать по ссылке.Но это делается с помощью ключевого слово (ref)(Нужно посмотреть на youtube).Такое тоже можно встретить на других языках С, С++ ипользуется передача параматроа по значению по ссылке и по указателю.

## Запись с 4-го урока.Двумерные массивы.Строки.
* Двумерные массивы - массив, элементами которого являются одномерные массивы одинакового размера.Структура данных которого являются одномерные массива одинаковой длины.
*Другие назваиние двумерного массива.
* Таблица
* Матрица
* Массив массивов
* Все характиристики одномерного массива присуща и двумерным массивам.Массив имеет имя который используется для оброшение к элементам доступ осуществляется с помошью операций индексаций в болшинства языках программирование пара квадратных скобок([]).ТАкже массив имеет конечный размер.
* Представим что у нас имеется двумерный массив (tfble ) из двуз  строк по 6  элментоа каждый.Требуется получить доступ к выделенному элементу который находится на строке с индексом 1 и на столбце с индексом 3 . ТО есть эл 40
```sh
              0   1   2   3   4   5 
        0     1   2   3   4   5   6
table:  
        1     10  20  30  40  50  60
```
* ДЛя оброщение к ниму указываем имя как случае с одномерным массивом далее указываем индекс строки где находится данный элемент в данном примере это 1, в двумерном массиве индекс строк также начинается с 0, для того что бы выбрать элемент в строке мы укажем номер столбца в котором этот эл находится в данном примере это столбец 3 пример
```sh
table[1][3];
```
* размерность массива может быть одномерным двухмерным трезмерным и.т.д.Другими словами размерность показывает количества индексов или же координат который мы используем для оброщение к эл. массива .
* Создание двумерных массивов
```sh
int[,] table = new int [3,5];
```
* 1 этап тип данных в отличий от одномерного массива где указывалась 2 пары  квадтранных скобках, здесь используется одно пара и вней ставится запятая это всего лишь особенность синтесиса С#.
```sh
int[,];
```
* 2 о шаг это указание имени массива 
```sh
int[,] table 
```
* 3 и шаг это выделение памяти под элемента массива. Поскольку массив имеет 2 измерение то нужно указать из скольких одномерных массивов он будет состоять а также размер этих массивов 1 ым числом мы указываем количество строк в этом двумерном массиве 2ым числом указываем кол. эл. в каждый из строк
```sh
new int[3,5];
```
* для того что бы пройттись по длине двумерного массива используем операцию следущее.Пример можно посмотреть в папке Lesson4 => task1
```sh
i < matrix.GetLength
```
*  Операция Random - если ее создать внутри цикла то она будет создаваться при каждем ее обрашениий это может существенно замедлять выполнение операций и по возможности ресурсоемкие операций нужно  выносить из циклов. Смотреть пример в папке Lesson4-Task1.
* Как и с одномерными массивами есть способы зпаолнение двумерных массивов пример 
```sh
int[,] table1 = new int [2,4] {
    {1,1,1,1},
    {2,2,2,2}
};
```
* Когда мы указываем эл массива то размер его в квадратнных скобках можно не укзывать прорамма это сделает за нас исходя из количества строк и эл указанных при заполнений массива пример 
```sh
int[,] table1 = new int [,] {
    {1,1,1,1},
    {2,2,2,2}
};
```
* Дпугой способ 
```sh
int[,] table1 = {
    {1,1,1,1},
    {2,2,2,2}
};
```
* Строки - последовательный набор символов, который используется для представления текста.
* Строка в языке С# - массив символов типа Char
* ДЛя работы со строками в С#  используется специальный тип string
* Строка является неизменяемым типом данных
- элементы строки не могут быть изменены
- размер существующей строки не может быть изменен 
* Индексатор  понимается инструмент обращение как к массиву то есть применением операций квадратные скобки.Операция индексаций может быть применена для чтение элемента строки например для вывода его элемента на экран пример
```sh
string str = "Hello world"
Console.WriteLine([1]);
На экране:
H
```
* Есть некоторые способы - создание строки в С# 
* 1-ый вариант это присвоение пременной строкого литерала 
```sh
string s1 = "Hello World";
```
* 2- ой способ это создание строки из символьного массива типа char для этого нам потребуется создать массив символов можно воспользоваться соокращенным синтексисом далее с использованием оператора New  указание типа данных String мы создаем строку на основание переданного символьного массива В этом случаее ключевое слово string используется как конструктор строки.ОТмечим конструктор это специальный метод который создает обьект нашем случаее строку.В параметре этого конструктора тоесть String мы передаем символный массив на основане которого мы хотим создать эту строку пример 
```sh
char[] ch_array = {'w', 'o', 'r', 'l', 'd'};
string s2 = new String(ch-array);
```
* 3- и способ спользуется для создание строк из повтарающихся символов на практике иногда появляется необходимость создать строку из еулей или из какого нибудь специальныйх символов вместе того чтобы указывать в коде длинный строковый литерал особенно если он состоить из 10, 20, 100 символов лучше воспользоваться представленной формы конструктор для этого мы указываем сам символ и количества раз который он доложен быть повтарен 
```sh
string s3 = new String('a', 6); результатом будет аааааа
```
* Тип данных string предоставляет наборы методов которые часто требются в задачах по обработке строк наеболее полпулярные это
```sh
Contains - позволяет выяснить содержит ли указанная строка какую либо образец часто используется для поиска каких либо слов в тексте 
```
```sh
EndWith - позволяет проверить оканяивается ли строка каким либо словом используется когда проверяется расширение фаила является ли он текстовым то есть расширение txt , графическим расширенеи jpg и.т.д
```
```sh
Insert позволяет вставить слово на определенную позицию в строке 
```
```sh
Replace - Позволяет заменить слово на какую либо указанную подстроку Используется при оброботке текста пример когда нужно удалить какую либо слово из текста мы просто можем заменить его на пробел или на пустую строку 
```
```sh
Index01 - Находит индекс первого вхождения символоа или подстроки в строке
```
* Операторы передачи управления (break) и (continue)
* Это переход во время выполнение программы на какой либо участок кодаю То есть программа выполняет инструкций первая вторая инструкция треться инструкция по очередно , оператор передачи управления заставляет ее выполнить строчку кода находящуюся либо где то высше ткущей либо ниже перескакивая через несколько строк кода  
```sh
Break - " из распросранненных применений это его использование в теле цткла. Break позволяет прервать выолнение ближашего внешнего цикла.(while,for,foreach)
```
* Часто используется когда в процессе работы цикла появляются некие условия при которых цикл нужно прервать 
* Распространненый случай - остоновка цикла с условием true(бексонечный цикл)
```sh
while(true)
{
    Console.WriteLine("I am in loop");
    break;
}
```
* Continue - Позволяет перейте к следующей итераций ближаещего внешнего цикла.(while,for,foreach).Он позволяет не прервать цикл а перейти к  следующей итераций
* Часто используется когда появляются условия при которых оставшейся тело цикла нужно пропустить
```sh
for(int = 0; i < 5; i++)
{
    Console.WriteLine($"Iteretion {i}: ");
    if(i == 3)
    {
        Console.WriteLine("Skip ");
        Continue;
    }
    Console.WriteLine("Some proccesing ");
}
```
## Запись с 5-го урока.Рекурсия
* Рекурсия- описание какого либо обьекта внутри этого самого обьекта то есть ситуация когда обьект является частью самого себя.

  * Рекурсия в программировании
  * Рекурсия-процесс в котором функция вызывает саму сея
  * Соответсвующая функция называется рекурсивной функцией
  * Такой вызов называется рекурсивным вызывом
  * Рекурсивный вызов
  - решает более простую(меньшую) задачу чем текущаю
  - обычно достигается за счёт упрощения(уменщения) аргумента 
  * условия остонавки рекурсии
  - текущая задача стала тривиальной(об этом скажет значение параметра)
  - рекурсивный вызов не требуется
  - условия размещается перед рекурсивным вызывом
  * Процесс возврата к местам вызовов называется расскручиванием рекурсии 
  - в процессе расскручиание рекурсии мы как бы возвращаемся к местам вызова функции. Места вызовов сохраняются в памяти что бы потом к ним можно было бы вернутся.
  * облость памяти куда сохраняется вся эта информация называется "Стэк"
  * В памяти сохраняются
  - места вызова
  * значения параметров функции при вызове  
  ### Отладка
  * Отладка- процесс поиска и исправления ошибок в программном коде
  * ОТладку можно проводить путем вывода интересующей информации на концоль или например файл 
  * Также можно пользоваться специальным инструментами среды разработчика 
  * Принципы разработки ПО
  1) DRY (Don`t Repeat yourself) 
  - Избегайте дублирование одинаковых фрагментов кода
  - Задумайтесь об использовании функции для борьбы с дублированием 
  - Дублирование кода - пустая трата времени и ресурсов.
  2) KISS (Keep It Simple,Stupid)
  - Простые системы будут работать лучше и надежнее 
  - Не придумывайте к задаче более сложного решения, чем ей требуется
  - простота кода - превыше всего, потому что простой код - наеболее понятный
  - Непонятный код автоматически вызывает у человека ощущение того, что код сложный, так как его сложныо понимать и модифицировать.
  3)  YADNI ( You Aren`t Gonna Need It)
- Основная цель - отказ от избыточной функциональности
- Отказ добавления функциональности , в которой нет непосредсвенной надобности 
- если пишите код то будьте уверены что он вам понадобится 
- не пишите код если думаете что он пригодится позже 
- Если вы занимаетесь рефакторингом, не бойтесь удалять лишние метода.
- Если она сново понадобится- можно воспользоваться git- рпеозиторием