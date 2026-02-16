using System.Net.NetworkInformation;

namespace G_NET_26_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1
            //Q1 : Explain with code example how class and struct behave differently
            /*A1:
            * A class is a reference type that serves as a blueprint for creating objects. It defines what data an object holds and what it can do.
            - Stored on the heap (reference on the stack)
            - Assigned by reference — two variables can point to the same object
            - Supports inheritance, constructors, and methods
            - The most common way to model real-world entities in C#

            *A struct is a value type used to represent small, lightweight data. It groups related fields together.
            - stored on the stack — fast access
            - Copied by value — each copy is independent
            - Cannot inherit from other structs or classes
            - Best for small, simple data (coordinates, colors, money)
             */
            //Creating & Using a Struct
            //Point p1;
            //p1.X = 10;
            //p1.Y = 20;

            //Point p2 = p1;   // p2 is a COPY of p1
            //p2.X = 99;        // p1.X is still 10!

            //Class – Creating Objects
            //Student std01;    //Declare For Reference From Type "Student" ,stores the address in the Stack
            //std01 = new Student();   // Allocate Required Bytes At Heap for Object, Assign Address Of Allocated Object To Reference "std01"
            //std01.Name = "Ahmed";
            //std01.Age = 25;
            #endregion

            #region Q2
            //Q2 : Explain the difference between public and private access modifiers with an example.
            /*A2:
             private
             Accessibility: The member is only accessible within the class or struct it is defined in. It cannot be accessed from outside the class.
             Usage: Use for members that should only be accessible within the class, often for internal implementation details.
            For Example :A password field in a User class should be private — only the class should access it .

             Public
             Accessibility: The member is accessible from anywhere in the application, both within the same assembly (project) and from other assemblies.
             Usage: Use when you want to expose a class or method to other code.
            For Example :A Login() method other projects need to call should be public — accessible everywhere .
             */
            #endregion

            #region Q3
            //Q3 : Describe the steps to create and use a class library in Visual Studio.
            /*A3:
             * Create the class library:
               - Creatr a new project and Choose it's type to be “Class Library ”;
               - Add our (Public) classes and methods .
             * Build the library .
             * Create a consumer project or use an existing one .
             * Add a reference to the library .
             * Use the library in code .
               - Add using statements for the library’s namespace .
               - Create and use classes/members as needed .
             */
            #endregion

            #region Q4
            //Q4 : What is a class library? Why do we use class libraries?
            /*A4:
             A Class Library is a separate project that contains reusable classes, but has no Main method and cannot run on its own. 
             It compiles into a .dll file (Dynamic Link Library).
             We use class libraries for:
              - Reusability — write once, use in many projects
              - Organization — Separate concerns into different assemblies
              - Teamwork — different developers work on different libraries
              - Maintenance — fix a bug once, all projects benefit
             */
            #endregion
            #endregion
        }
    }
}
