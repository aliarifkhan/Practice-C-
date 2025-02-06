
//int a = 20, b = 20;

//if (a >= b || a==21 )
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}



//int a, b;
//char c;

// Console.WriteLine("Enter a number1:");
// a =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("which operation do you want to perfome:");
//c =Convert.ToChar(Console.ReadLine());

//Console.WriteLine("Enter a number2:");
// b = Convert.ToInt32(Console.ReadLine());

//if (c=='+')
//{ Console.WriteLine("Answer :" +  a + b); }

//else if (c=='*')
//{ Console.WriteLine("Answer :" +  a * b); }

//else if (c=='/')
//{ Console.WriteLine("Answer :" +  a / b); }

//else if (c=='-')
//{ Console.WriteLine($"Answer : {a - b}" ); }

//else {
//    Console.WriteLine("these operation is not aviable");
//} 


//switch ()
//{
//    case '+':

//        // code block
//        break;
//    case y:
//        // code block
//        break;
//    default:
//        // code block
//        break;
//}



//int table ,svalue ,evalue;
//Console.WriteLine("which table : ");
//table = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Start value : ");
//svalue = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("End value : ");
//evalue = Convert.ToInt32(Console.ReadLine());


//if (svalue < evalue)
//{

//    for (int i = svalue; i <= evalue; i++)
//    {
//        Console.WriteLine($"{table} * {i} = {table * i}");

//    }
//}
//else
//{
//    Console.WriteLine("your start value is greater then end value !!!!!!!!!");
//}







//char[] cha=new char[5];
// cha [0] = 'z';
// cha [1] = 'a';
//Console.WriteLine(cha[1]);




//string[] friuts = { "apple", "mango", "banana" ,"patato" };

////for (int i = 0; i < friuts.Length; i++) {

////    Console.WriteLine(friuts[2]);
////}
//foreach(string fri in friuts)
//{
//    Console.WriteLine(fri);
//}


//int[] ints = {1,42,435,64,75,86,9,34,233453,474,7,8763,2,2,52452,54,53,5452,52,5,25,3676848,5};
//Array.Sort(ints);
//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}


//string name = "eye";
//string rev = "";

//string name = "Sherry";
//string rev = new string(name.Reverse().ToArray());
////for (int i = name.Length-1; i >=0; i--)
////{
////    //Console.WriteLine(name[i]);

////    rev= rev + name[i];

////    //Console.WriteLine(rev);
////}

//if  (rev == name)
//{
//    Console.WriteLine("match");
//}
//else
//{
//    Console.WriteLine("does not match");
//}


//int[,] table = { {1,4,5 }, {2,3,3},{1,2,4 },{1,2,4 },{ 1, 2, 3} };
//for (int i = 0; i < table.GetLength(0); i++) {

//    for (int j = 0;  j < table.GetLength(1);  j++)
//    {
//Console.WriteLine(table[i,j]);

//    }

//}

//Console.WriteLine("ALI arif")
//


//int a = 3,b = 4,c;
//c = a;
//a = b;
//b = c;
//Console.WriteLine(a); Console.WriteLine(b);





///////////////
//int boxpr,colculatespr,colculatepr;
//Console.WriteLine("Enter bor price:");
// boxpr =Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Enter number of Choco:");
//colculatespr = Convert.ToInt32(Console.ReadLine());

//colculatepr = boxpr / colculatespr;
//Console.WriteLine($"price of chocolate:{colculatepr}");

///////////////
///




///////2.6

//double orgprice, disper,dispr,prices;
//Console.WriteLine("Enter orgnial price:");
//orgprice =Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Enter DISCOUNT PERSENTAAGE:");
//disper =Convert.ToInt32( Console.ReadLine());

//dispr = (disper/100)*orgprice;
//prices = orgprice - dispr;


//Console.WriteLine(orgprice);
//Console.WriteLine(dispr);
//Console.WriteLine(prices);



//////////// even odd
//int number;
//Console.WriteLine("Enter number:");
//number = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine("even");
//}
//else
//{
//    Console.WriteLine("odd");
//}




///////////leep year
//int number;
//Console.WriteLine("Enter number:");
//number = Convert.ToInt32(Console.ReadLine());

//if (number % 4 == 0)
//{
//    Console.WriteLine("leap year");
//}
//else
//{
//    Console.WriteLine("not leap year");
//}





/////////////  covert sec into time

//int usec ;
////Console.WriteLine("Enter seconds:");
////usec = Convert.ToInt32(Console.ReadLine());

////hour = usec / 3600;
////min=hour  60;
////sec = hour / 60;

//Console.WriteLine("Enter seconds:");
//usec = Convert.ToInt32(Console.ReadLine());

