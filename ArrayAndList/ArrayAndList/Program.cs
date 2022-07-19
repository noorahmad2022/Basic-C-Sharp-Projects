using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

        // Methode 1
        int[] numArray = new int[5];
        numArray[0] = 10;
        numArray[1] = 15;
        numArray[2] = 40;
        numArray[3] = 100;
        numArray[4] = 5000;

        Console.WriteLine(numArray[4]);
        Console.ReadLine();

        //Methode 2, is same exact result as methode 1.
        int[] numArray1 = new int[] { 10, 15, 40, 100, 5000 };

        Console.WriteLine(numArray1[3]);
        Console.ReadLine();

        //Methode 3, is the easy way.
        int[] numArray2 = { 10, 15, 40, 100, 5000 };
        Console.WriteLine(numArray2[2]);
        Console.ReadLine();

        // Target the Array, or change the value.

        numArray2[2] = 1000;
        Console.WriteLine(numArray2[2]);
        Console.ReadLine();


        // List, is using system.collections.generic name space. we can create list with any type of data.

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);

        Console.WriteLine(4);
        Console.ReadLine();

        List<string> strList = new List<string>();
        strList.Add("Hello Wold");
        strList.Add("Noorahmad");
        strList.Remove("Noorahmad");

        Console.WriteLine(strList[0]);
        Console.ReadLine();

        }
    }
