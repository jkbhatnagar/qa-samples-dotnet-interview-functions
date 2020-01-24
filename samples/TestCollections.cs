using System; 
using System.Collections.Generic; 
using System.Linq; 
  
namespace Test { 


    public class TestCollections { 
        public void TestList()
        { 
            // List to store numbers 
            List<int> numbers = new List<int>() {36, 71, 12,  
                                15, 29, 18, 27, 17, 9, 34}; 
    
            // foreach loop to dislay the list 
            Console.Write("The list : "); 
            foreach(var value in numbers) 
            { 
                Console.Write("{0} ", value); 
            } 
            Console.WriteLine(); 
    
            // Using lambda expression 
            // to calculate square of 
            // each value in the list 
            var square = numbers.Select(x => x * x); 
    
            // foreach loop to display squares 
            Console.Write("Squares : "); 
            foreach(var value in square) 
            { 
                Console.Write("{0} ", value); 
            } 
            Console.WriteLine(); 
    
            // Using Lambda exression to 
            // find all numbers in the list 
            // divisible by 3 
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0); 
    
            // foreach loop to display divBy3 
            Console.Write("Numbers Divisible by 3 : "); 
            foreach(var value in divBy3) 
            { 
                Console.Write("{0} ", value); 
            } 
            Console.WriteLine(); 
        }

        public void TestArray()
        { 

        }

        public void TestArrayList()
        { 

        }

        public void TestDictionary()
        { 

        }

        public void TestHashMap()
        { 

        }


        
    }

    class Student { 
        
        // properties rollNo and name 
        public int rollNo 
        { 
            get; 
            set; 
        } 
        
        public string name 
        { 
            get; 
            set; 
        } 
    } 
    
    class GFG { 
        
        // Main Method 
        public void TestListOfObjects() 
        { 
            // List with eah element of type Student 
            List<Student> details = new List<Student>() { 
                new Student{ rollNo = 1, name = "Liza" }, 
                    new Student{ rollNo = 2, name = "Stewart" }, 
                    new Student{ rollNo = 3, name = "Tina" }, 
                    new Student{ rollNo = 4, name = "Stefani" }, 
                    new Student { rollNo = 5, name = "Trish" } 
            }; 
    
            // To sort the details list  
            // based on name of student 
            // in acsending order 
            var newDetails = details.OrderBy(x => x.name); 
    
            foreach(var value in newDetails) 
            { 
                Console.WriteLine(value.rollNo + " " + value.name); 
            } 
        } 
    } 

} 



// COLLECTIONS  - ARRAY, List, Set, SortedSet, SortedList, 

// Array

// Int32[] value = new Int32[3];
// value[0]=1;
// value[1]=2;
// value[2]=3;

// value[0]

// ArrayList a1 = new ArrayList();
//    a1.Add(1);
//    a1.Add("Example");
//    a1.Add(true);

//    ArrayList.Count
//    ArrayList.Contains(element)
//    ArrayList.RemoveAt(index)
//    a1[1]
//    ArrayList.Remove(T)
//    ArrayList.Clear()

//   List<int> distinct = arrayList.Distinct().ToList();

//   ArrayList<String> myList = new ArrayList<string>();
//   foreach (string aString in myList)
//   {
//       if (!myList.Contains( aString ))
//       {
//           myList.Add(aString);
//       }
//   }

// Hashtable ht = new Hashtable();
//    ht.Add("001",".Net");
//    ht.Add("002","C#");
//    ht.Add("003","ASP.Net");

//    ICollection keys = ht.Keys;

//    foreach (String k in keys)
//    {
//     Console.WriteLine(ht[k]);
//    }

//    ht.Containskey(key)
//    ht.ContainsValue(value)



// DICTIONARY

//     Dictionary<int, string> myDictionary = new Dictionary<int, string>();
//     myDictionary.Add(1123, "Welcome"); 
//     myDictionary.Add(1124, "to"); 
//     myDictionary.Add(1125, "GeeksforGeeks"); 

//     myDictionary.Remove(1123);
//     myDictionary.Clear();
//     var keyColl = myDictionary.Keys;    //myDictionary.Values;
//     Boolean hasKey = myDictionary.ContainsKey(1123);
//     Boolean hasVal = myDictionary.ContainsValue("to");

//     foreach(KeyValuePair<int, string> item in myDictionary) 
//     { 
//         Console.WriteLine("{0} and {1}", item.Key, item.Value); 
//     } 
