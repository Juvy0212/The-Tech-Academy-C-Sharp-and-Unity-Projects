using System;

namespace ArithmeticOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declare and initialize two numbers
			//int number1 = 10;
			//int number2 = 5;

			// Addition
			//int sum = number1 + number2;
			//Console.WriteLine("Addition: " + number1 + " + " + number2 + " = " + sum);

			// Subtraction
			//int difference = number1 - number2;
			//Console.WriteLine("Subtraction: " + number1 + " - " + number2 + " = " + difference);

			// Multiplication
			//int product = number1 * number2;
			//Console.WriteLine("Multiplication: " + number1 + " * " + number2 + " = " + product);

			// Keep the console window open
			//Console.ReadLine();

			//string firstName = "Maxine";
			//string secondName = "Matthew";
			//Console.WriteLine("I have two babies their name are " + firstName + secondName);
			//Console.ReadLine();

			//int total = 5 + 10;
			//int otherTotal = 12 + 22;
			//int combined = total + otherTotal;
			//Console.WriteLine(combined);
			//Console.ReadLine();

			//int difference =10 -5;
			//Console.WriteLine(difference);
			//Console.ReadLine();


			//int product = 10 * 5;
			//Console.WriteLine(product);
			//Console.ReadLine();


			//int quotient = 10 / 5;
			//Console.WriteLine(quotient);
			//Console.ReadLine();

			//int reminder = 11 / 5;
			//Console.WriteLine(quotient);
			//Console.ReadLine();

			//bool truOrFalse = 12 == 1;
			//Console.WriteLine(truOrFalse);
			//Console.ReadLine();

			//int roomTemperature = 70;
			//int currentTemperature = 70;

			//bool isWarm = currentTemperature >= roomTemperature;
			//Console.WriteLine(isWarm);
			//Console.ReadLine();

			//Multiplies input by 50
			//Console.WriteLine("Write a number that will be multiplied by 50: ");
			//string input1 = Console.ReadLine();

			////converts string to double 
			//if (double.TryParse(input1, out double result))
			//{
			//	//Multiply by 50 and print result
			//	double multiplyReseult = result * 50;
			//	Console.WriteLine("Result of multiplying by 50: " + multiplyReseult);

			//	//take an input
			//	Console.WriteLine("Please enter another number: ");
			//	string input2 = Console.ReadLine();
			//	if (double.TryParse(input2, out double result2)) {
			//		double addition = result2 + 25;
			//		Console.WriteLine("Result of adding 25: " + addition);
			//	}

			//	Console.WriteLine("Please enter another number: ");
			//	string input3 = Console.ReadLine();
			//	if (double.TryParse(input3, out double result3))
			//	{ 
			//		double quotient = result3 / 25;
			//		Console.WriteLine("Result of " + result3 +" divided by 25 = " + quotient);
			//	}
			//	Console.WriteLine("Please enter another number: ");
			//	string input4 = Console.ReadLine();
			//	if (double.TryParse(input4, out double result4))
			//	{ 
			//		 bool  isGreater = result4 > 25;
			//		Console.WriteLine("Is" + result4 + " is greater than 25?" + isGreater);
			//	}
			//	Console.WriteLine("Please enter another number: ");
			//	string input5 = Console.ReadLine();
			//	if (double.TryParse(input5, out double result5)) {
			//		double remainderResult =  result5 % 7;
			//		Console.WriteLine("Remainder when divided by 7: " + remainderResult);

			//	}
			//}

			Console.WriteLine("Anonymous Income Comparison Program");
			Console.WriteLine("Person 1: ");
			Console.WriteLine("Enter Hourly Rate: ");
			int inthourlyRate = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Hours worked per week: ");
			int inthourlyworked = int.Parse(Console.ReadLine());


			Console.WriteLine("Person 2: ");
			Console.WriteLine("Enter Hourly Rate: ");
			int inthourlyRate2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Hours worked per week: ");
			int inthourlyworked2 = int.Parse(Console.ReadLine());


			int person1 = inthourlyRate * inthourlyworked;
			Console.WriteLine("Annual salary of Peron 1: " + person1);

			int person2 = inthourlyRate2 * inthourlyworked2;
			Console.WriteLine("Annual salary of Peron 1: " + person2);

			bool moreMoney = person1 > person2;
			Console.WriteLine("Does Person 1 makes more money than person 2? " + moreMoney);

			Console.ReadLine();
		}
	}
}
