namespace L2___Lesson_9___Extension_Methods_and_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myExtensions = new MyExtensions();//galima daryti jei klase butu ne static


            var myString = "Sveiki, kaip gyvenate?";
            var wordsCount = MyExtensions.WordCount(myString);


            var wordsCount2 = myString.WordCount2();

            Console.WriteLine(wordsCount);
            Console.WriteLine(wordsCount2);

            Console.WriteLine($"number -5 is negative? {(-5).IsNegative()}");
        }
    }
}