namespace Skobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daj skobi: ");
            string brackets = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            foreach (char item in brackets)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    stack.Pop();
                }
            }

            if (isBalanced && stack.Count == 0)
            {
                Console.WriteLine("Balansirano");
            }
            else
            {
                Console.WriteLine("Ne e balansirano");
            }
        }
    }
}