//int hours = usec / 3600;
//int minutes = (usec % 3600) / 60;
//int seconds =   usec % 60;

//Console.WriteLine($"{hours} hour(s), {minutes} minute(s), {seconds} second(s)");

/////// 2.9 expression

//int x=0, y=0, z=0;

//y = (x + (3 * z) / 2) + (z * z * z) + (x / z);




//////// 3.1

//int x;

//Console.WriteLine("Enter number:"); 
//x =Convert.ToInt32(Console.ReadLine());

//if (x >=50) {
//    Console.WriteLine("poyer pass a tuu");
//}
// else if(x > 100){
//    Console.WriteLine("ap hamri okat say bahir han");

//}
//else {
//    Console.WriteLine("chal pother dobara kar");
//}



////////3.2

//int gs ,bs,its,ibr ,bns;

//Console.WriteLine("Enter basic salary:");
//bs = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Enter items sold:");
//its = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter items broken:");
//ibr = Convert.ToInt32(Console.ReadLine());

//if (its>=100 && ibr==0)
//{
//    bns = 10000;
//}

//else
//{
//    bns = 0;
//}

//gs = bs + (its * 8) + bns;
//Console.WriteLine($"bahi tari salary = {gs}");

//////////3.4

//string user;
//int unit = 0, unitp = 0, bilamount;
//Console.WriteLine("Enter user type h or c");
//user=Console.ReadLine();


//Console.WriteLine("Enter units");
//unit=Convert.ToInt32(Console.ReadLine());




//if (user == "h")
//{
//    if (unit <= 200)
//    {
//        unitp = 12;
//    }
//    else if(unit>200 && unit <= 400)
//    {
//        unitp = 15;
//    }
//    else
//    {
//        unitp = 40;
//    }
//}
//else if(user=="c")
//{
//    if (unit <= 200)
//    {
//        unitp = 15;
//    }
//    else if (unit > 200 && unit <= 400)
//    {
//        unitp = 20;
//    }
//    else
//    {
//        unitp = 24;
//    }
//}
//else
//{
//    Console.WriteLine("nahi chalna");
//}


//bilamount = unit * unitp;

//Console.WriteLine($"Total bill = {bilamount}");



//int si;

//Console.WriteLine("Enter Number of Students :");
//si=Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < si; i++)
//{
//    int marks = 0;

//    Console.WriteLine("Enter Marks");
//    marks = Convert.ToInt32(Console.ReadLine());

//    if (marks>=80&&marks<=100)
//    {
//        Console.WriteLine("BSSE");
//    }
//   else if (marks >= 70 && marks < 80)
//    {
//        Console.WriteLine("BSCS");
//    }
//    else if (marks >= 60 && marks < 70)
//    {
//        Console.WriteLine("BSIT");

//    }


//}

//////////factorial////////


//int fact=1,number;
//Console.WriteLine("Enter number");
//number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    fact = fact * i;

//}

//Console.WriteLine(fact);





////////4.5/////////




//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {

//        Console.Write($"{j} ");
//    }
//    Console.WriteLine();
//}


//////////4.6///////

//for (int i = 1; i <= 6; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {

//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//for (int i = 1; i <= 6; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*"); // Print "*" without a new line
//    }
//    Console.WriteLine(); // Move to the next line after each row
//}



//for (int i = 5; i > 0; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*"); // Print "*" without a new line
//    }
//    Console.WriteLine(); // Move to the next line after each row
//}




//int sum(int d,int e)
//{
//    int sum = d + e;
//   Console.WriteLine(sum);
//    return sum;

//}

//int a=15,b=5;

//sum(b,a);

//int sum(int[] a)
//{
//    //Console.WriteLine(a[0]);

//    return a[0];
//}

//int[] b = { 1, 2, 3, 4, 5 };


// Console.WriteLine(sum(b));




//int sum(int a,int b)
//{
//    return a + b;
//}


//int minus(int a)
//{
//    return sum(10,20)-a;
//}

//Console.WriteLine( minus(10));



///////////array mainpulation////////////

//int[] a = { 2, 3, 4, 5, 1, 2, 3, 7, 97, 54, 23, 90 };
//int b = 0, c = 0;
//b = a.Max();

//for (int i = 0; i < a.Length; i++)
//{

//    if (a[i] < b)
//    {
//        c = a[i];
//    }
//}

//Console.WriteLine(c);

//int[] a = { 2, 3, 4, 5, 1, 2, 3, 7, 97, 54, 23, 90 };
//int b = 0, c = 0;
//Array.Sort(a);

//Console.WriteLine($"{a[a.Length-2]}");

