namespace dotnet_linq_to_object
{
    public class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public int age;
        public double avgScore;
        public int groupId;

        public override string ToString()
        {
            return $"firstName: {firstName}, lastName: {lastName}";
        }
    }
}