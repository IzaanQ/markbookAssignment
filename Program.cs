using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Izaan's Markbook Application!");
            Console.WriteLine("Select an Option, then press enter.");
            Console.WriteLine();
            Console.WriteLine("1. Find a Student");
            Console.WriteLine("2. Add a Student");
            Console.WriteLine("3. Delete a Student");
            Console.WriteLine("4. Exit the Program");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            int classCount = 1;

            List<StudentProfileDefault> classList = new List<StudentProfileDefault>();

            if (choice == 1)
            {
                Console.WriteLine("Finding a Student");

            }

            if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Adding a Student");
                Console.WriteLine();
                Console.WriteLine("What is the Students Name?");
                StudentProfileDefault Student = new StudentProfileDefault();
                Student.name = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("What Grade is " + Student.name + " in?");
                Student.grade = Convert.ToInt32(Console.ReadLine());

                if (Student.grade == 9 || Student.grade == 10 || Student.grade == 11)
                {
                    Console.WriteLine(Student.name + " is required to take 4 Courses");
                    Console.WriteLine();
                    Console.WriteLine("What is the first course that " + Student.name + " is taking");
                    Student.subject1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is " + Student.name + "'s percentage grade in " + Student.subject1 + "?");
                    Student.subject1Grade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is the second course that " + Student.name + " is taking");
                    Student.subject2 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is " + Student.name + "'s percentage grade in " + Student.subject2 + "?");
                    Student.subject2Grade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is the third course that " + Student.name + " is taking");
                    Student.subject3 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is " + Student.name + "'s percentage grade in " + Student.subject3 + "?");
                    Student.subject3Grade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is the fourth course that " + Student.name + " is taking");
                    Student.subject4 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is " + Student.name + "'s percentage grade in " + Student.subject4 + "?");
                    Student.subject4Grade = Convert.ToInt32(Console.ReadLine());
                    Student.averageGrade = (Student.subject1Grade + Student.subject2Grade + Student.subject3Grade + Student.subject4Grade) / Student.numberOfClasses;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Student Profile Successfully!");
                    Console.WriteLine();
                    Console.WriteLine("Student Name: " + Student.name);
                    Console.WriteLine(Student.name + "'s Student Grade: " + Student.grade);
                    Console.WriteLine(Student.name + " has " + Student.numberOfClasses + " classes this semester.");
                    Console.WriteLine(Student.name + "'s First Class: " + Student.subject1 + ". Current Grade: " + Student.subject1Grade + "%");
                    Console.WriteLine(Student.name + "'s Second Class: " + Student.subject2 + ". Current Grade: " + Student.subject2Grade + "%");
                    Console.WriteLine(Student.name + "'s Third Class: " + Student.subject3 + ". Current Grade: " + Student.subject3Grade + "%");
                    Console.WriteLine(Student.name + "'s Fourth Class: " + Student.subject4 + ". Current Grade: " + Student.subject4Grade + "%");
                    Console.WriteLine(Student.name + "'s Overall Average is " + Student.averageGrade + "%");

                    classList.Add(Student);

                    foreach (var student in classList) {
                        Console.WriteLine(student.averageGrade);
                    }



                }

                else if (Student.grade == 12)
                {
                    StudentProfileSpecial specialStudent = new StudentProfileSpecial();
                    specialStudent.name = Student.name;
                    specialStudent.grade = Student.grade;
                    Console.WriteLine();
                    Console.WriteLine("How many classes does " + specialStudent.name + " have?");
                    specialStudent.numberOfClasses = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= specialStudent.numberOfClasses; i++)
                    {
                        Console.WriteLine(specialStudent.name + "'s Class #" + i + " is:");

                        if (i == 1)
                        {
                            specialStudent.subject1 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else if (i == 2)
                        {
                            specialStudent.subject2 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else if (i == 3)
                        {
                            specialStudent.subject3 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else if (i == 4)
                        {
                            specialStudent.subject4 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("error");
                        }

                    }

                    for (int i = 1; i <= specialStudent.numberOfClasses; i++)
                    {

                        Console.WriteLine(specialStudent.name + "'s grade in Class #" + i + " is:");

                        if (i == 1)
                        {
                            specialStudent.subject1Grade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else if (i == 2)
                        {
                            specialStudent.subject2Grade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else if (i == 3)
                        {
                            specialStudent.subject3Grade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else if (i == 4)
                        {
                            specialStudent.subject4Grade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("error");
                        }

                    }

                    specialStudent.averageGrade = (specialStudent.subject1Grade + specialStudent.subject2Grade + specialStudent.subject3Grade + specialStudent.subject4Grade) / specialStudent.numberOfClasses;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Student Profile Successfully!");
                    Console.WriteLine();
                    Console.WriteLine("Student Name: " + specialStudent.name);
                    Console.WriteLine(specialStudent.name + "'s Student Grade: " + specialStudent.grade);
                    Console.WriteLine(specialStudent.name + " has " + specialStudent.numberOfClasses + " classes this semester.");
                    Console.WriteLine(specialStudent.name + "'s First Class: " + specialStudent.subject1 + ". Current Grade: " + specialStudent.subject1Grade + "%");
                    Console.WriteLine(specialStudent.name + "'s Second Class: " + specialStudent.subject2 + ". Current Grade: " + specialStudent.subject2Grade + "%");

                    if (specialStudent.numberOfClasses == 3)
                    {
                        Console.WriteLine(specialStudent.name + "'s Third Class: " + specialStudent.subject3 + ". Current Grade: " + specialStudent.subject3Grade + "%");
                    }

                    if (specialStudent.numberOfClasses == 4)
                    {
                        Console.WriteLine(specialStudent.name + "'s Fourth Class: " + specialStudent.subject4 + ". Current Grade: " + specialStudent.subject4Grade + "%");
                    }
                    Console.WriteLine(specialStudent.name + "'s Overall Average is " + specialStudent.averageGrade + "%");

                    classList.Add(Student);

                    Console.WriteLine(classList);
                }

                else
                {
                    Console.WriteLine("Invalid Choice");
                }


            }

            if (choice == 3)
            {
                Console.WriteLine("Deleting a Student");
            }

            if (choice == 4)
            {
                Console.WriteLine("Please press 'Enter' to exit the program");
            }

            Console.ReadLine();
        }


        

    }
}
