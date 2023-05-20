
Console.WriteLine("Введите несколько символов");
string text1 = Console.ReadLine()!;
Console.WriteLine("Введите еще несколько символов ");
string text2 = Console.ReadLine()!;
Console.WriteLine("И еще один раз введите несколько символов ");
string text3 = Console.ReadLine()!;
int numberOfLines = 3;

string[] createArrayString = CreateArrayString(text1, text2, text3, numberOfLines);
PrintArray(createArrayString);
string[] newArray = NewArray(createArrayString );
PrintArray(newArray);


string[] CreateArrayString(string text1, string text2, string text3, int numOfLines)
{

    string[] arr = new string[numOfLines];
    arr[0] = text1;
    arr[1] = text2;
    arr[2] = text3;
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] NewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[i] = arr[i];
        }
    }
    return newArray;
}