using System.Collections.Generic;
using System.Linq;

public class Local_to_remote
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{HighAndLow("1 2 -3 4 5")}"); 
    }

    public static string HighAndLow(string numbers)
    {
       
    //    int number=int.Parse()
            var number=numbers.Split(' ');
            int[] result=new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                result[i]=int.Parse(number[i]);
            }

            int[] height=[0];
            int[] low=[0];

        for (int i = 1; i < result.Length; i++)
        {
            if(height[0]<result[i]){
                height[0]=result[i];
            }else if(low[0]>result[i]){
                low[0]=result[i];
            }
        }

        Console.WriteLine($"height : {height[0]}");
        Console.WriteLine($"low : {low[0]}");

           
        return "throw towel";
    }
}
