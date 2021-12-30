namespace AddressBookApplication
{
    public class Program
    {
        public static void Main(String[] args)
        {
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            Console.WriteLine("\t(((((Welcome To Address Book                                      )))))");
            Console.WriteLine("\t(((((Enter add Command to add people.                             )))))");
            Console.WriteLine("\t(((((Enter list Command to list people                            )))))");
            Console.WriteLine("\t(((((Enter edit Command to edit  people                           )))))");
            Console.WriteLine("\t(((((Enter remove Command to edit  people                         )))))");
            Console.WriteLine("\t(((((Enter find Command to find  people                           )))))");
            Console.WriteLine("\t(((((Enter the sort command to sort the name in alphabetical order)))))");


            string command = "";
            while (command != "exit")
            {
                // Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        addressBookManagement.AddPerson();

                        break;
                    case "edit":
                        addressBookManagement.edit();
                        break;
                    case "remove":
                        addressBookManagement.RemovePerson();
                        break;
                    case "list":
                        addressBookManagement.ListPeople();
                        break;
                    case "find":
                        addressBookManagement.FindPersonInCityOrState();
                        break;
                    case "sort":
                        addressBookManagement.sortByFirstName();
                        break;


                }
            }


        }

    }

}













