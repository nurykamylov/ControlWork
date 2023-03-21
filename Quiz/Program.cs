/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["Hello"‚ "2"‚ "World"‚":_)"]-> ["2"‚ ":_)"]
["1234","1567","_2"‚"computer scіепсе"]->["_2"] 
["Russia","Denmark","Каzап"]->[]
*/
Console.WriteLine("enter the length of array: ");
int a  = int.Parse(Console.ReadLine()!);
string [] array =  new string[a];
System.Console.WriteLine("then enter the elements for massive: ");
for (int i = 0; i < array.Length; i++)
{
    string s = Console.ReadLine()!;
    array[i] = s;
}


void PrintArray(string[] arr )
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    System.Console.WriteLine();
}

void OutputThreeElements(string[] arr)
{
    System.Console.Write("The Final result = ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3)
        {
            System.Console.Write($" {arr[i]},");
        }
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
 OutputThreeElements(array);
