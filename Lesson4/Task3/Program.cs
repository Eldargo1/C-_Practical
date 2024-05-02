// Считать с консоли строку, состоящую из 
// цифр и латинских букв.
// Сфорировать новую строку состоящую из
// букв исходной строки.
string GetLetter(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}


string str = Console.ReadLine();
string result = GetLetter(str);
Console.WriteLine(result);
