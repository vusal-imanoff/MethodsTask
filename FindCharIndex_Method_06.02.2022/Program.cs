using System;

namespace FindCharIndex_Method_06._02._2022
{
    class Program
    {
        #region FindCharIndex
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("sozu daxil edin:");
        //    string str_text = Console.ReadLine();
        //    Console.WriteLine("Herfi daxil edin:");
        //    char symbol;
        //    char.TryParse(Console.ReadLine(), out symbol);

        //    Console.WriteLine(FindCharIndex(str_text, symbol));
        //}
        //static int FindCharIndex(string str_text, char symbol)
        //{
        //    char[] arr = str_text.ToCharArray();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == symbol)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region IsPrime
        //static void Main()
        //{
        //    Console.Write("n=");
        //    string n = Console.ReadLine();
        //    int neded = int.Parse(n);
        //    Console.WriteLine(IsPrime(neded));
        //}
        //static bool IsPrime(int neded)
        //{

        //    int count = 0;
        //    for (int i = 2; i < neded; i++)
        //    {

        //        if (neded % i == 0)
        //        {
        //            count++;
        //            break;
        //        }
        //    }
        //    if (count > 0)
        //    {
        //        return false;
        //    }

        //    else
        //    {
        //        return true;

        //    }
        //}
        #endregion

        #region CalcAvg
        //static void Main()
        //{
        //    Console.WriteLine("Qiymet sayin daxil edin");
        //    int say;


        //    int.TryParse(Console.ReadLine(), out say);
        //    int[] arr = new int[say];

        //    double result = CalcAvg(arr, say);

        //    if (result > 60)
        //    {
        //        Console.WriteLine("\nMezun oldunuz,sizin ortalama baliniz: " + result);

        //    }
        //    else
        //    {
        //        Console.WriteLine("\nMezun ola bilmediniz, sizin ortalama baliniz: " + result);

        //    }
        //}
        //static double CalcAvg(int[] arr, int say)
        //{
        //    double result;
        //    int sum = 0;

        //    for (int i =0; i < say; i++)
        //    {

        //        Console.Write($"Qiymet - {i+1} :" ,i);
        //        int.TryParse(Console.ReadLine(), out arr[i]);
        //    }
        //    Console.Write("\nQiymetler : ");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write("{0}  ", arr[i]);
        //    }
        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        sum = sum + arr[i];

        //    }
        //    result = (double)sum / arr.Length;

        //    return result;
        //}
        #endregion
    }
}