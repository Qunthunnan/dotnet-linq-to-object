namespace dotnet_linq_to_object
{
    public class Group
    {
        public int id;
        public string name;

        public override string ToString()
        {
            return $"Id: {id}, Name: {name}";
        }
    }
}