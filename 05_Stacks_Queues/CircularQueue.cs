using System.Data;

namespace DSA_VSCode._05_Stacks_Queues
{
    public class MyCircularQueue
    {
        private int[] data;
        private int front;
        private int rear;
        private int count;
        public MyCircularQueue(int size)
        {
            data = new int[size];
            front = 0;
            rear = -1;
            count = 0;

        }
        // Add Values in Queue
        public void CirEnque(int val)
        {
            if (count == data.Length)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            rear = (rear + 1) % data.Length;
            data[rear] = val;
            count++;
        }
        // Remove Value from Circular Queue
        public int CirDeque()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int val = data[front];
            front = (front + 1) % data.Length;
            count--;
            return val;
        }
        // Peek into Circular Queue
        public int CirPeek()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            return data[front];
        }
        // Display Queue
        public void DisplayCirQueue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            int index = front;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[index]);
                index = (index + 1) % data.Length;
            }
        }

    }

}