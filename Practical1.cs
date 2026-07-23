using System;

namespace AdmissionManagement
{
    // 1. CLASS: This is the blueprint for creating a student record.
    public class Student
    {
        // 2. ACCESS MODIFIERS: 'private' means these variables are hidden from the outside world.
        private int studentId;
        private string fullName;
        private string course;
        private bool isAdmitted;

        // 3. CONSTRUCTOR: A special method that runs automatically when a new Object is created.
        public Student(int id, string name, string enrolledCourse)
        {
            studentId = id;
            fullName = name;
            course = enrolledCourse;
            
            isAdmitted = true; 
        }

        // 'public' means this method can be called from outside the class.
        public void DisplayStudentDetails()
        {
            Console.WriteLine("--- Admission Record ---");
            Console.WriteLine($"Student ID : {studentId}");
            Console.WriteLine($"Name       : {fullName}");
            Console.WriteLine($"Course     : {course}");
            
            Console.WriteLine($"Status     : {(isAdmitted ? "Confirmed" : "Pending")}");
            Console.WriteLine("------------------------\n");
        }
    }

    // The main program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Admission Management Module\n");

            // 4. OBJECT: Creating actual instances of the Student class.
            Student student1 = new Student(101, "Aarav Patel", "Computer Engineering");
            Student student2 = new Student(102, "Priya Sharma", "Information Technology");

            // Now we ask our objects to perform their public actions.
            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();

            Console.WriteLine("Admissions processed successfully. Press any key to exit...");
            Console.ReadKey(); // Keeps the console window open until a key is pressed
        }
    }
}