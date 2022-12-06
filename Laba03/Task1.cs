internal class Task1
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Undefined";
            age = 1;
        } 

        public void GetPerson()
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }

        public void SetPerson()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            age = int.Parse(Console.ReadLine());
        }
    }
    static void Main()
    {
        Person person = new Person();
        person.SetPerson();
        person.GetPerson();
    }
}



