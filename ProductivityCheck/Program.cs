using System.Diagnostics;

namespace ProductivityCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string filePath = @"C:\Users\nisso\Desktop\Text1.txt";
            string text = File.ReadAllText(filePath);
            string[] words = text.Split(new char[] { ' ','\n', '.', '–', '*' }, StringSplitOptions.RemoveEmptyEntries);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<string> list = new List<string>();
            foreach (string word in words)
            {
                list.Add(word);
            }
            stopwatch.Stop();
            Console.WriteLine($"Время вставки в List<T>: {stopwatch.ElapsedMilliseconds} мс");

            stopwatch.Restart();
            LinkedList<string> linkedList = new LinkedList<string>();
            foreach (string word in words)
            {
                linkedList.AddLast(word);
            }
            stopwatch.Stop();
            Console.WriteLine($"Время вставки в LinkedList<T>: {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}
