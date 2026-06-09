namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hangman hangman_game = new Hangman();
        }
    }
    public class Hangman
    {
        public Hangman()
        {
            BuildTheHangmanDefault();
     
        }
        private void BuildTheHangmanDefault()
        {
            Console.WriteLine("+--+");
            Console.WriteLine("|   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
        private void BuildTheHangmanGallows1(int number_of_mistakes)
        {
            Console.WriteLine("+--+");
            Console.WriteLine("|   |");
            Console.WriteLine("O   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
        private void BuildTheHangmanGallows2()
        {
            Console.WriteLine("+--+");
            Console.WriteLine("|   |");
            Console.WriteLine("O   |");
            Console.WriteLine("|   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
        private void BuildTheHangmanGallows3()
        {
            Console.WriteLine( "+--+");
            Console.WriteLine(" |   |");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
        private void BuildTheHangmanGallows4()
        {
            Console.WriteLine( "+--+");
            Console.WriteLine(" |   |");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
        private void BuildTheHangmanGallows5()
        {
            Console.WriteLine( "+--+");
            Console.WriteLine(" |   |");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("/     |");
            Console.WriteLine("     |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
        private void BuildTheHangmanGallows6()
        {
            Console.WriteLine( "+--+");
            Console.WriteLine(" |   |");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("/ \\ |");
            Console.WriteLine("     |");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
        }
    }

}
