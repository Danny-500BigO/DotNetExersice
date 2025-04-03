// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{

     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Hello World!");

               //c# variables

               //int(store the single values)
               int numbers = 1;

               //double(store the vlaue float,decimal)
               double decimalValue = 23.55;

               //char(store single character with single quatation)
               char firstLetter = 'a';

               //string(store line fo text with double quatation)
               string name = "Hello World";

               //bool(store one value from both true or false)
               bool lightOn = true;
               bool LightOff = false;

               int x = 5, y = 6, z = 7;
               Console.WriteLine(x + y + z);



               //identifiers(identifiers mean the name of the variable which we given it should be meaningfull and it should br understandable can can start variable name with letter or underscore and firstletter should be lowercase and seconf one should be Uppercase and varibale name should not start with  int,double,bool(reserved words) and variable names are casesensitive myVar and myvar is not same it two different)



               //user inputs

               Console.WriteLine("Please Enter Your Age");

               int age = Convert.ToInt32(Console.ReadLine());


               Console.WriteLine("Your Age is: " + age);


               ///Math get the maximum Value
               int MaximumValue = Math.Max(5, 10);
               Console.WriteLine(MaximumValue);

               //Math.Min(check ther moinimum value)
               int MinimumValue = Math.Min(12, 24);
               Console.WriteLine(MinimumValue);

               //Math.Sqrt(this method output the quareb root of the given value)
               int SquareRootValue = Convert.ToInt32(Math.Sqrt(81));
               Console.WriteLine(SquareRootValue);

               //Math.Abs(this methd we use for output the absoulute Positive Values in given value)
               double AbsoulutValue = Math.Abs(-6.2);
               Console.WriteLine(AbsoulutValue);

               //Math.Round(Round the given number to nearest whole number)
               double RoundValue = Math.Round(5.4678);
               Console.WriteLine(RoundValue);


               //Strings->>><<<--

               //{string interpolation}
               string firstName = "Dhanushka";
               string lastName = "Bandara";

               string Fullname = $"My Fullname is :  {firstName} {lastName} ";

               Console.WriteLine(Fullname);


               //Access String(acees string use for output the rewuired letter or letters in given string ,in here using index of the string )
               string fruit = "Apple";
               char outPutOfAccessString = fruit[3];
               Console.WriteLine(outPutOfAccessString);

               //IndexOf (this method use for find the index of the characteres)

               string nameOfCountry = "SriLanka";
               int outputOfIndex = nameOfCountry.IndexOf('a');

               Console.WriteLine(outputOfIndex);


               //SubString()(this method use for ctracts the characters from string start from specified character position and return new string)

               string yourName = "Long King";

               int indexofKing = yourName.IndexOf('K');

               string subString = yourName.Substring(indexofKing);

               Console.WriteLine(subString);



               //Booleans

               bool isCSharp = true;
               bool isCodTate = false;

               //boolean expression(this is use to get out put true or false by using the comparing the values)

               //< or >
               int numberOne = 10;
               int numberTwo = 20;

               bool maximumValue = numberOne < numberTwo;

               Console.WriteLine(maximumValue);

               //==

               int firstNumber = 10;
               int sencondNumber = 30;

               bool checkTheNumbers = firstNumber == sencondNumber;
               Console.WriteLine(checkTheNumbers);

               //ACTIVITY

               int yourAge;
               int votingAge = 18;


               Console.WriteLine("Please Enter Your Name");

               string userName = Console.ReadLine();

               Console.WriteLine("Please Enter Your Age");

               yourAge = Convert.ToInt32(Console.ReadLine());

               if (yourAge >= votingAge)
               {

                    Console.WriteLine($"{userName} You are eligible to vote for next election");
               }
               else
               {
                    Console.WriteLine($"{userName} You are Not eligible to vote for the election");
               }


               //if,else,elseif,switch conditions

               //if,else,elseif condidion is for check the codition is true?

               int intergerNumber = 4;
               int integerNumberTwo = 5;

               if (intergerNumber > integerNumberTwo)
               {

                    Console.WriteLine("your number is", intergerNumber);

               }
               else
               {

                    Console.WriteLine("Please Try in next condtion");

               }


               //elseif condition

               int ageOfMan = 23;
               int ageOfWoman = 18;

               if (ageOfMan == ageOfWoman)
               {
                    Console.WriteLine("we will give you same postion");
               }
               else if (ageOfMan > ageOfWoman)
               {

                    Console.WriteLine("Man is on Highest position of then world");

               }
               else
               {
                    Console.WriteLine("neither both in any postion");
               }


               //Switch Statement
               //switch Condtion work as a this condtion will true only one peration among different

               string nameOfDay = "Monday";

               switch (nameOfDay)
               {

                    case "tuesday":

                         Console.WriteLine("its's Tuesday");
                         break;

                    case "wednesday":

                         Console.WriteLine("it's Wednesday");
                         break;

                    case "monday":

                         Console.WriteLine("it's Monday");
                         break;

                    case "friday":

                         Console.WriteLine("it's Friday");
                         break;

                    case "thursday":

                         Console.WriteLine("its's thursday");
                         break;

                    default:

                         Console.WriteLine("we couldn't find your day");
                         break;
               }


               //loop loop is a block of code which exucute until the expexcted value reached

               //while loop(this loop is runing until the cosnition is true)

               int numberOfPeople = 0;

               while (numberOfPeople <= 8)
               {
                    Console.WriteLine("number of people count is: " + numberOfPeople);
                    numberOfPeople++;
               }


               //do while loop(in this loop runs the do code block once till while condtion true)

               int myAge = 30;

               do
               {
                    myAge++;

                    Console.WriteLine("your age is : " + myAge);

               }

               while (myAge <= 32);



               //for loop(when we know the limit of the condition we can use the for loop)

               //for(initialization ; condition ;  increment){}

               for (int i = 0; i < 5; i++)
               {

                    Console.WriteLine("The out put of the i value is : " + i);

               }

               //Nested Loop(nested loop means loop inside the loop the first loop run one time each and inside loop run until the codition false)

               for (int i = 0; i < 2; i++)
               {

                    Console.WriteLine("second loop ");

                    for (int j = 0; j < 3; j++)
                    {
                         Console.WriteLine("*");
                    }

               }


               //foreach(this loop use for loop through the elements of an array(dataset))

               //foreach(datatype variablename in array name){}

               int[] monthsForTheYear = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];

               foreach (int i in monthsForTheYear)
               {
                    Console.WriteLine("for each loop out put is " + i);
               }


               //break(use the break for jump out of the loop)

               for (int i = 0; i <= 5; i++)
               {

                    if (i == 4)
                    {
                         break;
                    }

                    Console.WriteLine("jumped it out of break" + i);
               }


               //continue(continue statment just break/skip one condition in the loop and continue from other in the loop)

               for (int c = 0; c <= 10; c++)
               {

                    if (c == 5)
                    {
                         continue;
                    }

                    Console.WriteLine("Skip wihtout 5 and start from 6 " + c);

               }

               //Array(array is a set of data(multiple values in single variable) which store in one variable)

               // let see how to decalre and array in c# 
               // first declare the array type with square bracket  string[]
               // next array name 
               // string[] typeOfCrs = {"honda", "Mitsuibishi" , "Toyota" , "BMW" , "Volvo" }

               string[] typeofCars = {"honda", "Mitsuibishi" , "Toyota" , "BMW" , "Volvo"};

               Console.WriteLine(typeofCars[1]);


               //loop through an array
               //in this section we can loop throufh an array using length specify howmany times array should loop
               //for loop

               int[] oddNumbers = {1,3,5,7,9,10,11};

               for(int i = 0 ; i < oddNumbers.Length ; i++)
               {

                    Console.WriteLine("Odd numbers in loop are: " + oddNumbers[i]);

               }

               //foreach loop
               //no need to write iteration for this loop and in this loop 'i' consider as index of an array and loop the array elemnt acording to index

               foreach(int i in oddNumbers)
               {
                    Console.WriteLine("This is inside the for loop " + i);
               }


              //sorting Arrays

              //sorting arrays means sorts array alphebitically or accending order 

              int[] decendingNumbers = {2,3,1,4,5,9,8,7};

              Array.Sort(decendingNumbers);

              foreach(int i in decendingNumbers)
              {

               Console.WriteLine("This is the result of array sort" + i);

              }

              //system.linq.namspace(min,max,sum)

          //declare an array
          //initialize it later then we have to use new keyword for that
          int[] newOddNumbers ;

          newOddNumbers  = new  int[] {1,3,5,7};

          string[] peoples;

          peoples = new string[] {"Danny","panny", "Canny"};


          int[] firstNineNumbers;

          firstNineNumbers = new int[] {1,2,3,4,5};

          firstNineNumbers = new int[] {1,2,3,4,5,6,7,8,9};


          int[] luckyNumber;

          luckyNumber = new int[] {9,0,5};


          //MultiDimentional Array
          //multi dimentional arrays mean we can store data as tabular form,otherwise store data like in the table. in rows and columns.
          //we can have two dimenstion array and three dimentional array. but mostly we use two dimentional arrays.

          //Two Dimentional Array(2D Arrays)(we use one comma in squre bracket for two dimentioanl arrays)
          //each array is hase a index 

          int[,] numberOfAges = {{1,2,3,4},{1,2,3,4}};
                                   //0      //1

          Console.WriteLine(numberOfAges[0,2]);
          Console.WriteLine(numberOfAges[1,3]);

          //Three Dimensional Array(we use ,, comma inside a squre bracket in three dimensional array.however mostly we use two dimensional array)

          //changing elment of 2D Array
          int[,] gradesofSchool = {{1,2,3,4,5}, {6,7,8,9,0}};
          gradesofSchool[0,2] = 4;
          Console.WriteLine(gradesofSchool[0,2]);

          //loop through the 2D Arrays
          string[,] nameOfDogs = {{"RONY","HONY","ROY"},{"SOY", "KAI","JOJO"}};

          foreach(string i in nameOfDogs)
          {

               Console.WriteLine(i);
          }

          //for loop

          int[,] positiveNumbers = {{5,4,3},{2,1,0}};

          for(int i = 0 ; i < positiveNumbers.GetLength(0) ; i++){

               for(int j = 0; j < positiveNumbers.GetLength(1) ; j++)
               {

                    Console.WriteLine(positiveNumbers[i,j]);
               }
          }


          }
     }

}

