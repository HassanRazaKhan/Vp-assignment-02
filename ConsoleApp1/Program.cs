using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VPassignmentNo1
{
    class Program
    {
        int choice, size, option;
        string present = "Present";
        string absent = "Absent";
        StreamWriter sw = new StreamWriter("assignment1.txt");
        int[] studentID = new int[20];
        string[] studentName = new string[20];
        string[] studentSemester = new string[20];
        double[] studentCGPA = new double[20];
        string[] studentDepartment = new string[20];
        string[] studentUniversity = new string[20];
        void intro()
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("*********************VISUAL PROGRAMMING************************");
            Console.WriteLine("************************Assignment # 1*************************");
            Console.WriteLine("***********************Hassan Raza Khan************************");
            Console.WriteLine("************************01-131172-009**************************");
            Console.WriteLine("_______________________________________________________________");
            Console.ReadKey();
            Console.Clear();
        }
        void mainPage()
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Press 1 for Create Student Profile");
            Console.WriteLine("Press 2 for Search Students");
            Console.WriteLine("Press 3 for Delete Students");
            Console.WriteLine("Press 4 for view top 3 Students");
            Console.WriteLine("Press 5 for mark Attendace of Students");
            Console.WriteLine("Press 6 for view Attendance of Students");
            Console.WriteLine("Enter keys [1-6]");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("_______________________________________________________________");
            Console.ReadKey();
            Console.Clear();
        }
        void createProfile()
        {
            if (choice == 1)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("How many Students you want to enter?");
                size = int.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________________________________________");
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please Enter the Data of Students");
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter Student ID (must be unique)");
                    studentID[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter Student Name:");
                    studentName[i] = Console.ReadLine();
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter Student Semster:");
                    studentSemester[i] = Console.ReadLine();
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter Student CGPA:");
                    studentCGPA[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter Student Department:");
                    studentDepartment[i] = Console.ReadLine();
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter Student University:");
                    studentUniversity[i] = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student ID:" + studentID[i]);
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student Name:" + studentName[i]);
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student Semester:" + studentSemester[i]);
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student CGPA:" + studentCGPA[i]);
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student Department:" + studentDepartment[i]);
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student University:" + studentUniversity[i]);
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Sucessfully Created!");
                    Console.WriteLine("_______________________________________________________________");
                    Console.ReadKey();
                    Console.Clear();
                    sw.WriteLine(studentID[i] + "\t \t" + studentName[i] + "\t \t" + studentSemester[i] + "\t \t" + studentCGPA[i] + "\t \t" + studentDepartment[i] + "\t \t" + studentUniversity[i]);
                }
                sw.Flush();
                sw.Close();
            }
        }
        void searchStudent()
        {
            int n;
            int searchID;
            string searchName;
            if (choice == 2)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Press 1 for search by ID");
                    Console.WriteLine("Press 2 for search by Name");
                    Console.WriteLine("Press 3 for List all number of Students");

                    n = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("_______________________________________________________________");
                    if (n == 1)
                    {
                        Console.WriteLine("Enter ID you want to search:");
                        searchID = int.Parse(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("_______________________________________________________________");
                        if (searchID == studentID[i])
                        {
                            Console.WriteLine("Student Name:" + studentName[i]);
                            Console.WriteLine("Student Semester:" + studentSemester[i]);
                            Console.WriteLine("Student CGPA:" + studentCGPA[i]);
                            Console.WriteLine("Student Department:" + studentDepartment[i]);
                            Console.WriteLine("Student University:" + studentUniversity[i]);
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("_______________________________________________________________");
                            Console.WriteLine("Sucessfully Searched!");
                            Console.WriteLine("_______________________________________________________________");
                        }
                        else
                        {
                            Console.WriteLine("_______________________________________________________________");
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("_______________________________________________________________");
                        }
                    }
                    if (n == 2)
                    {
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Enter name you want to search:");
                        searchName = Console.ReadLine();
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("_______________________________________________________________");
                        if (searchName == studentName[i])
                        {
                            for (i = 0; i < size; i++)
                            {
                                Console.WriteLine("_______________________________________________________________");
                                Console.WriteLine("Student ID:" + studentID[i]);
                                Console.WriteLine("Student Semester:" + studentSemester[i]);
                                Console.WriteLine("Student CGPA:" + studentCGPA[i]);
                                Console.WriteLine("Student Department:" + studentDepartment[i]);
                                Console.WriteLine("Student University:" + studentUniversity[i]);
                                Console.WriteLine("Sucessfully Searched!");
                                Console.WriteLine("_______________________________________________________________");
                            }
                        }
                        else
                        {
                            Console.WriteLine("_______________________________________________________________");
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("_______________________________________________________________");
                        }
                    }
                    if (n == 3)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Console.WriteLine("_______________________________________________________________");
                            Console.WriteLine("Student ID:" + studentID[i]);
                            Console.WriteLine("Student Name:" + studentName[i]);
                            Console.WriteLine("_______________________________________________________________");
                        }
                    }

                }
            }
        }
        void deleteStudent()
        {
            int deleteID;

            if (choice == 3)
            {
                for (int i = 0; i < size; i++)
                {
                    int numToRemove = studentID[i];
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter ID you want to delete:");
                    deleteID = int.Parse(Console.ReadLine());
                    Console.WriteLine("_______________________________________________________________");
                    Console.ReadKey();
                    Console.Clear();

                    if (deleteID == numToRemove)
                    {

                        var numbersList = studentID.ToList();
                        numbersList.Remove(i);
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Successfully Deleted!");
                        Console.WriteLine("_______________________________________________________________");

                    }
                    else
                    {
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Try Again!");
                        Console.WriteLine("_______________________________________________________________");
                    }
                }

            }

        }

        void maximumCGPAs()
        {
            if (choice == 4)
            {
                double temp;
                for (int i = 0; i < size - 1; i++)

                    for (int j = i + 1; j < size; j++)

                        if (studentCGPA[i] < studentCGPA[j])
                        {
                            temp = studentCGPA[i];
                            studentCGPA[i] = studentCGPA[j];
                            studentCGPA[j] = temp;
                        }


                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine(studentCGPA[i]);
                    Console.WriteLine("_______________________________________________________________");

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        void markAttendance()
        {
            if (choice == 5)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Press 1 for Present");
                Console.WriteLine("Press 0 for Absent");
                Console.WriteLine("_______________________________________________________________");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("student ID: " + studentID[i]);
                    Console.WriteLine("student Name: " + studentName[i]);
                    Console.WriteLine("Present / Absent");
                    option = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("_______________________________________________________________");
                    if (option == 1)
                    {
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine(studentName[i] + " is " + present);
                        Console.WriteLine("_______________________________________________________________");
                    }
                    else if (option == 0)
                    {
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine(studentName[i] + " is " + absent);
                        Console.WriteLine("_______________________________________________________________");
                    }
                    else
                    {
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("_______________________________________________________________");
                    }
                }
            }
        }
        void viewAttendance()
        {
            if (choice == 6)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Present = 1");
                Console.WriteLine("Absent = 0");
                Console.WriteLine("_______________________________________________________________");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Student ID" + " " + "Student Name" + " " + "Attendance");
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine(studentID[i] + "\t \t" + studentName[i] + "\t \t" + option);
                    Console.WriteLine("_______________________________________________________________");
                }
            }
        }
        static void Main(string[] args)
        {
            char ch = 'y';
            Program p = new Program();
            p.intro();
            do
            {
                p.mainPage();
                p.createProfile();
                p.searchStudent();
                p.deleteStudent();
                p.maximumCGPAs();
                p.markAttendance();
                p.viewAttendance();
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Do you want to continue? []y/n]");
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________________________________________");
                Console.ReadKey();
            } while (ch == 'y');
        }
    }
}
