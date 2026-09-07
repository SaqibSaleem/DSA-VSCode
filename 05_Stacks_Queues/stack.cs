using System.Data;

namespace DSA_VSCode._05_Stacks_Queues
{
    public class MyStack
    {
        private int[] data;
        private int top;
        public MyStack(int size)
        {
            data = new int[size];
            top = -1;
        }
        public void Push(int val)
        {
            if (top == data.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            top++;
            data[top] = val;
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int CurrentVal = data[top];
            top--;
            return CurrentVal;
        }
        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int val = data[top];
            return val;
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayStack()
        {

            if (!IsEmpty())
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(data[i]);
                }
            }

        }
    }

}