////////////////Sum of Even Numbers///////////////

//int sum(int[] a)

//{
//    int c=0;
//    for (int i = 0; i<a.Length; i++)
//    {

//        if (a[i] % 2 == 0)
//        {
//            c = c + a[i];
//        }
//    }
//return c;  
//}


//int[] a = { 12, 32, 4, 5, 5, 4, 23, 1, 2 };
//Console.WriteLine($"{sum(a)}");


//////////4. Fibonacci Sequence////////

//int num(int a)
//{
//    int b = 0, c = 1, next;
//    for (int i = 0; i < a; i++)
//    {
//        Console.WriteLine($"{ b}");
//        next = b + c;
//        b = c;
//        c = next;
//    }
//    return a;
//}
//int a=Convert.ToInt32(Console.ReadLine());
//num(a);



///////////5. Prime Number Check//////



//bool IsPrime(int num)
//{
//    if (num <= 1) return false;
//    for (int i = 2; i * i <= num; i++)
//    {

//        Console.WriteLine(i);
//        if (num % i == 0) return false;
//    }
//    return true;
//}

//Console.WriteLine(IsPrime(5)); // Output: true

///////////6. Find Unique Elements///////

//void uniq(int[] a)
//{
//    HashSet<int> result = new HashSet<int>();
//    //result.Add(a[0]);
//    //result.Add(a[1]);
//    foreach (var item in a)
//    {
//        result.Add(item);
//    }
//    foreach (var item in result)
//    {

//    Console.WriteLine(item);
//    }
//}
//int[] b = { 1,1, 2, 3, 4, 5, 6, 6, 123, 34, 64, 2, 32, 1, 4, 5, 23, 4 };
//uniq(b);



//class Teacher
//{
//     public string Tname="Shahroz";

//}class Hr
//{
//     public string Tname="Ruman";

//}
//class Student
//{
//    string Sname="ali";
//    int Sage=23;

//    public static void Main()
//    {
//        Student student = new Student();
//        Console.WriteLine(student.Sname);
//        Console.WriteLine(student.Sage);

//        Teacher teacher = new Teacher();
//        Console.WriteLine(teacher.Tname);

//        Hr hr = new Hr();
//        Console.WriteLine(hr.Tname);
//    }
//}



//class  Student
//{
//   public string Sname="ali";
//  public  void teacher()
//    {
//        Console.WriteLine("Student class");
//    }


//}

//class Teacher:Student
//{
//    public string Tname="shahroz";
//   public void teacher()
//    {
//        Console.WriteLine("Teacher class");
//    }

//}

//class Admin 
//{
//    public static void Main()
//    {
//        Student student = new Student();
//       Teacher teacher = new Teacher();
//        Console.WriteLine(teacher.Tname);
//        Console.WriteLine(teacher.Sname);
//      teacher.teacher();
//      student.teacher();
//    }
//}



//class Student
//{
//    public string Sname;

//   public Student(string s)
//    {
//        Sname = "ali arif";
//    }


//}

//class Admin
//{
//    public static void Main()
//    {
//        Student student = new Student("Ali");
//        //student.Sname = "test";
//        Console.WriteLine(student.Sname);
//    }
////}

///////////constructor///////
//class Car
//{
//    public string modle;
//    public string color;
//    public int year;

//    Car (string Cmodle, string Ccolor, int Cyear)
//    {
//        modle = Cmodle;
//        color = Ccolor;
//        year = Cyear;
//    }

//    ~Car()
//    {

//    }

//    public static void Main()
//    {
//        Car car =new Car("Sonata","Grey",2025);
//        Console.WriteLine(car.modle+car.color+car.year);

//    }
//}


//class Person
//{
//    public string Name // property
//    { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person myObj = new Person();
//        myObj.Name = "Liam";
//        Console.WriteLine(myObj.Name);
//    }
//}


//class Animal  // Base class (parent) 
//{
//    public virtual void animalSound()
//    {
//        Console.WriteLine("The animal makes a sound");
//    }
//}

//class Pig : Animal  // Derived class (child) 
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("The pig says: wee wee");
//    }
//}

//class Dog : Animal  // Derived class (child) 
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("The dog says: bow wow");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal myAnimal = new Animal();  // Create a Animal object
//        Animal myPig = new Pig();  // Create a Pig object
//        Animal myDog = new Dog();  // Create a Dog object

//        myAnimal.animalSound();
//        myPig.animalSound();
//        myDog.animalSound();
//    }
//}

//////////reverse array/////////
//void Rev(int[] a)
//{
//    Array.Reverse(a);
//    foreach (var item in a)
//    {
//        Console.WriteLine(item);
//    }
//}

