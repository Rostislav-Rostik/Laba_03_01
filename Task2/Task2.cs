internal class Task2
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

        public Person (int age)
        {
            name = "Undefined";
            this.age = age;
        }
        
        public Person (string name, int age)
        {
            this.name = name; 
            this.age = age;
        }

        public void GetPerson()
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }
    }
    static void Main()
    {
        Person empty = new Person();
        Person half = new Person(18);
        Person full = new Person("Rostik", 18);

        empty.GetPerson();
        half.GetPerson();
        full.GetPerson();
    }
}

