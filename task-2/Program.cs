using System;

public static class ArrayExtensions
{
    public static int[] Add(this int[] array, int element)
    {
        int[] newArray = new int[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = element;
        return newArray;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = new int[0];
        arr = arr.Add(1);
        arr = arr.Add(2);
        arr = arr.Add(3);
        arr = arr.Add(4);

        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }

        Console.WriteLine(sum); 
    }
}