//int[] a = {1,3,4,5,6};
//Rev(a);


//////////// factorice  an number////////////

//int Fac(int a)
//{

//    int b=1;
//    for (int i = 1; i <= a; i++)
//    {
//        b = b * i;
//    }
//    return b;
//}


//Console.WriteLine(Fac(5));





//void Paramid(int a)
//{
//    for (int i = 1; i <= a; i++)
//    {
//        Console.Write (new string (' ', a - i));
//        Console.WriteLine(new string('*',2*i-1));
//    }
//}
//Paramid(13);


//void PrintPyramid(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        Console.Write(new string(' ', n - i));
//        Console.WriteLine(new string('*', 2 * i - 1));
//    }
//}

//PrintPyramid(7);


//class Teacher
//{
//   public int Id = 1;
//   public string Name = "Shahroz";

//    public Teacher()
//    {
//        Console.WriteLine( "teacher constractur");
//    }
//  public virtual  void Says()
//    {
//        Console.WriteLine("Teacher says haloooo");
//    }

//}



//class Student
//{
//   public int Id=1;
//   public string Nmae = "Ali";

//    public Student()
//    {
//        Console.WriteLine("Student constructur");
//    }

//   public  void Says()
//    {
//        Console.WriteLine("Student says haiiiiiiii");
//    }
//}

//class Principal
//{
//    public static void Main()
//    {
//        Student student = new Student();
//        Teacher teacher = new Teacher();

//        //Console.WriteLine(student.Id);
//        //Console.WriteLine(student.Nmae);
//        //student.Says();


//        //Console.WriteLine(teacher.Id);
//        //Console.WriteLine(teacher.Name);
//        //teacher.Says();




//    }
//}




//abstract class Animal
//{
//    public abstract void animalSound();
//    public void sleep()
//    {
//        Console.WriteLine("Zzz");
//    }
//}

//////////abstract classs////////

//abstract class Teacher
//{
//    public abstract void Says();

//    public void Says1()
//    {
//        Console.WriteLine("Teacher says haloooo");
//    }



//}


//class Student : Teacher
//{
//    public override void Says()
//    {
//        Console.WriteLine("Abstract class funtion");
//    }
//}


//class principal
//{
//    public static void Main()
//    {
//        Student student = new Student();
//        student.Says();
//        student.Says1();
//    }
//}



///////interface //////

//interface IFirstInterface
//{
//    void myMethod(); // interface method
//}

//interface ISecondInterface
//{
//    void myOtherMethod(); // interface method
//}

//// Implement multiple interfaces
//class DemoClass : IFirstInterface, ISecondInterface
//{
//    public void myMethod()
//    {
//        Console.WriteLine("Some text..");
//    }
//    public void myOtherMethod()
//    {
//        Console.WriteLine("Some other text...");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        DemoClass myObj = new DemoClass();
//        myObj.myMethod();
//        myObj.myOtherMethod();
//    }
//}


//class Animal
//{
//    public void Speak()
//    {
//        Console.WriteLine("like very roood");
//    }
//}

//class Main
//{
//    public static void main()
//    {
//    Animal animal = new Animal();

//    }

//}

//interface Ianimal
//{
//    void animalsound();

//}

//class Pig : Ianimal
//{
//    public void animalsound()
//    {
//        Console.WriteLine("pig says wee wee wee wee");
//    }
//}


//class Start
//{
//    public static void Main()
//    {
//        Pig pig = new Pig();    

//        pig.animalsound();
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Input string array
//        string[] data = { "ab", "bc", "cb", "ad", "ae", "de", "da", "ed", "ab", "cb", "ed" };

//        // Call the function
//        var result = CountDuplicates(data);

//        // Print the results
//        Console.WriteLine("Duplicate counts:");
//        foreach (var item in result)
//        {
//            Console.WriteLine($"'{item.Key}' appears {item.Value} time(s)");
//        }
//    }

//    static Dictionary<string, int> CountDuplicates(string[] data)
//    {
//        // Create a dictionary to store counts
//        Dictionary<string, int> counts = new Dictionary<string, int>();

//        foreach (var item in data)
//        {
//            // If the item exists, increment the count
//            if (counts.ContainsKey(item))
//            {
//                counts[item]++;
//            }
//            else
//            {
//                // Otherwise, add it with a count of 1
//                counts[item] = 1;
//            }
//        }

//        // Return the dictionary containing counts
//        return counts;
//    }
//}

//static void CountDuplicates(string[] data)
//{
//    // Create an array to keep track of whether an item is already processed
//    bool[] isProcessed = new bool[data.Length];

