using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;    
using System.Text; 

namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            // AddUniqueToSortedList();
            // ReverseString();
            // ReverseNumber();
            // CheckPalindromeInteger();
            // PrintFibonacciSeries();
            // CheckPrimeNumber();
            // PrintPrimeNumbers();
            // PrintFactorialSum();
            // GetSumOfDigitsOfAnINteger();
            // Swap2VarsWihout3rdVar();
            // QuickSortAnArrayOfIntegers();
            // RegexTester();
        }

        // * => Matches the preceding character zero or more times. (a*b <=> b, ab, aab)
        // + => Matches the preceding character 1 or more times. (a+b <=> ab, aab)
        // ? => Matches the preceding char zero or one time. (a?b <=> b, ab)
        // ^ => It is used to match the beginning of a string. (^India <=> India is my home)
        // $ => It is used to match the end of a string. (home$ <=> India is my home)
        // .(Dot) => Matches any character only once. (s.t <=> sit, set, s@t)
        // \d => It is used to match a digit character. [0-9]
        // \D => It is used to match any non-digit character. [^0-9]
        // \w => It is used to match an alphanumeric character plus "_".
        // \s => Matches white space characters.
        // [ ] => It is used to match a range of characters.
        // ()=> It is used to group expressions. (cd)+ <=> cd, cdcd, 

        // {n}=> Matches the previous element exactly n times.
        // {n,m} =>Matches the previous element at least n times, but no more than m times.
        public static void RegexTester(){
            Regex r = new Regex(@"^\+");    
    
            string[] str = { "+1", "1", "-1"};    
    
            foreach(string s in str)    
            {    
                Console.WriteLine("{0} {1} a match.", s, r.IsMatch(s) ? "is":"is not");
            }    
        }

        public static void AddUniqueToSortedList(){
            
            List<string> list = new List<string>();
            HashSet<string> set = new HashSet<string>();
            Boolean waitForInput = true;

            while (waitForInput)
            {
                string input = Console.ReadLine();
                if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                
                if(!set.Contains(input)){
                    set.Add(input);
                    list.Add(input);
                    list.Sort();                    
                }
            }

            foreach(string lisItem in list) 
            { 
                Console.WriteLine(lisItem); 
            }
        }

        public static void ReverseString(){

            Console.WriteLine("Enter a string and [Enter] to reverse. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                string input = Console.ReadLine();
                if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                
                Char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                String outStr = new string(charArray);
                Console.WriteLine("Reverse of string is {0}", outStr);
            }
        }

        public static void ReverseNumber(){

            Console.WriteLine("Enter an integer and [Enter] to reverse. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    
                    Int32 inputInt = Int32.Parse(input);                    
                    Int32 outputInt = 0;

                    while(inputInt != 0){
                        outputInt = (outputInt * 10) + (inputInt%10);
                        inputInt = inputInt/10;
                    }
                    Console.WriteLine("Reverse of integer is {0}", outputInt);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        public static void CheckPalindromeString(){

            Console.WriteLine("Enter a string and [Enter] to check. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    
                    Char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    String outStr = new string(charArray);
                    Console.WriteLine("String is {0} palindrome", input.ToLower().Equals(outStr.ToLower()) ? "a" : "not a");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input.");
                }
            }
        }

        public static void CheckPalindromeInteger(){

            Console.WriteLine("Enter an Integer and [Enter] to check. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    
                    Int32 inputInt = Int32.Parse(input), inputIntOrg = Int32.Parse(input), outputInt = 0;

                    while(inputInt != 0){
                        outputInt = (outputInt * 10) + (inputInt%10);
                        inputInt = inputInt/10;
                    }
                    Console.WriteLine("Integer is {0} palindrome", inputIntOrg.Equals(outputInt) ? "a" : "not a");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        public static void PrintFibonacciSeries(){

            Console.WriteLine("Enter a number size for Fibonacci series and press [Enter] to check. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    
                    Int32 size = Int32.Parse(input), num1 = 0, num2 = 1, num3 = 0, counter = 0;

                    Console.Write("Fibonacci series is: 0, 1");
                    for(counter=2; counter<size; counter++){
                        num3 = num1+num2;
                        num1 = num2;
                        num2 = num3;
                        Console.Write(", {0}", num3);
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        public static void CheckPrimeNumber(){

            Console.WriteLine("Enter a number and press [Enter] to check. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    
                    Int32 num = Int32.Parse(input), counter = 0;
                    Boolean isPrime = true, isNumLessThanZero = num < 0;

                    if(isNumLessThanZero){
                        for(counter=-2; counter> num; counter--)
                            if(!CheckModulo(num, counter)){ isPrime = false; break; }                        
                    }
                    else{
                        for(counter=2; counter< num; counter++)
                            if(!CheckModulo(num, counter)){ isPrime = false; break; }                        
                    }
                    if(isPrime) Console.WriteLine("Number is prime");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        private static Boolean CheckModulo(Int32 num, Int32 counter){
            if((num%counter) == 0){
                Console.WriteLine("Number is not prime as {0}x{1}={2}", counter, num/counter, num);
                return false;
            }
            else
                return true;
        }

        public static void PrintPrimeNumbers(){

            Console.WriteLine("Enter a number limit and press [Enter] to get primes. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;                    
                    Int32 num = Int32.Parse(input);

                    if(num < -3){
                        Console.Write("Prime num series is: 0, -1, -2, -3");
                        Int32 primeCount = 4;
                        for(Int32 counter=-4; counter>= num; counter--){
                            Boolean isPrime = true;
                            for(Int32 x=-2; x>counter; x--){
                                if((counter%x) == 0){
                                    isPrime = false;
                                    break;
                                }
                            }
                            if(isPrime){
                                Console.Write(", {0}", counter);
                                primeCount++;
                            }
                        }
                        Console.WriteLine(". Count: {0}", primeCount);
                    }
                    else if(num < 0){
                        Console.Write("AA Prime num series is: -1");
                        Int32 primeCount = 2;
                        for(Int32 x = -2; x>=num; x--){
                            Console.Write(", {0}", x);
                            primeCount++;
                        }
                        Console.WriteLine(". Count: {0}", primeCount);

                    }
                    else if(num < 4){
                        Console.Write("Prime num series is: 0");
                        Int32 primeCount = 1;
                        for(Int32 x = 1; x<=num; x++){
                            Console.Write(", {0}", x);
                            primeCount++;
                        }
                        Console.WriteLine(". Count: {0}", primeCount);
                    }
                    else{
                        Console.Write("Prime num series is: 0, 1, 2, 3");
                        Int32 primeCount = 4;
                        for(Int32 counter=4; counter<= num; counter++){
                            Boolean isPrime = true;
                            for(Int32 x = 2; x<counter; x++){
                                if((counter%x) == 0){
                                    isPrime = false;
                                    break;
                                }
                            }
                            if(isPrime){
                                Console.Write(", {0}", counter);
                                primeCount++;
                            }
                        }
                        Console.WriteLine(". Count: {0}", primeCount);
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }        
    
        public static void PrintFactorialSum(){

            Console.WriteLine("Enter a number size for Factorial sum and press [Enter] to check. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    Int32 size = Int32.Parse(input), sum=0;

                    if(size < 0){
                        for(Int32 counter=0; counter>=size; counter--)
                            sum = sum + counter;
                    }
                    else{
                        for(Int32 counter=0; counter<=size; counter++)
                            sum = sum + counter;
                    }

                    Console.WriteLine("Factorial sum is: {0}", sum);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        public static void GetSumOfDigitsOfAnINteger(){

            Console.WriteLine("Enter a number to get sum of its digits and press [Enter] to check. Press just [Enter] to exit.");
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    string input = Console.ReadLine();
                    if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) break;
                    Int32 num = Int32.Parse(input), sum=0;

                    // if(num < 0) num = num * -1;
                    while(num > 0){                        
                        sum = sum + num%10;
                        num = num/10;
                    }
                    Console.WriteLine("Sum of digits is: {0}", sum);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        public static void Swap2VarsWihout3rdVar(){
            
            Boolean waitForInput = true;

            while (waitForInput)
            {
                try
                {
                    Console.WriteLine("Enter 1st number to swap and press [Enter] to check. Press just [Enter] to exit.");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("Enter 2nd number to swap and press [Enter] to check. Press just [Enter] to exit.");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("Before swap input1= "+input1+" input2= "+input2);

                    if(String.IsNullOrEmpty(input1) || String.IsNullOrEmpty(input2) || String.IsNullOrWhiteSpace(input1) || String.IsNullOrWhiteSpace(input2)) break;
                    Int32 num1 = Int32.Parse(input1), num2 = Int32.Parse(input2);

                    num1=num1*num2;
                    num2=num1/num2;
                    num1=num1/num2;
                    Console.WriteLine("After swap input1= "+num1+" input2= "+num2);                   }
                catch (System.Exception)
                {
                    Console.WriteLine("Error while parsing input integer");
                }
            }
        }

        private static void Quick_Sort(int[] arr, int left, int right) 
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1) {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }        
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true) 
            {

                while (arr[left] < pivot) 
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else 
                {
                    return right;
                }
            }
        }

        public static void QuickSortAnArrayOfIntegers()
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
                Console.Write(" " + item);    

            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length-1);
            
            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
           
		    foreach (var item in arr)
                Console.Write(" " + item);

            Console.WriteLine();
        }

        public static void Miscellaneous(){
            // var x = 10%4;   //2
            // int a = String.Compare("case1", "Case1", false);
            // bool b =  String.Equals("HTTP", "http", StringComparison.OrdinalIgnoreCase);
            // string c = String.Concat(1, 2, 3, 4);

            // ArrayList a1 = new ArrayList();
            // a1.Add("John");
            // a1.Add("Cecil");
            // a1.Add("Piper");
            // a1.Add("Andy");
            // a1.Add("Tony");
            // Console.WriteLine(a1.Count);
            // Console.WriteLine("Contains Piper : " + a1.Contains("Piper"));
            // Console.WriteLine("Contains Tim : " + a1.Contains("Tim"));
            // a1.Sort();
            // a1.Reverse();
            // foreach(string a in a1) 
            // { 
            //     Console.WriteLine(a); 
            // }
                    
        }
    }
}
