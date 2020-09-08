using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace lb7_task2
{
    public class task2 {         
        
		static void Main(string[] args)
        {
            string[] arr = {"virat","msd", "hardik","chahal","abd","klrahul","jadeja","rohit","dhawan","raina"};
			List <string> names = new List<string>(arr);
            
            var k_names = names.Where(name => name.StartsWith("k")==true);

            Console.WriteLine("Names Starting with K:");
            foreach(string name in k_names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var length_4 = names.Where(name => name.Length<=4);

            Console.WriteLine("Names with length less than or equal to 4:");
            foreach(string name in length_4)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var length_3 = names.Where(name => name.Length==3);
            
            Console.WriteLine("Names with length equal to 3:");
            foreach(string name in length_3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

			var ascend_names = names.Select(name=>name).OrderBy(name1=>name1);
            
            Console.WriteLine("Names in ascending order:");
            foreach(string name in ascend_names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}