//    // Loop through the data array
//    for (int i = 0; i < data.Length; i++)
//    {
//        // Skip if this item is already counted
//        if (isProcessed[i])
//            continue;

//        int count = 1; // Initialize count for the current item

//        // Check for duplicates in the rest of the array
//        for (int j = i + 1; j < data.Length; j++)
//        {
//            if (data[i] == data[j])
//            {
//                count++;            // Increment count if duplicate is found
//                isProcessed[j] = true; // Mark this item as processed
//            }
//        }

//        // Print the result for the current string
//        Console.WriteLine($"'{data[i]}' appears {count} time(s)");
//    }
//}

//// Main Method for Testing
//static void Main(string[] args)
//{
//    // Input array
//    string[] data = { "ab", "bc", "ab", "ad", "bc", "ad", "de" };

//    // Call the function
//    CountDuplicates(data);
//}

//public class ArrData
//{
//    public int Count { get; set; } = 1;
//    public string? Name { get; set; }
//}

//class Checkstring
//{
//    static void Countarr(string[] arr)
//    {
//        List<ArrData> arrData = new List<ArrData>();
//        string[] newArr = new string[arr.Length];
//        int newArrIndex = 0;

//        for (int i = 0; i < arr.Length; i++)
//        {
//            bool found = false;

//            // Check if the current string already exists in newArr
//            for (int j = 0; j < newArrIndex; j++)
//            {
//                if (arr[i] == newArr[j])
//                {
//                    // Increment the count of the existing string
//                    arrData[j].Count++;
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                // Add the new string to newArr and create a new ArrData object
//                newArr[newArrIndex] = arr[i];
//                ArrData newEntry = new ArrData
//                {
//                    Name = arr[i],
//                    Count = 1
//                };
//                arrData.Add(newEntry);
//                newArrIndex++;
//            }
//        }

//        // Print the results
//        foreach (var item in arrData)
//        {
//            Console.WriteLine($"{item.Name} appears {item.Count} time(s)");
//        }
//    }

//    public static void Main()
//    {
//        string[] arr = { "ab", "ab", "ba", "ac", "ca", "ca", "ab" };

//        Countarr(arr);
//    }
//}

////Write a LINQ query to filter out even numbers from a list of integers.


//int[] Filter = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var evenNum=Filter.Where(x => x % 2 == 0);

//foreach (var item in evenNum)
//{
//    Console.WriteLine(item);
//}


/////Given a list of strings, filter out the ones that start with 'A'.


//string[] name = { "ali", "umer", "alina", "fatima" };
//var fnam = name.Where(x => x.StartsWith('a'));
//foreach (var item in fnam)
//{
//    Console.WriteLine(item);
//}



////Find all numbers greater than 10 from a list.


//int[] Filter = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,23,45,2,12,31,32,44 };
//var greternum=Filter.Where(x => x > 10);
//foreach (var item in greternum)
//{
//    Console.WriteLine(item);
//}


//Select only the names from a list of Person objects (Person{Name, Age}).
//  class person
//{

//    public string name { get; set;}
//    public int age {  get; set;}

//}

//class Program
//{
//    public static void Main()
//    {
//        List<person> person = new List<person>
//      {
//         new person{name="ali", age=1},
//         new person{name="ali", age=2},
//         new person{name="ali", age=3},
//         new person{name="ali", age=4},
//         new person{name="ali", age=15},
//         new person{name="ali", age=16},
//         new person{name="ali", age=16},
//         new person{name="ali", age=18},
//         new person{name="ali", age=17},
//      };

//       var age = person.Select(x => x.age);
//        foreach (var item in age)
//        {
//        Console.WriteLine(item);         
//        }

//    }
//}

////Find the sum of all numbers in a list
//int[] sumnum = {1,2,3,4,5};
//var sum = sumnum.Sum();
//Console.WriteLine(sum);


////Sort a list of numbers in ascending order using LINQ.

//int[] Ascending = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,23,45,2,12,31,32,44 };
//var ascendingnum = Ascending.Order();
//foreach (var item in ascendingnum)
//{

//Console.WriteLine(item);
//}

///Count how many elements are in a list.
//int[] element = { 1, 2, 3, 4, 90, 5, 6, 7, 7, 8, 9, 12, 32, 34 };
//var count = element.Count();
//Console.WriteLine(count);

//Convert all strings in a list to uppercase using LINQ.
//int[] element = { 1, 2, 3, 4, 90, 5, 6, 7, 7, 8, 9, 12, 32, 34 };
//var count = element.Count(x=>x==7);
//Console.WriteLine(count);

