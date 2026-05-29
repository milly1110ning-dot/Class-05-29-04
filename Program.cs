namespace Class_05_29_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(86, 96);
            Student s2 = new Student(60, 75);

            Student savg = s1 + s2;
            Console.WriteLine(savg.Mid);
            Console.WriteLine(savg.Final);

        }
    }
}
