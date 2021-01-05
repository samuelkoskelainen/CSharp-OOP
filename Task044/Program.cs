using System;
using System.Linq;

namespace Task044
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IntegerFixedStack");
            IntegerFixedStack x = new IntegerFixedStack();
            x.Push(1);
            x.Push(2);
            x.Push(3);
            x.Pop();
            x.Size();
            x.Pop();
            x.Size();
            x.Pop();

            Console.WriteLine();
            Console.WriteLine("IntegerDynamicStack");
            IntegerDynamicStack y = new IntegerDynamicStack();
            y.Push(1);
            y.Push(2);
            y.Push(3);
            y.Pop();
            y.Size();
            y.Pop();
            y.Size();
            y.Pop();

            Console.ReadLine();
        }
    }

    interface IStackable
    {
        public void Push(int number);

        public void Pop();

        public void Size();
    }

    class IntegerFixedStack : IStackable
    {
        private int[] stack = new int[2];
        public IntegerFixedStack() 
        {
            
        }

        public void Push(int number)
        {
            try
            {

            if (number <= stack.Length)
            {
                for (int i = 0; i < stack.Length; i++)
                {
                    stack[i] = i + 1;
                }
            } 
            else
            {
                throw new Exception();
            }
            } 
            catch (Exception)
            {
                Console.WriteLine("No room to push to fixed stack.");
            }
        }

        public void Pop()
        {
            try
            {
                if (stack.Length >= 1)
                {
                    Array.Resize(ref stack, stack.Length - 1);
                } 
                else
                {
                    throw new Exception();
                }
            } catch(Exception)
            {
                Console.WriteLine("Cannot pop when there is nothing to pop.");
            }
        }

        public void Size()
        {
            Console.WriteLine("The stack size is {0}", stack.Length + 1);
        }
    }

    class IntegerDynamicStack : IStackable
    {
        private int[] stack = new int[2];

        public IntegerDynamicStack()
        {

        }

        public void Push(int number)
        {
            if (number <= stack.Length) {
                for (int i = 0; i < stack.Length; i++)
                {
                    stack[i] = i + 1;
                }
            }
            else
            {
                Array.Resize(ref stack, stack.Length * 2);
                for (int i = 1; i <= number; i++)
                {
                    stack[i] = i;
                }
            }
        }

        public void Pop()
        {
            try
            {
                if (stack.Length >= 1)
                {
                    Array.Resize(ref stack, stack.Length - 1);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot pop when there is nothing to pop.");
            }
        }

        public void Size()
        {
            Console.WriteLine("The stack size is {0}", stack.Length + 1);
        }
    }
}