////Check if a list contains a specific number.
//int[] element = { 1, 2, 3, 4, 90, 5, 6, 7, 7, 8, 9, 12, 32, 34 };
//var count = element.Contains(7);
//Console.WriteLine(count);

//Get the maximum number from a list of integers.
//int[] element = { 1, 2, 3, 4, 90, 5, 6, 7, 7, 8, 9, 12, 32, 34 };
//var count = element.Max();
//Console.WriteLine(count);

////Find the first element in a list that is greater than 50.

//int[] element = { 1, 2, 3, 4, 90, 5, 6, 7, 7, 8, 9, 12, 32, 34 };
//var count = element.FirstOrDefault(x=>x>50);
//Console.WriteLine(count);

///Get a distinct list of numbers from a given list.
//int[] element = { 1, 2, 3, 4, 90, 5, 6, 7, 7, 8, 9, 12, 32, 34 };
//var count = element.Distinct();
//foreach (var item in count)
//{   
//Console.WriteLine(item);
//}

//Select only the ages from a list of Person objects.
///Find the average of a list of numbers.
//int[] number = { 1, 2, 3, 4, 5, 6 };
//var average=number.Average();
//Console.WriteLine(average);


////Select the first 5 elements from a list.
//int[] number = {1,2,3,4,5,6,7};
//var fnumber=number.Take(5);
//foreach (var item in fnumber)
//{

//Console.WriteLine(item);
//}

//Skip the first 5 elements from a list.
//int[] number = { 1, 2, 3, 4, 5, 6, 7 };
//var fnumber = number.Skip(5);
//foreach (var item in fnumber)
//{

//    Console.WriteLine(item);
//}

//Join two lists and return a single list.

//int[] a = { 1, 2, 3, 4, 5 };
//int[] b = { 6, 7, 8, 9, 0 };

//var sum = a.Union(b);

//foreach (var item in sum)
//{

//Console.WriteLine(item);
//}

//Find all words in a list that contain more than 5 characters.
//string[] name = { "apple", "mango", "banana", "kala" };
//var listname = name.Where(x => x.Length >= 5);
//foreach (var item in listname)
//{
//    Console.WriteLine(item);
//}


//Find the first element that starts with 'B', or return null if none exist.
//string[] A = { "ALI", "blii", "nill", "bill", "aill" };
////var b = A.Where(x => x.StartsWith('b')).FirstOrDefault();
//var b = A.FirstOrDefault(x => x.StartsWith('b'));

//Console.WriteLine(b);



////Check if all numbers in a list are positive.
//int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, -1, -3, -6 };
//var b=a.Where(x => x > 0);
//foreach (var item in b)
//{
//    Console.WriteLine(item); 
//}


//Check if at least one number in a list is greater than 100.
//int[] a = { 1, 2, 3, 45, 6464, 656, 7, 76, 87, 100 };
//var b=a.Any(x=>x>100);
//Console.WriteLine(b);

//Return a new list where each number is squared.
//int[] a = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9 };
//var b=a.Select(x => x*x);
//foreach (var item in b)
//{
//    Console.WriteLine(item);
//}

////Convert a list of numbers to a comma-separated string.
//int[] a = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9 };
//var b = string.Join(",", a);

//foreach (var item in b)
//{
//    Console.WriteLine(item);
//}

//Filter a list of objects where IsActive == true.
//class person
//{

//    public string name { get; set; }
//    public int age { get; set; }
//    public bool isActive { get; set; }

//}

//class Program
//{
//    public static void Main()
//    {
//        List<person> person = new List<person>
//        {
//         new person{name="ali", age=1},
//         new person{name="ali", age=2,isActive=true},
//         new person{name="ali", age=3},
//         new person{name="ali", age=4 ,isActive=true},
//         new person{name="ali", age=15},
//         new person{name="ali", age=16},
//         new person{name="ali", age=16},
//         new person{name="ali", age=18},
//         new person{name="ali", age=17},
//        };

//        var age = person.Where(x => x.isActive);
//        foreach (var item in age)
//        {
//            Console.WriteLine(item.age);
//        }

//    }
//}

////Get the length of each word in a list of strings.
//string[] name = { "ali", "shahroz", "zeshen" };
//var b=name.Select(x => x.Length);
//foreach (var item in b)
//{
//    Console.WriteLine(item);
//}

//Sort a list of people by age in descending order.
//class person
//{

//    public string name { get; set; }
//    public int age { get; set; }

//}

//class Program
//{
//    public static void Main()
//    {
//        List<person> person = new List<person>
//      {
//         new person{name="ali", age=1},
//         new person{name="ali", age=2},
//         new person{name="ali", age=3},
//         new person{name="ali", age=4},
//         new person{name="ali", age=15},
//         new person{name="ali", age=16},
//         new person{name="ali", age=16},
//         new person{name="ali", age=18},
//         new person{name="ali", age=17},
//      };

