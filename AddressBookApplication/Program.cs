public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string[] Addresses { get; set; }
    public int zip { get; set; }
    public string email { get; set; }
    public static List<Person> People = new List<Person>();

    private static void AddPerson()
    {
        Person person = new Person();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        person.PhoneNumber = Console.ReadLine();
        Console.Write("Enter Emai:");
        person.email = Console.ReadLine();

        Console.Write("Enter Address: ");
        string[] addresses = new string[3];
        addresses[0] = Console.ReadLine();
        Console.Write("Enter City: ");
        addresses[1] = Console.ReadLine();
        Console.Write("Enter State: ");
        addresses[2] = Console.ReadLine();

        Console.Write("Enter zip:");
        person.zip=Convert.ToInt32(Console.ReadLine());
        person.Addresses = addresses;

        People.Add(person);
    }
    private static void PrintPerson(Person person)
    {
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Phone Number: " + person.PhoneNumber);
        Console.WriteLine("Address: " + person.Addresses[0]);
        Console.WriteLine("city: " + person.Addresses[1]);
        Console.WriteLine("State : " + person.Addresses[1]);
        Console.WriteLine("Zip:"+person.zip);
        Console.WriteLine("-------------------------------------------");
    }
    public static void Main(String[] args)
    {

        Console.WriteLine("\t(((((Welcome To Address Book               )))))");
        Console.WriteLine("\t(((((Enter add Command to add people.      )))))");
        Console.WriteLine("\t(((((Enter list Command to list people     )))))");
        Console.WriteLine("\t(((((Enter edit Command to edit  people     )))))");
        string command = "";
        while (command != "exit")
        {
            // Console.Clear();
            Console.WriteLine("Please enter a command: ");
            command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "add":
                    AddPerson();

                    break;
                //case "edit":
                //    edit();
                //    break;

                case "list":
                    ListPeople();
                    break;
            }
        }


    }
    private static void ListPeople()
    {
        if (People.Count == 0)
        {
            Console.WriteLine("Your address book is empty. Press any key to continue.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Here are the current people in your address book:\n");
        foreach (var person in People)
        {
            PrintPerson(person);
        }
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
    }
    public static void edit()
    {
        Console.WriteLine("Enter the first name of the person you would like to edit.");
        string firstName = Console.ReadLine();
        Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
        if (person != null)
        {
            People.Remove(person);
            Console.WriteLine("Please detail again As you want changes!!!");
            Person person1 = new Person();

            Console.Write("Enter First Name: ");
            person1.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person1.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person1.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Emai:");
            person1.email = Console.ReadLine();

            Console.Write("Enter Address: ");
            string[] addresses = new string[3];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter City: ");
            addresses[1] = Console.ReadLine();
            Console.Write("Enter State: ");
            addresses[2] = Console.ReadLine();

            Console.Write("Enter zip:");
            person1.zip=Convert.ToInt32(Console.ReadLine());
            person1.Addresses = addresses;
            People.Add(person1);
            Console.ReadKey();

            return;
        }
        else
        {
            Console.WriteLine("That person could not be found. Press any key to continue");
            Console.ReadKey();

            Console.ReadKey();

        }





    }
}