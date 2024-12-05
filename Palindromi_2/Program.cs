namespace Palindromi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai duma: ");
            string word = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
            }

            bool Palindrom = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != stack.Pop())
                {
                    Palindrom = false;
                    break;
                }
            }
            if (Palindrom == true)
            {
                Console.WriteLine("dumata e palindrom");
            }
            else
            {
                Console.WriteLine("dumata ne e palindrom");
            }
        }
    }
}