//        var age = person.OrderByDescending(x => x.age);
//        foreach (var item in age)
//        {
//            Console.WriteLine(item.name+item.age);
//        }

//    }
//}

//Reverse a list of strings using LINQ.
//int[] number = {1,2,3,4,5,6,7,8,9,0,10};
//var r=number.Reverse();
//foreach (var item in r)
//{
//    Console.WriteLine(item);
//}

///Find the second largest number in a list.
//int[] number = { 1, 2, 3, 4 };
//var sl=number.OrderDescending().Skip(1).Take(1);
//Console.WriteLine(sl);

///Select the top 3 highest salaries from an employee list.
//class person
//{

//    public string name { get; set; }
//    public int age { get; set; }
//    public int salary { get; set; }

//}

//class Program
//{
//    public static void Main()
//    {
//        List<person> person = new List<person>
//      {
//         new person{name="ali", age=1,salary=2399},
//         new person{name="ali", age=2,salary=2299},
//         new person{name="ali", age=3,salary=2439},
//         new person{name="ali", age=4,salary=1329},
//         new person{name="ali", age=5,salary=9299},
//         new person{name="ali", age=6,salary=7799},
//         new person{name="ali", age=7,salary=1009},
//         new person{name="ali", age=8,salary=8699},
//         new person{name="ali", age=9,salary=9999},
//         new person{name="ali", age=10,salary=5009},

//      };

//        var age = person.OrderByDescending(x => x.salary).Take(3);
//        foreach (var item in age)
//        {
//            Console.WriteLine(item.name+" "+item.age);
//        }

//    }
//}


////Remove all duplicates from a list of string
//string[] name = { "ali", "umer", "ali", "umer", "sharoz" };
//var d = name.Distinct();
//foreach (var item in d)
//{
//    Console.WriteLine(item);
//}


/////Group a list of numbers into even and odd.
//int[] number = { 1, 2, 3, 4, 5, 6, 10, 7, 8, 8, 9 };
//var a = number.GroupBy(x => x % 2 == 0 ? "Even" : "odd");
//foreach (var item in a)
//{
//    Console.WriteLine($"{item.Key}: {string.Join(", ", item)}");
//}


////Group a list of people by their age
//class peoples
//{
//    public string name {  get; set; }
//    public int age {  get; set; }

//}

//class program
//{
//    public static void Main()
//    {
//        List<peoples> peoples = new List<peoples>
//        {
//            new peoples{name="ali",age=15},
//            new peoples{name="umer",age=25},
//            new peoples{name="usman",age=35},
//            new peoples{name="baber",age=45},
//            new peoples{name="shahroz",age=55},
//            new peoples{name="ruman",age=65},
//            new peoples{name="zeshen",age=53},
//            new peoples{name="saqib",age=52},
//            new peoples{name="ruman",age=55},
//            new peoples{name="hamza",age=85},
//            new peoples{name="ahmad",age=85},
//        };
//        //var alder = peoples.GroupBy(x=>x.age>0 ?"":"");
//        var groupedByAge = peoples.GroupBy(p => p.age);


//        foreach (var person in groupedByAge)
//        {
//            Console.WriteLine($"{person.Key}:{string.Join(" ",person.Select(p=>p.name))}");

//        }
//    }
//}



//Join two lists of objects using a common property (like ID).

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int DeptId { get; set; }
//}
//class Department
//{
//    public int Id { get; set; }
//    public string DepartmentName { get; set; }
//}

//class Program
//{
//    public static void Main()
//    {
//        List<Employee> employee = new List<Employee> {
//            new Employee { Id = 1, Name = "Alice", DeptId = 1 },
//            new Employee { Id = 2, Name = "Bob", DeptId = 2 },
//            new Employee { Id = 3, Name = "Charlie", DeptId = 3 },
//            new Employee { Id = 4, Name = "David", DeptId = 1 }
//        };

//        List<Department> departments = new List<Department> {
//         new Department { Id = 1, DepartmentName = "HR" },
//            new Department { Id = 2, DepartmentName = "IT" },
//            new Department { Id = 4, DepartmentName = "Finance" }
//        };


//        var joinedList = from e in employee
//                         join d in departments on e.DeptId equals d.Id
//                         select new { e.Name, d.DepartmentName };

//        foreach (var item in joinedList)
//        {
//            Console.WriteLine($"Employee :{item.Name}, Department :{item.DepartmentName}");
//        }


//    }

//}


