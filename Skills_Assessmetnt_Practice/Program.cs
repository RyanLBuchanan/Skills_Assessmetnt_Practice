namespace Skills_Assessmetnt_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(6);


            for (int i = 1; i <= 6; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Count);
        }
    }
}