﻿// See https://aka.ms/new-console-template for more information
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

     if(ageOfMan == ageOfWoman)
     {
          Console.WriteLine("we will give you same postion");
     }
     else if(ageOfMan > ageOfWoman)
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

switch(nameOfDay)
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


          }
     }

}