////Select only unique first letters of words in a list.
//string[] latters = { "leet", "alee", "umer" };
//var a = latters.Select(x => x[0]).Distinct();
//foreach (var item in a)
//{
//Console.WriteLine(item);

//}



//Find all employees who have a salary between 50,000 and 80,000.
//class person
//{

//    public string name { get; set; }
//    public int age { get; set; }
//    public int salary { get; set; }

//}

//class Program
//{
//    public static void Main()
//    {
//        List<person> person = new List<person>
//      {
//         new person{name="ali", age=1,salary=2399},
//         new person{name="ali2", age=2,salary=2299},
//         new person{name="aliii", age=3,salary=2439},
//         new person{name="alirt", age=4,salary=1329},
//         new person{name="aliwrrf", age=5,salary=9299},
//         new person{name="alisfsfg", age=6,salary=7799},
//         new person{name="aliwe", age=7,salary=1009},
//         new person{name="alifd", age=8,salary=8699},
//         new person{name="alfdi", age=9,salary=9999},
//         new person{name="ali", age=10,salary=5009},

//      };

//        var a = person.Where(x => x.salary >= 3000 && x.salary <= 9000);
//        foreach (var item in a)
//        {
//            Console.WriteLine(item.name);
//        }

//    }
//}




////Find all employees who have a salary between 50,000 and 80,000.
//class person
//{

//    public string name { get; set; }
//    public int age { get; set; }

//}

//class Program
//{
//    public static void Main()
//    {
//        List<person> person = new List<person>
//      {
//         new person{name="ali", age=1},
//         new person{name="ali2", age=2},
//         new person{name="aliii", age=3},
//         new person{name="alirt", age=4},
//         new person{name="aliwrrf", age=5},
//         new person{name="alisfsfg", age=6},
//         new person{name="aliwe", age=7},
//         new person{name="alifd", age=8},
//         new person{name="alfdi", age=9},
//         new person{name="ali", age=10},

//      };

//        var a = person.OrderByDescending(x => x.name.Length).FirstOrDefault();
//        if (a != null)
//        {
//            Console.WriteLine(a.name);
//        }
//        else
//        {
//            Console.WriteLine("null");
//        }
//    }
//}



//class Department
//{
//    public int DepartmentId { get; set; }
//    public string? DepartmentName { get; set; }
//}


//class Employee
//{
//    public int EmployeeId { get; set; }
//    public string? EmployeeName { get; set; }

//    public int DepartmentId { get; set; }

//}


//class Program
//{
//    public static void Main()
//    {
//        //List<Department> department = new List<Department>
//        //{
//        //    new Department(DepartmentId=1,DepartmentName="Cs"),
//        //    new Department(DepartmentId=2,DepartmentName="IT"),
//        //};

//        //List<Department> department = new List<Department>
//        //{
//        //    new Department { DepartmentId = 1, DepartmentName = "CS" },
//        //    new Department { DepartmentId = 2, DepartmentName = "IT" }
//        //};

//        //var employee = new List<Employee> {
//        //new Employee { EmployeeId = 1,EmployeeName="Ali" ,DepartmentId=1},
//        //new Employee { EmployeeId = 2,EmployeeName="Sherry" ,DepartmentId=1},
//        //new Employee { EmployeeId = 3,EmployeeName="Bilal" ,DepartmentId=1},

//        //};



//        //var list = from d in department
//        //           join e in employee
//        //           on d.DepartmentId equals e.DepartmentId
//        //           select new { e.EmployeeName, d.DepartmentName };

//        //var list2 = department.Join(employee, d => d.DepartmentId, e => e.DepartmentId, (d, e) => new
//        //{
//        //    e.EmployeeName,d.DepartmentName

//        //});



//        //foreach (var item in list2)
//        //{
//        //    Console.WriteLine(item.EmployeeName+" "+item.DepartmentName);
//        //}


var list = new List<string> { "ab", "bc", "ab", "da" };


string newString = string.Join(" ", list);


var list1 = newString.Split(" ").GroupBy(x => x).Select(g => new { Word = g.Key, Count = g.Count() });


foreach (var item in list1)
{
    Console.WriteLine(item.Word + " " + item.Count);
}


//    }
//}



//string name = "eye";
//string rev = "";
//for (int i = name.Length - 1; i >= 0; i--)
//{
//    //Console.WriteLine(name[i]);

//    rev = rev + name[i];

//    //Console.WriteLine(rev);
//}

////string name = "Sherry";
////string rev = new string(name.Reverse().ToArray());

//if (rev == name)
//{
//    Console.WriteLine("match");
//}
//else
//{
//    Console.WriteLine("does not match");
//}




