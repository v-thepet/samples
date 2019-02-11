namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("John", "Smith", 30);
        }
    XmlTextReader
    }
    class Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}



