namespace Palindromi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi izrechenie: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split();

            Stack<string> stack = new Stack<string>();
            
            foreach (string word in words)
            {
                stack.Push(word);
            }
            
            Console.WriteLine($"Broj dumi: {stack.Count}");
            
            Console.Write("Obraten red: ");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}



