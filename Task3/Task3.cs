using System.Transactions;
using System.Xml.Linq;

internal class Program
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        public void GetPerson()
        {
            Console.WriteLine("Name: " + name + " \nAge: " + age);
        }
        public void SetPerson()
        {
            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter an age: ");
            age = int.Parse(Console.ReadLine());
        }
    }

    class Family
    {
        Person[] family;
        public Family(int n)
        {
            family = new Person[n];
        }
        public void SetFamily()
        {

            for (int i = 0; i < family.Length; i++)
            {
                Person arr = new Person();
                family[i] = arr;
                arr.SetPerson();
            }
        }
        public void GetFamily()
        {
            for (int i = 0; i < family.Length; i++)
            {
                family[i].GetPerson();
            }
        }
        public void GetOldestMember()
        {
            Person theOldest = new Person();
            foreach (var term in family)
            {
                if (theOldest.getAge() < term.getAge())
                {
                    theOldest = term;
                }
            }
            Console.WriteLine("Name: " + theOldest.getName() + "\nAge: " + theOldest.getAge());
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter a count: ");
        Family family = new Family(int.Parse(Console.ReadLine()));

        family.SetFamily();
        Console.WriteLine();
        Console.WriteLine("All members: ");
        family.GetFamily();
        Console.WriteLine();
        Console.WriteLine("The Oldest member: ");
        family.GetOldestMember();
    }
}