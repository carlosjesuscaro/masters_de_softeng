// See https://aka.ms/new-console-template for more information
static void classone ()
{
    Console.WriteLine("Hello, World!");
    bool myBoolVar = true;
    double myDouble = 2.9436;
    int myInt = 24;
    string myStr = "This is Carlos";
    Console.WriteLine(myStr);

    // Function example Sum
    static int Sum(int a, int b)
    {
        return a + b;
    }
    int Result = Sum(23, 45);
    Console.WriteLine(Result);

    // Function example Printing without return
    static void Printing(string ex)
    {
        Console.WriteLine(ex);
    }
    Printing("Carlos Jesus Caro");

    // Function even or odd Option 1
    static bool evenodd1(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    Console.WriteLine(evenodd1(26));

    // Function even or odd Option 2
    static bool evenodd2(int num)
    {
        switch (num % 2)
        {
            case 0:
                return true;
                break;
            default:
                return false;
                break;
        }
    }
    Console.WriteLine(evenodd1(25));

    // Loop example: while
    int counter = 0;
    while (counter < 20)
    {
        Console.WriteLine(counter);
        counter += 1;
    }

    // Loop example: while
    int counter2 = 0;
    Console.WriteLine("\nSecond example");
    do
    {
        Console.WriteLine(counter2);
        counter2 += 1;
    }
    while (counter2 < 30);

    // Loop example: for
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine("Natalia " + i);
    }

    // Utilities
    Console.WriteLine("Please enter a name: \n");
    string name = Console.ReadLine();
    Console.WriteLine(name);
    Console.WriteLine("Please enter a number: \n");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Here is your number: " + n1);

    // Array ints
    int[] arrayInt = new int[4];
    for (int i = 0; i < arrayInt.Length; i++)
    {
        arrayInt[i] = i * 10;
        Console.WriteLine(arrayInt[i]);
    }

    // Array strings
    string[] arrayStr = {"Carlos", "Natalia", "Nolan"};
    for (int i = 0; i < arrayStr.Length; i++)
    {
        Console.WriteLine(arrayStr[i]);
    }

    // Array multidimensional 1
    Console.WriteLine("\nMulti dimensional array: \n");
    int [][] arrayMulti = new int[4][];
    for (int i = 0; i < arrayMulti.Length; i++)
    {
        if (i % 2 == 0)
        {
            arrayMulti[i] = new int[6];
        }
        else
        {
            arrayMulti[i] = new int[8];
        }

        for (int j = 0; j < arrayMulti[i].Length; j++)
        {
            arrayMulti[i][j] = i * j;
            Console.WriteLine(arrayMulti[i][j] + ",");
        }
        Console.WriteLine("\n");
    }

    // Array multidimensional 2
    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

    for (int i = 0; i < numbers.GetLength(0); i++) 
    { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
            Console.WriteLine(numbers[i, j]); 
        } 
    }
}

static void exerciseone()
{
    // Exercise 1
    Console.WriteLine("Hello from Carlos Jesus Caro");
}

static void exercisetwo()
{
    int a = 4;
    int b = 7;
    Console.WriteLine(a + " + " + b + " = " + (a+b));
}

static void exercisethree()
{
    double a = 8;
    double b = 3;
    double c = a / b;
    Console.WriteLine(a + " / " + b + " = " + c);
}

static void exercisefour()
{
    Console.WriteLine("-1+4*6 = " + (-1+4*6));
    Console.WriteLine("(35+5)%7 = " + (35+5)%7);
    Console.WriteLine("14+-4*6/11 = " + 14+-4*6/11);
    Console.WriteLine("2+15/6*1-7%2 = " + (2+15/6*1-7%2));
}

static void exercisefive()
{
    int num1 = Int32.Parse(Console.ReadLine());
    int num2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("First number is: " + num1);
    Console.WriteLine("Second number is: " + num2);
    int numx = num1;
    num1 = num2;
    num2 = numx;
    Console.WriteLine("After swapping");
    Console.WriteLine("First number is: " + num1);
    Console.WriteLine("Second number is: " + num2);
}

