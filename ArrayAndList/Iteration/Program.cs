using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // For Loop with Int.
        int[] testScore = { 98, 67, 70, 87 ,91, 89, 34, 60 };

        for (int i = 0; i < testScore.Length; i++)
        {
            if (testScore[i] > 80)
            {
                Console.WriteLine("Passing test score: " + testScore[i]);
            }
        }
        Console.ReadLine();

        // For Loop with String.
        string[] empName = { "Noorahmad", "Jesse", "Daniel", "Adam" };
        for(int j=0; j<empName.Length; j++)
        {
            if(empName[j]=="Noorahmad" || empName[j] == "Jesse")
            {
                Console.WriteLine("Hello " +empName[j] +"!");
            }
        }
        Console.ReadLine();

        // For Each Loop with INT List

        List<int> testScores = new List<int>();
        testScores.Add(88);
        testScores.Add(97);
        testScores.Add(78);
        testScores.Add(69);
        testScores.Add(60);

        foreach (int s in testScores)
        {
            if(s > 85)
            {
                Console.WriteLine("Passing test Score: " + s);
            }
        }
        Console.ReadLine();

        // For Each Loop with String List

        List<String> Names = new List<string>() { "Noorahmad", "Jesse", "Daniel", "Adam" };
        foreach(string personName in Names)
        {
            if(personName=="Noorahmad" || personName == "Jesse")
            {
                Console.WriteLine("Hello " + personName);
            }
        }
        Console.ReadLine();

        // Passing int to empty list and Counting the result.

        List<int> examScore = new List<int>() { 98, 95, 80, 34, 89 };
        List<int> examPassingScore = new List<int>(); // empty list

        foreach(int scores in examScore)
        {
            if(scores > 85)
            {
                examPassingScore.Add(scores);
            }
        }
        Console.WriteLine("Number of passing Scores : " + examPassingScore.Count);
        Console.ReadLine();


    }
}
