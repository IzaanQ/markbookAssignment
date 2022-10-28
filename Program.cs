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
            int classCount = 0; // this line is resetting the value (for the list too because the method is restarted)
            int classNum = 0;

            List<StudentProfileDefault> classList = new List<StudentProfileDefault>();
            for (int i = 0; true; i++)
            {
                MarkbookMenu(classCount, classList, classNum);
            }

        }

        static void MarkbookMenu(int classCount, List<StudentProfileDefault> classList, int classNum)
        {
            Console.WriteLine("Welcome to Izaan's Markbook Application!");
            Console.WriteLine("Select an Option, then press enter.");
            Console.WriteLine();
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Find a Student");
            Console.WriteLine("3. Delete a Student");
            Console.WriteLine("4. Exit the Program");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 1 && choice != 2 && choice != 3 && choice != 4) {
                Console.WriteLine();
                Console.WriteLine("Invalid option selected. Please select 1, 2, 3, or 4");
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to return to the main menu");
                Console.WriteLine();

                
            }



            if (choice == 1)
            {
                if (classList.Count < 30)
                {
                    Console.WriteLine();
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

                        Student.numberOfClasses = 4;
                        Console.WriteLine();
                        Console.WriteLine(Student.name + " is required to take 4 Courses");
                        Student.numberOfClasses = 4;
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
                        classList.Add(Student);

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
                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to return to the main menu");
                        Console.WriteLine();
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

                        classList.Add(specialStudent);
                        Console.WriteLine("Student Profile Successfully!");
                        Console.WriteLine();
                        Console.WriteLine("Student Name: " + specialStudent.name);
                        Console.WriteLine(specialStudent.name + "'s Student Grade: " + specialStudent.grade);
                        Console.WriteLine(specialStudent.name + " has " + specialStudent.numberOfClasses + " classes this semester.");
                        Console.WriteLine(specialStudent.name + "'s First Class: " + specialStudent.subject1 + ". Current Grade: " + specialStudent.subject1Grade + "%");
                        if (specialStudent.numberOfClasses >= 2)
                        {
                            Console.WriteLine(specialStudent.name + "'s Second Class: " + specialStudent.subject2 + ". Current Grade: " + specialStudent.subject2Grade + "%");
                        }
                        if (specialStudent.numberOfClasses >= 3)
                        {
                            Console.WriteLine(specialStudent.name + "'s Third Class: " + specialStudent.subject3 + ". Current Grade: " + specialStudent.subject3Grade + "%");
                        }

                        if (specialStudent.numberOfClasses == 4)
                        {
                            Console.WriteLine(specialStudent.name + "'s Fourth Class: " + specialStudent.subject4 + ". Current Grade: " + specialStudent.subject4Grade + "%");
                        }
                        Console.WriteLine(specialStudent.name + "'s Overall Average is " + specialStudent.averageGrade + "%");
                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to return to the main menu");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine("Please Select a valid grade level (9, 10, 11, or 12)");
                    }


                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Max number of students (30) reached. Please remove a student from your class.");
                }
                Console.Clear();
            }

            if (choice == 2)
            {
                int found = 0;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Finding a Student");
                Console.WriteLine();
                Console.WriteLine("What is the name of the Student you are searching for?");
                string target = Convert.ToString(Console.ReadLine());

                //for (int i = 0; i <= classList.Count; i++) { 
                //    if (classList[
                //}

                foreach (var student in classList)
                {
                    if (student.name == target)
                    {
                        found = 1;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Student found!");
                        Console.WriteLine();

                        if (student.grade == 9 || student.grade == 10 || student.grade == 11)
                        {
                            Console.WriteLine("Name: " + student.name);
                            Console.WriteLine(student.name + "'s Student Grade: " + student.grade);
                            Console.WriteLine(student.name + " has " + student.numberOfClasses + " classes this semester.");
                            Console.WriteLine(student.name + "'s First Class: " + student.subject1 + ". Current Grade: " + student.subject1Grade + "%");
                            Console.WriteLine(student.name + "'s Second Class: " + student.subject2 + ". Current Grade: " + student.subject2Grade + "%");
                            Console.WriteLine(student.name + "'s Third Class: " + student.subject3 + ". Current Grade: " + student.subject3Grade + "%");
                            Console.WriteLine(student.name + "'s Fourth Class: " + student.subject4 + ". Current Grade: " + student.subject4Grade + "%");
                            Console.WriteLine(student.name + "'s Overall Average is " + student.averageGrade + "%");
                            Console.WriteLine();
                            Console.WriteLine("Press 'Enter' to return to the main menu");
                            Console.WriteLine();
                        }
                    }
                    
                }

                for (int i = 0; i < classList.Count; i++)
                {
                    if (classList[i].name == target && classList[i].grade == 12)
                    {
                        found = 1;
                        int numOfClasses = 0;
                        if (classList[i].subject1Grade > 0)
                        {
                            numOfClasses++;
                            if (classList[i].subject2Grade > 0)
                            {
                                numOfClasses++;
                                if (classList[i].subject3Grade > 0)
                                {
                                    numOfClasses++;
                                    if (classList[i].subject4Grade > 0)
                                    {
                                        numOfClasses++;
                                    }
                                }
                            }

                        }

                        Console.WriteLine();
                        Console.WriteLine("Student Name: " + classList[i].name);
                        Console.WriteLine(classList[i].name + "'s Student Grade: " + classList[i].grade);
                        Console.WriteLine(classList[i].name + " has " + numOfClasses + " classes this semester.");
                        Console.WriteLine(classList[i].name + "'s First Class: " + classList[i].subject1 + ". Current Grade: " + classList[i].subject1Grade + "%");
                        if (numOfClasses >= 2)
                        {
                            Console.WriteLine(classList[i].name + "'s Second Class: " + classList[i].subject2 + ". Current Grade: " + classList[i].subject2Grade + "%");
                        }
                        if (numOfClasses >= 3)
                        {
                            Console.WriteLine(classList[i].name + "'s Third Class: " + classList[i].subject3 + ". Current Grade: " + classList[i].subject3Grade + "%");
                        }

                        if (numOfClasses == 4)
                        {
                            Console.WriteLine(classList[i].name + "'s Fourth Class: " + classList[i].subject4 + ". Current Grade: " + classList[i].subject4Grade + "%");
                        }
                        Console.WriteLine(classList[i].name + "'s Overall Average is " + classList[i].averageGrade + "%");
                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to return to the main menu");
                        Console.WriteLine();


                    }
                }

                if (found == 0) {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The student could not be located. Please return to the main menu and try again.");
                    Console.WriteLine();
                    Console.WriteLine("Press 'Enter' to return to the main menu");
                }

                Console.Clear();

            }

            if (choice == 3)
            {
                int found = 0;
                char decision;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Deleting a Student");
                Console.WriteLine();

                Console.WriteLine("What is the name of the Student you would like to remove?");
                string removal = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < classList.Count; i++)
                {
                    if (classList[i].name == removal)
                    {
                        found = 1;
                        Console.WriteLine();
                        Console.WriteLine("The student has been found");
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you would like to remove " + removal + " [y/n]");
                        decision = Convert.ToChar(Console.ReadLine());

                        if (decision == 'y')
                        {
                            classList.RemoveAt(i);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("The student has been removed from your class.");
                            Console.WriteLine();
                            Console.WriteLine("Press 'Enter' to return to the main menu");
                        }

                        else {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("The student is still in your class");
                            Console.WriteLine();
                            Console.WriteLine("Press 'Enter' to return to the main menu");
                        }

                    }
                }//here

                if (found == 0) {
                    Console.WriteLine();
                    Console.WriteLine("The student could not be located. Please try again");
                }




                Console.Clear();
            }

            if (choice == 4)
            {
                Console.WriteLine();
                Console.WriteLine();
                Environment.Exit(0);
            }

            Console.ReadLine();
        }




    }
}
