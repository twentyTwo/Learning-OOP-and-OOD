using System;
using System.Linq;

namespace StackImplementation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stack = new Stack();
            while (true)
            {
                try
                {
                    Console.WriteLine("1 : Push, 2 : Pop, 3: Clear");
                    var cmd = int.Parse(Console.ReadLine());

                    switch (cmd)
                    {
                        case 1:
                            Console.WriteLine("Enter value:");
                            stack.Push(Console.ReadLine());
                            PrintValues(stack);
                            break;
                        case 2:
                            Console.WriteLine(stack.Pop());
                            PrintValues(stack);
                            break;
                        case 3:
                            stack.Clear();
                            PrintValues(stack);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid operation.");
                }
            }
        }

        private static void PrintValues(Stack stack)
        {
            var list = stack.ViewStack().ToArray().Reverse();

            Console.WriteLine("-----Stack-----");
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");
        }
    }
}