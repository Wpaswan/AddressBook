﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApplication
{
    public class AddressBookManagement
    {
        public static List<Person> People = new List<Person>();

        public static Dictionary<string, List<Person>> PeopleDictionary = new Dictionary<string, List<Person>>();


        public void AddPerson()
        {
            Person person = new Person();
            Console.Write("Enter Address Book name:");
            string? AddressBookName = Console.ReadLine();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Emai:");
            person.email = Console.ReadLine();

            Console.Write("Enter Address: ");

            person.Addresses = Console.ReadLine();

            Console.Write("Enter City: ");
            person.city = Console.ReadLine();
            Console.Write("Enter State: ");
            person.state = Console.ReadLine();

            Console.Write("Enter zip:");
            person.zip=Convert.ToInt32(Console.ReadLine());
            //use LINQ to query the list for the first person with the same first name as the first name the user entered.
            //used lambda operator

            Person person1 = People.FirstOrDefault(x => x.FirstName==person.FirstName);
            Person person2 = People.FirstOrDefault(x => x.LastName==person.LastName);
            //Duplicate Check is done on Person Name while adding person to Address Book
            if (person1!=null && person2!=null)
            {
                Console.WriteLine("Sorry this contact exist");
            }
            else
            {

                People.Add(person);
                PeopleDictionary[AddressBookName]=People;
            }


           



        }
        public void sortByFirstName()
        {
            foreach (var addressBook in PeopleDictionary)
            {
                Console.WriteLine("Address book name:"+addressBook.Key);

                foreach (var person in
                    addressBook.Value.OrderBy(x => x.FirstName))
                {
                    Console.WriteLine("First Name: " + person.FirstName);
                    Console.WriteLine("Last Name: " + person.LastName);
                    Console.WriteLine("Phone Number: " + person.PhoneNumber);
                    Console.WriteLine("Address: " + person.Addresses);
                    Console.WriteLine("city: " + person.city);
                    Console.WriteLine("State : " + person.state);
                    Console.WriteLine("Zip:"+person.zip);
                    Console.WriteLine("-------------------------------------------");
                }
            }

        }
        public void sortByCityStateOrZip()
        {
            Console.WriteLine("Enter 1 for city 2 for state and 3 for zip to sort the details");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    foreach (var addressBook in PeopleDictionary)
                    {
                        Console.WriteLine("Address book name:"+addressBook.Key);

                        foreach (var person in
                            addressBook.Value.OrderBy(x => x.city))
                        {
                            Console.WriteLine("First Name: " + person.FirstName);
                            Console.WriteLine("Last Name: " + person.LastName);
                            Console.WriteLine("Phone Number: " + person.PhoneNumber);
                            Console.WriteLine("Address: " + person.Addresses);
                            Console.WriteLine("city: " + person.city);
                            Console.WriteLine("State : " + person.state);
                            Console.WriteLine("Zip:"+person.zip);
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    break;
                    case 2:
                    foreach (var addressBook in PeopleDictionary)
                    {
                        Console.WriteLine("Address book name:"+addressBook.Key);

                        foreach (var person in
                            addressBook.Value.OrderBy(x => x.state))
                        {
                            Console.WriteLine("First Name: " + person.FirstName);
                            Console.WriteLine("Last Name: " + person.LastName);
                            Console.WriteLine("Phone Number: " + person.PhoneNumber);
                            Console.WriteLine("Address: " + person.Addresses);
                            Console.WriteLine("city: " + person.city);
                            Console.WriteLine("State : " + person.state);
                            Console.WriteLine("Zip:"+person.zip);
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    break;
                case 3:
                    foreach (var addressBook in PeopleDictionary)
                    {
                        Console.WriteLine("Address book name:"+addressBook.Key);

                        foreach (var person in
                            addressBook.Value.OrderBy(x => x.zip))
                        {
                            Console.WriteLine("First Name: " + person.FirstName);
                            Console.WriteLine("Last Name: " + person.LastName);
                            Console.WriteLine("Phone Number: " + person.PhoneNumber);
                            Console.WriteLine("Address: " + person.Addresses);
                            Console.WriteLine("city: " + person.city);
                            Console.WriteLine("State : " + person.state);
                            Console.WriteLine("Zip:"+person.zip);
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    break;
            }
        }
        public void ListPeople()
        {
            if (PeopleDictionary.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (KeyValuePair<string, List<Person>> valuePair in PeopleDictionary)
            {
                Console.WriteLine("Address book name:"+valuePair.Key);
                foreach (Person person in valuePair.Value)
                {

                    Console.WriteLine("First Name: " + person.FirstName);
                    Console.WriteLine("Last Name: " + person.LastName);
                    Console.WriteLine("Phone Number: " + person.PhoneNumber);
                    Console.WriteLine("Address: " + person.Addresses);
                    Console.WriteLine("city: " + person.city);
                    Console.WriteLine("State : " + person.state);
                    Console.WriteLine("Zip:"+person.zip);
                    Console.WriteLine("-------------------------------------------");
                }
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        public void edit()
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
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Emai:");
                person.email = Console.ReadLine();

                Console.Write("Enter Address: ");

                person.Addresses = Console.ReadLine();

                Console.Write("Enter City: ");
                person.city = Console.ReadLine();
                Console.Write("Enter State: ");
                person.state = Console.ReadLine();

                Console.Write("Enter zip:");
                person.zip=Convert.ToInt32(Console.ReadLine());



                People.Add(person);
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
        public void FindPersonInCityOrState()
        {
            Console.WriteLine("Enter  1. for city 2. state to find for particular person");
            int ch=Convert.ToInt32(Console.ReadLine());
            


            switch (ch)
            {
                case 1:
                    Console.WriteLine("Choose Type city else or state to find perticular person");
                    string city1 = Console.ReadLine();

                    //creating list of person according to city
                    List<Person> cityWisePeople = new List<Person>();
                    Dictionary<string, List<Person>> cityWisePeopleDictionary = new Dictionary<string, List<Person>>();


                    foreach (KeyValuePair<string, List<Person>> valuePair in PeopleDictionary)
                    { //for state do the same thing for state
                        Person person1 = valuePair.Value.Find(x => x.city.ToLower()==city1.ToLower());
                        if (person1!=null)
                        {
                            cityWisePeople.Add(person1);

                        }

                    }
                    cityWisePeopleDictionary[city1]=cityWisePeople;
                    Console.WriteLine($"People in {city1}: ");
                    foreach (var city in cityWisePeopleDictionary.Keys)
                    {
                        if (city.ToLower()==city1.ToLower())
                        {
                            foreach (var person in cityWisePeopleDictionary[city])
                            {
                                if (person!=null)
                                {
                                    Console.WriteLine("First Name: " + person.FirstName);
                                    Console.WriteLine("Last Name: " + person.LastName);
                                    Console.WriteLine("Phone Number: " + person.PhoneNumber);
                                    Console.WriteLine("Address: " + person.Addresses);
                                    Console.WriteLine("city: " + person.city);
                                    Console.WriteLine("State : " + person.state);
                                    Console.WriteLine("Zip:"+person.zip);
                                    Console.WriteLine("-------------------------------------------");
                                }
                            }
                        }
                    }
                   
                  int countPeople = cityWisePeopleDictionary.Count; 
                    Console.WriteLine("Total number of people in perticular city:"+countPeople);
                    break;
                    case 2:
                    Console.WriteLine("Enter state to find perticular person");
                    string SearchAccordingstate = Console.ReadLine();

                    //creating list of person according to city
                    List<Person> stateWisePeople = new List<Person>();
                    Dictionary<string, List<Person>> stateWisePeopleDictionary = new Dictionary<string, List<Person>>();


                    foreach (KeyValuePair<string, List<Person>> valuePair in PeopleDictionary)
                    { //Using lambda => here
                        Person person1 = valuePair.Value.Find(x => x.state.ToLower()==SearchAccordingstate.ToLower());
                        if (person1!=null)
                        {
                            stateWisePeople.Add(person1);

                        }

                    }
                    stateWisePeopleDictionary[SearchAccordingstate]=stateWisePeople;
                    Console.WriteLine($"People in {SearchAccordingstate}: ");
                    foreach (var state in stateWisePeopleDictionary.Keys)
                    {
                        if (state.ToLower()==SearchAccordingstate.ToUpper())
                        {
                            foreach (var person in stateWisePeopleDictionary[state])
                            {
                                if (person!=null)
                                {
                                    Console.WriteLine("First Name: " + person.FirstName);
                                    Console.WriteLine("Last Name: " + person.LastName);
                                    Console.WriteLine("Phone Number: " + person.PhoneNumber);
                                    Console.WriteLine("Address: " + person.Addresses);
                                    Console.WriteLine("city: " + person.city);
                                    Console.WriteLine("State : " + person.state);
                                    Console.WriteLine("Zip:"+person.zip);
                                    Console.WriteLine("-------------------------------------------");
                                }
                            }
                        }
                        
                    }
                    int countPeople1 = stateWisePeopleDictionary.Count;
                    Console.WriteLine("Total number of people in perticular city:"+countPeople1);
                    break;
                default:
                    Console.WriteLine("Wrong choice!!");
                    break;

            }

            
        }
        public void RemovePerson()
        {
            //use LINQ to query the list for the first person with the same first name as the first name the user entered.
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }

    }
}
