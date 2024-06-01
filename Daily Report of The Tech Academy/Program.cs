using System;


    internal class Program
    {
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string coursename = Console.ReadLine();

        Console.WriteLine("What page number?");
        int pageNumber = int.Parse(Console.ReadLine());

        //collect help and convert to bool
		Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
        bool needHelp = bool.Parse(Console.ReadLine());

		// Collect positive experiences
		Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
		string positiveExperiences = Console.ReadLine();

		// Collect additional feedback
		Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
		string otherFeedback = Console.ReadLine();

		// Collect study hours and convert to double
		Console.Write("How many hours did you study today? ");
		double studyHours = double.Parse(Console.ReadLine());

		// Print thank you message
		Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

		// Prevent the console from closing immediately
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}
}
