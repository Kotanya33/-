using System.Diagnostics; // подключаем пространство имён, в котором находится класс Stopwatch
Stopwatch time = new Stopwatch();
//! Задача: Написать программу, которая из имеющегося массива строк формирует
//! массив из строк, длина которых <= 3 символа. Первоначальный массив можно
//! вывести с клавиатуры, либо задать на старте выполнения алгоритма.  
//! При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
//! исключительно массивами. 
//? ["hello", "2", "world", ":-)"] --> ["2", ":-)"]

//! МЕТОД 1
string [] ThreeSymbols(string [] array)
{
    string [] newarray = new string[array.Length];
    int i = 0; int size = 0; int j = 0;
    while (i < array.Length)
    {
        if(array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++; size++;
        }  
        i++;  
    }
    string [] finalarray = new string[size];
    for(i = 0; i < size; i++)
    {
        finalarray[i] = newarray[i];
        Console.Write(finalarray[i] + ", ");
    }
    return finalarray;
}
time.Start(); // запускаем отсчёт времени

string [] array = {"hello", "2", "world", ":-)"};
ThreeSymbols(array);

time.Stop(); // останавливаем работу
Console.WriteLine();
Console.WriteLine(time.Elapsed); // выводим затраченное время

//! МЕТОД 2
string [] ThreeSymbols2(string [] array)
{
    int i = 0; int size = 0;
    while (i < array.Length)
    {
        if(array[i].Length <= 3)
        {
            size++;
        }  
        i++;  
    }
    string [] finalarray = new string[size];
    int j = 0; i = 0;
    while(i < array.Length)
    {
        if(array[i].Length <= 3)
            {
                finalarray[j] = array[i];
                Console.Write(finalarray[j] + ", ");
                j++;
            }
        i++;
    }
    return finalarray;
}
time.Start(); // запускаем отсчёт времени

string [] array2 = {"hello", "2", "world", ":-)"};
ThreeSymbols2(array2);

time.Stop(); // останавливаем работу
Console.WriteLine();
Console.WriteLine(time.Elapsed); // выводим затраченное время