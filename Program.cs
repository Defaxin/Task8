using ConsoleApp37;
using System;

namespace ConsoleApp37
{
    public interface ICalc { int Less(int num); int Greater(int num); }
    public interface IOutput2 { void ShowEven(); void ShowOdd(); }
    public interface ICalc2 { int CountDistinct(); int EqualToValue(int valueToCompare); }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array array = new Array(arr);
            Console.WriteLine(array.Less(5));
            Console.WriteLine(array.Greater(5));
            array.ShowEven();
            array.ShowOdd();
            Console.WriteLine(array.CountDistinct());
            Console.WriteLine(array.EqualToValue(3));
        }
    }
}
public class Array : ICalc, IOutput2, ICalc2
{
    private int[] arr;

    public Array(int[] array)
    {
        arr = array;
    }
    public int Less(int num)
    {
        int count = 0;
        foreach (int value in arr)
        {
            if (value < num)
            {
                count++;
            }
        }
        return count;
    }
    public int Greater(int num)
    {
        int count = 0;
        foreach (int value in arr)
        {
            if (value > num)
            {
                count++;
            }
        }
        return count;
    }
    public void ShowEven()
    {
        foreach (int value in arr)
        {
            if (value % 2 == 0)
            {
                Console.Write(value + " ");
            }
        }
        Console.WriteLine();
    }
    public void ShowOdd()
    {
        foreach (int value in arr)
        {
            if (value % 2 != 0)
            {
                Console.Write(value + " ");
            }
        }
        Console.WriteLine();
    }
    public int CountDistinct()
    {
        return arr.Distinct().Count();
    }
    public int EqualToValue(int num)
    {
        return arr.Count(value => value == num);
    }
}

