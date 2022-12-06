using System.Transactions;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    static void Main()
    {
        var people = new List<Person>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var list_Name_Age = Console.ReadLine().Split();
            string name = list_Name_Age[0];
            int age = int.Parse(list_Name_Age[1]);

            var member = new Person(name, age);
            people.Add(member);
        }

        var result = people.Where(p => p.Age > 30).OrderBy(p => p.Name);

        foreach (var person in result)
        {
            Console.WriteLine(person.Name + " - " + person.Age);
        }
    }
}