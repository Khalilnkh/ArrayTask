using System;

namespace ArrayTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[3];
            string name1 = "Namiq";
            string name = "Kheyrulla";
            string name2 = "Ali";

            ArrayHelper.Add(ref names, name1);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            ArrayHelper.Remove(ref names, name1);
            
           




           



        }
    }
    public   class ArrayHelper
    {
        public static string[]  Add(ref string[] arr,string value)
        {
            Array.Resize(ref arr,arr.Length+1);
            arr[arr.Length-1]=value;
            return arr;
        }
        public static string[] Remove(ref string[] arr, string value)
        {
            int rmIndex=Array.IndexOf(arr,value);   
            if (rmIndex==-1)
            {
                Console.WriteLine("Not found");
            }
            for (int i = rmIndex; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }  
    }
}
