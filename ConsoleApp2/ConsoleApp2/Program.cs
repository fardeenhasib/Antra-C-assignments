using ConsoleApp2;

ReverseArray rArr = new ReverseArray();
int[] arr = rArr.GenerateNumbers(10);
rArr.Reverse(arr);
rArr.PrintNumbers(arr);


Fibonacci  fib = new Fibonacci();
fib.PrintFibonacci();


Color redColor = new Color(255, 0, 0);
Color blueColor = new Color(0, 0, 255);
Ball redBall = new Ball(10, redColor);
Ball blueBall = new Ball(15, blueColor);


redBall.Throw();
blueBall.Throw();
redBall.Throw();

redBall.Pop();

redBall.Throw();

Console.WriteLine("Red ball throws: " + redBall.GetThrowCount());
Console.WriteLine("Blue ball throws: " + blueBall.GetThrowCount());



var student = new Student();
student.BirthDate = new DateTime(2000, 1, 1);
student.AddAddress("123 Main St");
student.AddAddress("456 Elm St");

// Calculating student's age
int age = student.CalculateAge(student.BirthDate);
Console.WriteLine($"Student's age: {age}");

// Creating an instructor
var instructor = new Instructor();
instructor.BirthDate = new DateTime(1980, 1, 1);
instructor.JoinDate = new DateTime(2010, 1, 1);
instructor.AddAddress("789 Oak St");

// Calculating instructor's salary and bonus
decimal baseSalary = 50000;
decimal salary = instructor.CalculateSalary(baseSalary);
decimal bonusSalary = instructor.CalculateBonusSalary(instructor.JoinDate);
Console.WriteLine($"Instructor's salary: {salary}");
Console.WriteLine($"Instructor's bonus salary: {bonusSalary}");

// Creating a department
var department = new Department();
department.StartDate = new DateTime(2024, 9, 1);
department.EndDate = new DateTime(2025, 5, 1);
department.Budget = 100000;

// Assigning head instructor to the department
department.AssignHeadInstructor(instructor);