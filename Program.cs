using System;

namespace FirstProject
{
    public interface IPerson {
        string? Name { get; set; }
        int Age { get; set; }

        void Introduce();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            teacher.Name = InputHelper.GetInput("Enter your name: ");
            teacher.Age = InputHelper.GetAge("Enter your age: ");
            teacher.School = InputHelper.GetInput("Enter your school: ");
            teacher.Subject = InputHelper.GetInput("Enter your subject: ");
            
            teacher.Introduce();
        }

        class Student : IPerson {
            public string? Name { get; set; }
            public int Age { get; set; }
            public string? School { get; set; }

            public void Introduce() {
                Console.WriteLine($"My name is {Name} and I'm {Age} years old, and I'm a student at {School}.");
            }
        }

        class Teacher : IPerson {
            public string? Name { get; set; }
            public int Age { get; set; }
            public string? Subject { get; set; }
            public string? School { get; set; }

            public void Introduce() {
                Console.WriteLine($"My name is {Name} and I'm {Age} years old, and I teach {Subject} at {School}.");
            }
        }

        public class InputHelper {
            public static string? GetInput(string message) {
                while (true) {
                    Console.Write(message);
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input)) {
                        return input;
                    }
                    Console.WriteLine("Input cannot be empty.");
                }
            }

            public static int GetAge(string message) {
                while (true) {
                    Console.Write(message);
                    try {
                        return Convert.ToInt32(Console.ReadLine());
                    } catch (FormatException) {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
            }
        }
    }
}

