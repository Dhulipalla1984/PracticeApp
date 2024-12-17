using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.IO;
using ClassLibrary1;
using PracticeApp.SolidPrinciples;
using PracticeApp.OOPS;
using PracticeApp.Collections;
namespace PracticeApp
{

    class MyClass
    {
        public void MyMethod() { 
        
        Console.WriteLine();
                }
    }
   
    
    /* Properties*/
    class Person
    {
        private string names;
        private string designation;
        public string Names
        {
            //{ get; set; }
            get { return names; }
            set { names = value; }
        }
        public string Designation
        {

        //get; set; }

        get { return designation; }
    set { designation = value; }
    }
    }
    class Program
    {
       readonly int newVariable;
        string color = "Blue";
        int speed = 100;
        /* Methods */
        static void MyMethod(int newVariable, string fname = "swathi")
        {
            Console.WriteLine($"Name: {fname}, newVariable: {newVariable}");
        }
        static void Main(String[] args)
        {


            /* Basic program Examples */
            Console.WriteLine("________________________");
            Console.WriteLine("Basic program Examples");
            BasicProgramming obj1 = new BasicProgramming(100);
            Console.WriteLine(obj1.number);
            Person person = new Person();
            person.Names = "Sruthi";
            person.Designation = "developer";
            Console.WriteLine(person.Names + person.Designation);
            Program myObj = new Program();
            Console.WriteLine(myObj.color + myObj.speed);
            MyMethod(20, "Sweden");
            MyMethod(30, "India");
            MyMethod(26);
            Console.Write("Hellow World \n");
            long myNumer = 15000000000;
            Console.WriteLine(myNumer);
            string name = "Keerthi\n";
            Console.WriteLine(name);
            Console.WriteLine(name.ToUpper().Length);
            const int myNum = 5;
            const float PI = 23.1F;
            int mynum = 20;

            double myDoubleNum = 5.99D;
            //int newCasted = (int)myDoubleNum;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            //string myText2 = string.Concat(name, myText);
            string myText2 = $"my name is {myText}{name}";
            Console.WriteLine(myText2);
            Console.WriteLine(myText2.IndexOf("0"));
            Console.WriteLine(myText);
            Console.Write(myNum + mynum);
            Console.Write(myDoubleNum);
            Console.Write(myLetter);
            Console.Write(myBool);
            /* Strings */
            Console.WriteLine(Convert.ToString(myNumer));
            Console.WriteLine(Convert.ToDouble(myNumer));
            Console.WriteLine(Convert.ToInt32(myDoubleNum));
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Math.Sqrt(64));
            /*Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Age is" + age);*/
            Console.WriteLine("________________________");
            Console.WriteLine("Loops examples");
            /* Loops */
            /* If */
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            /* While */
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            /* Switch */
            int day = 4;
            switch (day)
            {
                case 0:
                    Console.WriteLine("this is Sunday"); 
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thur");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("sat");
                    break;
                case 7:
                    Console.WriteLine("sun");
                    break;
                default:
                    // code block
                    break;
            }
            Console.WriteLine("________________________ Arrays");
            /* Arrays */
            string[] cars = { "valvo", "benz", "skoda" };
            cars[0] = "opel";
            Console.WriteLine(cars[0]);
            Array.Sort(cars);
            foreach (string car in cars) { Console.WriteLine(car); }
            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                {
                    break;
                }
                Console.WriteLine(j);
            }
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
            int[,] myNumbers2 = { { 5, 3, 3 }, { 5, 2, 3 } };
            foreach (int z in myNumbers2) { Console.WriteLine(z); }
            for (int j = 0; j < myNumbers2.GetLength(0); j++)
            {
                for (int k = 0; k < myNumbers2.GetLength(1); k++)
                {
                    Console.WriteLine(myNumbers2[j, k]);
                }
            }
            //myNumbers2[0,2] = 8;
            Console.WriteLine(myNumbers2[0, 2]);

