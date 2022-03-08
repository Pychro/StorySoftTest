using System;

namespace ConsoleApp1
{
    class Program
    {
        public interface ICodeTest
        {
            void iterate(int n);
            void iterateWithQP(int n, int q, int p);
            void fibCreator(int start, int length);
            void xmlChecker(string input);
        }

        class interfaceClass : ICodeTest
        {
            public void iterate(int n)
            {
                throw new NotImplementedException();
            }
            public void iterateWithQP(int n, int q, int p)
            {
                throw new NotImplementedException();
            }
            public void fibCreator(int start, int length)
            {
                throw new NotImplementedException();
            }
            public void xmlChecker(string input)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            
            dialogOptions();
            userInput(Console.ReadLine());
        }

    public void iterate(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i);
                if (i % 5 == 0)
                {
                    Console.Write("Hello");
                }
                if (i % 7 == 0)
                {
                    Console.Write("World");
                }
                Console.Write("\n");
            }
        }

        public void iterateWithQP(int n, int p, int q)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 5)
                {
                    Console.Write(p);
                }
                else if (i == 7)
                {
                    Console.Write(q);
                    checker(q);
                }
                else
                {
                    Console.Write(i);
                    checker(p);
                }
                Console.Write("\n");
            }
        }

        private void checker(int i)
        {
            if (i % 5 == 0)
            {
                Console.Write("Hello");
            }
            if (i % 7 == 0)
            {
                Console.Write("World");
            }
        }

        public void fibCreator(int start, int length)
        {
            int prev = 0;
            int temp = 0;
            int curr = start;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(prev + curr);
                temp = prev;
                prev = curr;
                curr = prev + temp;
            }
        }

        public void xmlChecker(string xmlInput)
        {
            if(xmlInput.Contains("<root>") && xmlInput.Contains("<br />"))
            {
                Console.WriteLine("The XML text is well-formed");
            }
            else if(xmlInput == null)
            {
                Console.WriteLine("Invalid input: Input Null");
            }
            else
            {
                Console.WriteLine("There are one or more errors in your XML text");
            }
        }

        public static void dialogOptions()
        {
            Console.WriteLine("Please select the function you wish to run by entering the number next to each:");
            Console.WriteLine("1. Iterate with N");
            Console.WriteLine("2. Iterate With P and Q");
            Console.WriteLine("3. Fibonacci Creator");
            Console.WriteLine("4. XML Well-Formed Check");
        }

        public static void userInput(string input)
        {
            interfaceClass functions = new interfaceClass();
            if (input == "1")
            {
                Console.WriteLine("What would you like N to be?");
                int n = Int32.Parse(Console.ReadLine());
                functions.iterate(n);
            }
            else if (input == "2")
            {
                Console.WriteLine("What would you like N to be?");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What would you like Q to be?");
                int q = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What would you like P to be?");
                int p = Int32.Parse(Console.ReadLine());
                functions.iterateWithQP(n,q,p);
            }
            else if (input == "3")
            {
                Console.WriteLine("What would you like the Start to be?");
                int start = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What would you like the Length to be?");
                int length = Int32.Parse(Console.ReadLine());
                functions.fibCreator(start,length);
            }
            else if (input == "4")
            {
                Console.WriteLine("What would you like the XML text to be?");
                functions.xmlChecker(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Unknown Entry Please Try Again");
                dialogOptions();
                userInput(Console.ReadLine());
            }
        }
    }
}