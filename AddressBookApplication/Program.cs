public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string[] Addresses { get; set; }
    public int zip { get; set; }
    public string email { get; set; }
    public static List<Person> People = new List<Person>();
}
