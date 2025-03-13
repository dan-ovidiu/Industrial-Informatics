// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// F5 - RUN sau BreakPoint in Breakpoint (pt debugging)
// F10 - line by line
// F12 - mergem la implementarea metodei
// F11 - intram in metoda
using System;
using static MyApp.Program;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int exercise;
                    Console.WriteLine("Choose the exercise or press (6 + Enter) to exit\n");
                    Console.WriteLine("1. Fibonacci sequence\n");
                    Console.WriteLine("2. Basic operations with two numbers\n");
                    Console.WriteLine("3. Temperature conversion\n");
                    Console.WriteLine("4. Ideal weight depending on gender\n");
                    Console.WriteLine("5. Arithmetic mean and geometric mean\n");
                    Console.WriteLine("6. Exit\n");

                    exercise = int.Parse(Console.ReadLine());

                    if (exercise < 1 || exercise > 6)
                    {
                        throw new Exception("The exercise must be an integer between 1 and 5 or 6 to exit\n");
                    }

                    switch (exercise)
                    {
                        case 1:
                            Ex1 ex1 = new Ex1();
                            ex1.fibonacci();
                            break;

                        case 2:
                            Ex2 ex2 = new Ex2();
                            ex2.readNumbers();
                            int number1 = ex2.number1;
                            int number2 = ex2.number2;
                            Console.WriteLine("Sum: " + ex2.sum(number1, number2));
                            Console.WriteLine("Difference: " + ex2.dif(number1, number2));
                            Console.WriteLine("Multiplication: " + ex2.mul(number1, number2));
                            Console.WriteLine("Division: " + ex2.div(number1, number2));
                            break;
                        case 3:
                            Ex3 ex3 = new Ex3();
                            ex3.readTemp();
                            float tempC = ex3.tempC;
                            float tempF = ex3.tempF;
                            ex3.convertCtoF(tempC, tempF);
                            ex3.convertFtoC(tempC, tempF);
                            break;
                        case 4:
                            Ex4 ex4 = new Ex4();
                            ex4.readData();
                            break;
                        case 5:
                            Ex5 ex5 = new Ex5();
                            ex5.readNumbers();
                            break;
                        case 6:
                            return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        internal class Ex1
        {
            public void fibonacci()
            {
                int length;
                Console.WriteLine("Input the length of Fibonacci sequence: ");
                try
                {
                    length = int.Parse(Console.ReadLine());
                    if (length < 1)
                    {
                        Console.WriteLine("The length must be greater than 0");
                        return;
                    }
                    int a = 0, b = 1;
                    Console.Write(a + " " + b + " ");
                    for (int c = 3; c <= length; c++)
                    {
                        int aux = a;
                        a = b;
                        b = aux + b;
                        Console.Write(b + " ");
                    }
                    Console.WriteLine("");
                }
                catch (Exception e)
                {
                    Console.WriteLine("The length must be an integer");
                }
            }
        }
        internal class Ex2
        {
            public int number1, number2;
            public void readNumbers()
            {
                Console.WriteLine("Input the first number: ");
                this.number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                this.number2 = int.Parse(Console.ReadLine());
            }
            public float sum(float a, float b)
            {
                return a + b;
            }

            public float dif(float a, float b)
            {
                return a - b;
            }

            public float mul(float a, float b)
            {
                return a * b;
            }

            public float div(float a, float b)
            {
                return a / b;
            }
        }
        internal class Ex3
        {
            public float tempC;
            public float tempF;

            public void readTemp()
            {
                Console.WriteLine("Input the temperature in Celsius: ");
                this.tempC = float.Parse(Console.ReadLine());

                Console.WriteLine("Input the temperature in Fahrenheit: ");
                this.tempF = float.Parse(Console.ReadLine());
            }

            public void convertCtoF(float c, float f)
            {
                f = c * 9 / 5 + 32;
                Console.WriteLine("The temperature in Celsius: {0}, converted in Fahrenheit is: " + f, c);
            }

            public void convertFtoC(float c, float f)
            {
                c = (f - 32) * 5 / 9;
                Console.WriteLine("The temperature in Fahrenheit: {0}, converted in Celsius is: " + c, f);
            }
        }
        internal class Ex4
        {
            public float weight;
            public float height;
            public int age;
            public char gender;

            public void readData()
            {
                Console.WriteLine("Input the weight (kg): ");
                this.weight = float.Parse(Console.ReadLine());
                Console.WriteLine("Input the height (cm): ");
                this.height = float.Parse(Console.ReadLine());
                Console.WriteLine("Input the age (years): ");
                this.age = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine("Input the gender (M/F): ");
                    this.gender = char.Parse(Console.ReadLine().ToUpper());
                    if (this.gender != 'M' && this.gender != 'F')
                    {
                        throw new Exception("Gender must be either 'M' or 'F'.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                if (this.gender == 'M')
                {
                    double idealWeightMale = calcIdealWeightMale(this.weight, this.height, this.age, this.gender);
                    Console.WriteLine("The ideal weight: " + idealWeightMale);
                }
                else
                {
                    double idealWeightFemale = calcIdealWeightFemale(this.weight, this.height, this.age, this.gender);
                    Console.WriteLine("The ideal weight: " + idealWeightFemale);
                }
            }
            public double calcIdealWeightMale(float weight, float height, int age, char gender)
            {
                return (height - 100 - ((height - 150) / 4) + ((age - 20) / 4));
            }

            public double calcIdealWeightFemale(float weight, float height, int age, char gender)
            {
                return (height - 100 - ((height - 150) / 2.5) + ((age - 20) / 6));
            }
        }
        internal class Ex5
        {
            public void readNumbers()
            {
                Console.WriteLine("Enter numbers separated by space (press Enter to finish): ");
                string input = Console.ReadLine();

                float[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries) 
                                       .Select(float.Parse) 
                                       .ToArray();

                Console.WriteLine("Arithmetic mean: " + arithmeticMean(numbers));
                Console.WriteLine("Geometric mean: " + geometricMean(numbers));

            }
            public float arithmeticMean(float[] numbers)
            {
                float sum = 0;
                for(int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum / numbers.Length;
            }
            public float geometricMean(float[] numbers)
            {
                float product = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }
                return (float)Math.Pow(product, 1.0 / numbers.Length);
            }
        }
    }
}