using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Assignment15
{
    internal class Program
    {
        //Demo

        #region Methods - Using VAR VS DYNAMIC
        ////static var print (var x) //Invalid
        ////{
        ////    return x; 
        ////}

        ////static dynamic print (dynamic x)
        ////{
        ////    return x;
        ////} 
        #endregion
        static void Main(string[] args)
        {
            #region Keyword : Var
            // //C# Keywords : Implicity typed local variable [ Var - Dynamic ]

            // //Var

            // var Data01 = "Ahmed"; //The compiler will know the Datatype of local Variable
            //                       //Based on the intial Value
            //                       //Canoot intialized local value with Null
            //                       // Cannot Use Var Keyword as parameter or ReturnType
            // //  var X; //Invalid - X must be intialized

            //// Data01 = 12; //Invalid already intailized as String 
            #endregion

            #region Keyword : Dynamic 
            //dynamic Data02 = "Ahmed"; //Like var in Js

            ////CLR will Detect Datatype of local Variable Based on the Last Value , At RunTime.

            ////Don't Need To Be Intilaized
            //// Can Intialize the local value with Null
            ////can change Datatype of local Variable After Intialization
            //// Can Use Dynamic Keyword as parameter or ReturnType
            //Data02 = 12;
            //Data02 = 'a';
            //Data02 = null;

            //Console.WriteLine(Data02.GetType().Name);



            #endregion

            #region Extension Methods
            ////Extension Methods

            //int Number = 12345; //54321 

            //// var Result = IntExtension.Reverse(Number);


            //Console.WriteLine(Number.Reverse());//Use the intger as caller 
;

            #endregion

            #region Anonymous Types

            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test",
            //    Salary = 12220

            //};

            // var Emp01 = new { Id = 1, Name = "Test", Salary = 12220.0 }; //AnonymousType

            // var Emp02 = new { Id = 2, Name = "Test2", Salary = 12900.0 };

            // var Emp03 = new { Id = 2, Name = 232, Salary = 12900.0 };

            // //Console.WriteLine(Emp01);
            // Console.WriteLine(Emp01.GetType().Name);//<> f__AnonymousType0`3

            // Console.WriteLine(Emp02.GetType().Name);// <> f__AnonymousType0`3

            // Console.WriteLine(Emp03.GetType().Name); // <>f__AnonymousType0`3

            // //The Same Anonymous As long As:
            // //1. The property Naming [Case Sensetive]
            // //2. The property Order
            // //3. The property DataType

            //// Emp01.Id = 12; //Invalid


            #endregion

            #region What is LINQ

            ////LINQ : Language Intgrated Query 
            ////     : +40 Extension Methods (LINQ Operator) Using Against any data [data in sequence] regardless the datastore
            ////     : 13 Category
            ////     : LINQ Operator Exsits class "Enumerable"

            //// Sequence: Object class Implements Interface "IEnumerable"

            ////Local Sequence :L2O  , L2XML
            ////Remote Sequence:L2EF 

            ////Input Sequence --> LINQ Operator --> Output Sequence
            ////Input Sequence --> LINQ Operator --> One Value


            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6};
            ////var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

            //var Result = Numbers.Where(N => N % 2 == 0);

            //Numbers.Any(); //Input Sequence --> LINQ Operator --> One Value

            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion


            #region LINQ SYNTAX

            //LINQ SYNTAX
            //1. Fluent Syntax
            //Use LINQ Methods
            //1.1 LINQ Operator As => Class Member Through Class "Enumerable"
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            ////var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

            ////var Result = Numbers.Where(N => N % 2 == 0);



            ////1.2 LINQ Operator As => Extension Methods Through The Sequence [Recomended] 

            //var Result = Numbers.Where(N => N % 2 == 0);

            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n + " ");
            //}

            //Query Syntax [Query Expression] Like SQL Style
            //Start With Form
            //end with Select Or Group by
            //Query syntax easir than the fluent [joins,groupby , let ,into]
            //List<int> Numbers = new List<int>() { 9,8,7,6,5,4,3,2,1};

            //var Result = from N in Numbers
            //             where N % 2 == 0
            //             select N;


            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n + "");
            //}




            #endregion

            #region LINQ Execution Wys
            //LINQ Execution ways
            //1. Differe Execution ways : 10 Category
            //2. Immidiate Execution ways : 3 Ways [Elements Operators - Casting Operators - Aggregate Operators]

            //List<int> Numbers = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //var Result = Numbers.Where(N => N % 2 == 0); // where is Differed

            //Numbers.AddRange(new int[] { 10, 11, 12 });

            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n + "");
            //}

            //List<int> Numbers = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //var Result = Numbers.Where(N => N % 2 == 0).ToList(); //

            //Numbers.AddRange(new int[] { 10, 11, 12 });

            //foreach (int n in Result)
            //{
            //    Console.WriteLine(n + "");
            //}


            #endregion




        }
    }
}
