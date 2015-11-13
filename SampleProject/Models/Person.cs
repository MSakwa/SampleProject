namespace SampleProject.Models
{
    public class Person
    {
        public Person(string vrpFirstName, string vrpLastName, int vrpAge)
        {
            FirstName = vrpFirstName;
            LastName = vrpLastName;
            Age = vrpAge;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
    }
}