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