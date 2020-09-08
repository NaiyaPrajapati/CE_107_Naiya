using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace lb8_task1
{
    public class task1 {         
        
		static void Main(string[] args)
        {
			List <int> numbers = new List<int>();
			for(int i=1;i<=100;i++)
			{
				numbers.Add(i);
			}				
            Console.Write("Even Numbers:\n");
            var even = numbers.Where(num => num%2==0);
            foreach (int i in even)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
            Console.Write("Odd Numbers:\n");
            var odd = numbers.Where(num => num%2!=0);
            foreach(int i in odd)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");

            Console.Write("Select All Numbers:\n");
            var all = numbers.Select(num => num);
            foreach(int i in all)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");

            Console.Write("Select max and min:\n");
            int max = numbers.Max();
            int min = numbers.Min();
            
            Console.WriteLine("Max: "+max+"\n");
            Console.WriteLine("Min: "+min+"\n");

            var avg = numbers.Average();
            Console.WriteLine("Average: "+avg+"\n");
           
        }
    }
}