static void exercisesix()
{
    try
    {
        int num1 = Int32.Parse(Console.ReadLine());
        int num2 = Int32.Parse(Console.ReadLine());
        int num3 = Int32.Parse(Console.ReadLine());
        int num4 = num1 + num2 + num3;
        Console.WriteLine("The sum of all numbers is: " + num4);
    }
    catch (FormatException)
    {
        Console.WriteLine("One of the entries is not an integer");
    }
}

static void exerciseseven()
{
    try
    {
        int num1 = Int32.Parse(Console.ReadLine());
        int num2 = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Sum: " + (num1 + num2));
        Console.WriteLine("Difference: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / num2));
        Console.WriteLine("Reminder: " + (num1 % num2));
    }
    catch (FormatException)
    {
        Console.WriteLine("One of the entries is not an integer");
    }
}

static void exerciseeight()
{
    try
    {
        int num = Int32.Parse(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + (i*num));
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("One of the entries is not an integer");
    }
}

static void exercisenine()
{
    try
    {
        double num1 = Double.Parse(Console.ReadLine());
        double num2 = Double.Parse(Console.ReadLine());
        double num3 = Double.Parse(Console.ReadLine());
        double num4 = Double.Parse(Console.ReadLine());
        double avg = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine("The average is: " + avg);
    }
    catch (FormatException)
    {
        Console.WriteLine("One of the entries is not an integer");
    }   
}

static void exerciseten()
{
    try
    {
        int num1 = Int32.Parse(Console.ReadLine());
        int num2 = Int32.Parse(Console.ReadLine());
        int num3 = Int32.Parse(Console.ReadLine());
        int calc1 = (num1 + num2) * num3;
        int calc2 = num1 * num2 + num2 * num3;
        Console.WriteLine("(x+y)*z = s" + calc1);
        Console.WriteLine("(x*y) + (y*z) = " + calc2);
    }
    catch (FormatException)
    {
        Console.WriteLine("One of the entries is not an integer");
    }   
}

static void exerciseeleven()
{
    Console.Write("Please enter a word: ");
    string word = Console.ReadLine();

    int counter = 0;
    var guessChain = new List<string>();
    while (counter < 10)
    {
        string[] hintWord = new string[word.Length]; 
        Console.WriteLine("\nGuess one of the letters: ");
        string guess = Console.ReadLine();
        if (word.Contains(guess))
        {
            guessChain.Add(guess);
            for (int i = 0; i < word.Length; i++)
            {
                foreach (var guessInd in guessChain)
                {
                    if (word[i].ToString() == guessInd)
                    {
                        hintWord[i] = guessInd;
                        break;
                    }
                    else
                    {
                        hintWord[i] = "_";
                    }
                }
            }
            int check = 0;
            for (int j = 0; j < hintWord.Length; j++)
            {
                if (hintWord[j] != "_")
                {
                    check++;
                }
                Console.Write(hintWord[j]);
                if (check == word.Length)
                {
                    Console.WriteLine("\nYou win!\n");
                    counter = 11;
                }
            }
        }
        else
        {
            Console.WriteLine("Try again!");
        }
        counter++;
        if (counter == 10)
        {
            Console.WriteLine("You lose!");
            break;
        }
    }
}

Console.WriteLine("Welcome to Software Engineering for Data Engineering\n");
Console.WriteLine("Enter A for the class or B for the exercise");
string answer = Console.ReadLine().ToLower();
if (answer == "a")
{
    classone();
} else if (answer == "b")
{
    Console.WriteLine("Exercise 1:\n");
    exerciseone();
    Console.WriteLine("\nExercise 2:\n");
    exercisetwo();
    Console.WriteLine("\nExercise 3:\n");
    exercisethree();
    Console.WriteLine("\nExercise 4:\n");
    exercisefour();
    Console.WriteLine("\nExercise 5:\n");
    exercisefive();
    Console.WriteLine("\nExercise 6:\n");
    exercisesix();
    Console.WriteLine("\nExercise 7:\n");
    exerciseseven();
    Console.WriteLine("\nExercise 8:\n");
    exerciseeight();
    Console.WriteLine("\nExercise 9:\n");
    exercisenine();
    Console.WriteLine("\nExercise 10:\n");
    exerciseten();
    Console.WriteLine("\nExercise 11:\n");
    exerciseeleven();
} 
else
{
    Console.WriteLine("Incorrect answer");
}