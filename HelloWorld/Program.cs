// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Runtime.InteropServices;

namespace HelloWorld{

class Program{
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
        string name  = "Hello World";

        //bool(store one value from both true or false)
        bool lightOn = true;
        bool LightOff =  false;

        int  x =  5 ,  y = 6 , z = 7;
        Console.WriteLine(x+y+z);



        //identifiers(identifiers mean the name of the variable which we given it should be meaningfull and it should br understandable can can start variable name with letter or underscore and firstletter should be lowercase and seconf one should be Uppercase and varibale name should not start with  int,double,bool(reserved words) and variable names are casesensitive myVar and myvar is not same it two different)



//user inputs

Console.WriteLine("Please Enter Your Age");

int age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Your Age is: " + age);


///Math get the maximum Value
int MaximumValue = Math.Max(5,10);
Console.WriteLine(MaximumValue);

//Math.Min(check ther moinimum value)
int MinimumValue = Math.Min(12,24);
Console.WriteLine(MinimumValue);

//Math.Sqrt(this method output the quareb root of the given value)
int  SquareRootValue = Convert.ToInt32(Math.Sqrt(81));
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
string fruit =  "Apple";
char outPutOfAccessString = fruit[3];
Console.WriteLine(outPutOfAccessString);

//IndexOf (this method use for find the index of the characteres)

string nameOfCountry = "SriLanka";
int outputOfIndex =  nameOfCountry.IndexOf('a');

Console.WriteLine(outputOfIndex);


//SubString()(this method use for ctracts the characters from string start from specified character position and return new string)

string yourName =  "Long King";

int indexofKing =  yourName.IndexOf('K');

string subString =  yourName.Substring(indexofKing);

Console.WriteLine(subString);




     }
}

}

