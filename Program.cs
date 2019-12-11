using System;
using System.Collections.Generic;


namespace PrimeSifting {

  public class Program
  {
      public static void Main()
      {
          Console.WriteLine("gimme your number");
          int userNum = int.Parse(Console.ReadLine());
          Console.WriteLine(Program.findPrimes(userNum));
      }

      public static string findPrimes(int num)
      {
        List<int> numList = new List<int>();
        string result = "";
        for(int i = 2; i <= num; i++)
        {
            numList.Add(i);
        }
        for(int i = 0; i < numList.Count; i++)
        {
            for(int j = i + 1; j < numList.Count; j++)
            {
                if(numList[j] % numList[i] == 0)
                {
                    numList.RemoveAt(j);
                }
            }
            result += " " + numList[i].ToString();
        }
        return result;
      }
  }

}