            ArrayAndList arrayAndList = new ArrayAndList();
            arrayAndList.ArrayAndListMethod();
            ArrayExamples arrayList = new ArrayExamples();
            arrayList.ArrayListExample();

            Console.WriteLine("________________________ FileI/O");
            // Specify the file path
            /* string filePath = @"C:\Dev\myfile.txt";

             // Content to write in the file
             string content = "Hello, this is a sample text file.";

             // Create and write to the file
             File.WriteAllText(filePath, content);

             Console.WriteLine($"File created successfully at {filePath}");*/

            /* End Basic Program Examples */
            Console.WriteLine("________________________");
            /* constructor */
            Console.WriteLine("this is constructor Examples");
            Base obj = new Derived2();
            obj.Method();
            Console.WriteLine("________________________");
            /* Interface */
            Console.WriteLine("this is Interface Examples");
            Pig1 interPig = new Pig1();
            Pig2 interPig2 = new Pig2();
            interPig.animalSound();
            interPig2.animalBreed();
            Console.WriteLine("________________________");
            /* Polymorphism */
            Console.WriteLine("this is Polymorphism Examples");
            Console.WriteLine("________________________");
            //Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Pig myPig = new Pig();
            //myAnimal.makeSound();
            myDog.makeSound();
            myDog.sleep();
            myPig.makeSound();

            /* overloading */
            OverLoading overLoading = new OverLoading();
            double sum2 = overLoading.Add(1, 2, 3);
            Console.WriteLine("This is overloading output" + sum2);
            Console.WriteLine("________________________");
            /* Inheritance */
            Car myObjes = new Car();
            myObjes.honk();
            Console.WriteLine(myObjes.modelName + myObjes.brand);

            Console.WriteLine("________________________");
            /* SRP */
            Console.WriteLine("this is SRP Examples");
            Employee john = new Employee { Name = "John", HoursWorked = 160, Pay = 5000 };
            EmployeeReport report = new EmployeeReport(john);
            string content = report.GenerateReportContent();
            ReportPrinter printer = new ReportPrinter();
            printer.Print(content);
            ReportPDFSaver pdfSaver = new ReportPDFSaver();
            pdfSaver.SaveAsPDF(content, "path_to_save_report.pdf");
            Invoice FInvoice = new FinalInvoice();
            double FInvoices = (int)FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(FInvoices);
            Console.WriteLine("________________________");
            /* OpenClosed */
            Console.WriteLine("this is OCP Examples");
            var regularDiscount = new RegularDiscount();
            var calculator = new DiscountCalculator(regularDiscount);
            double discountedPrice = calculator.CalculateDiscount(100); // 10% discount applied
            Console.WriteLine($"Regular Discount Price: {discountedPrice}");
            var premiumDiscount = new PremiumDiscount();
            calculator = new DiscountCalculator(premiumDiscount);
            discountedPrice = calculator.CalculateDiscount(100); // 30% discount applied
            Console.WriteLine($"Premium Discount Price: {discountedPrice}");
           
            Console.WriteLine("________________________");
            /* Liskov */
            Console.WriteLine("this is Liskov Principle Examples");
            IFruit fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
            Console.WriteLine("________________________");
            /* ISP */
            PrintContents printContents = new PrintContents();
            printContents.PrintContent("This is ISP :This is the test content to print");
            
            Console.WriteLine("________________________");
            Console.WriteLine("This is emun example");
            /*enum */
            Level myVar = Level.High;
            Console.WriteLine(myVar);
            switch(myVar) {
                case Level.Low: Console.WriteLine("this is low");
                    break;
                case Level.Medium: Console.WriteLine("this is medium");
                        break;
                case Level.High: Console.WriteLine("this is High");
                    break;
                default: Console.WriteLine("this is nothing");
                    break ;
            }

            Console.WriteLine("________________________");

        }
        }
}