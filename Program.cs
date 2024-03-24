namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(2, "abc");

            Console.WriteLine(student1.id);

            student1.crazy(student1.name);
        }
    }
}
