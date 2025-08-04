using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Adah Ayuomi", "Being a good husband");
        // Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Emmauel Adah", "Paternal Responsibilty", "5.2", "2-5");
        // Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Lawrence Okon", "Music Theory", "Understanding Complex Time Signatures");
        Console.WriteLine(assignment2.GetWritingInformation());
    }
    
}