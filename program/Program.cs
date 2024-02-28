// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


using System;



class Prog
{
    static Random rand = new Random();
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine()!;
        Console.WriteLine();
        Console.WriteLine("Final string:");
        Console.WriteLine(string.Join(", ", resolution(str)));
    }
  
  public static string[] resolution(string str)
  {
    // str = str.Replace("“", "");
    // str = str.Replace("”", "");
    str = str.Replace(" ", "");
    string[] words = str.Split(',');
    int count = 0;
    int j = 0;
    for(int i = 0; i < words.GetLength(0); i++)
    {
      char[] word = words[i].ToCharArray();
      if (word.GetLength(0) < 4)
      {
        count++;
      }
    }

    string[] r_words = new string[count];

    for(int i = 0; i < words.GetLength(0); i++)
    {
      char[] word = words[i].ToCharArray();
      if (word.GetLength(0) < 4)
      {
        r_words[j] = words[i];
        j++;
      }
    }
    return r_words;
  }
  
}