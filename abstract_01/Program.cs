/*

// 1й метод:

void Metho1()
{
    Console.WriteLine("Рад знакомству метод1");
    Console.WriteLine("author");
}

Metho1();

// метод2:
void Metho2(string msg)
{
    Console.WriteLine(msg);
}
Metho2("Рад знакомсту Метод2");
// Именованные аргументы
void Method121(string msg, int count)
{   int i  = 0;
    while (i < count)
    {
        Console.WriteLine(msg);   
        i ++;
    }   
}
Method121( count:3, msg: "+++");

// Метод3:
int Method3()
{
    return DateTime.Now.Minute;
}

int year = Method3();
Console.Write("Текущая минута: ");
Console.WriteLine(year);

// Тетод4:

/*
string Method4(int count, string text)
{
    string resulst = String.Empty;
    int i = 0;
    
    while (i < count)
    {
           resulst = resulst + text;
           i ++;
    }
    return resulst;
}

string resulst = Method4(count: 4, "Результат операции");
Console.Write("Результат операции метода4: ");
Console.WriteLine(resulst);


// Метод4_цикл "for":

string Method4(int count, string text)
{
    string resulst = String.Empty;
    for(int i = 0; i < count; i ++)
    {
           resulst = resulst + text;
    }
    return resulst;
}

string resulst = Method4(count: 4, "Результат операции");
Console.Write("Результат операции метода4: ");
Console.WriteLine(resulst);

// Цикл в цикле (На примере таблицы умножения):

for( int a = 2; a <= 10; a ++)
{
    for( int b = 2; b <= 10; b ++)
    {
        Console.WriteLine($"{a} x {b} = {a * b}");
    }
    Console.WriteLine();
}
*/


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = ("— Я думаю, — сказал князь, улыбаясь, — что,")

            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?"; 
// string s = “qwerty”
//             012345
// s[3] // r

/*string Raplace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for(int i = 0; i < length; i ++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result; 
}

string newText = Raplace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Raplace(text, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();

newText = Raplace(text, 'С', 'с');
Console.WriteLine(newText);
*/

/*int[] arr = {1,5,4,6,8,4,7,10,6,49,5,12,10};

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for( int i = 0; i < count; i ++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);


void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length - 1; i ++)
    {
        int minPosition = i;
        for(int j = i +1; j < arr.Length; j ++)
        {
            if(arr[j] < arr[minPosition])
            {
                minPosition = j;
            }
        }
        
        
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}
SelectionSort(arr);
PrintArray(arr);
*/

int[] arr = {1,7,1,6,16,4,11,10,6,49,67,12,19};

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for( int i = 0; i < count; i ++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);


void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length - 1; i ++)
    {
        int maxPosition = i;
        for(int j = i +1; j < arr.Length; j ++)
        {
            if(arr[j] > arr[maxPosition])
            {
                maxPosition = j;
            }
        }
        
        
        int temporary = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}
SelectionSort(arr);
PrintArray(arr);
