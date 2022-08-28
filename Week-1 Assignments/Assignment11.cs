using System;

namespace Week1_Assignments
{
    namespace Entities
    {
        class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public double PhoneNo { get; set; }
        }
    }

    namespace Repository
    {
        using Entities;
        class CustomerRepo
        {
            public CustomerRepo(int size)//constructor
            {
                _customers = new Customer[size];
            }
            private Customer[] _customers = null;//null for reference types
            public void AddNewCustomer(Customer customer)
            {
                //find the first occurance of null in the array
                for (int i = 0; i < _customers.Length; i++)
                {
                    if (_customers[i] == null)
                    {
                        _customers[i] = new Customer
                        {
                            CustomerId = customer.CustomerId,
                            Name = customer.Name,
                            Address = customer.Address,
                            PhoneNo = customer.PhoneNo,
                            
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No further Customers can be added here!!!");
            }
            public void UpdateCustomer(int id, Customer customer)
            {
                //find the first occurance of null in the array
                for (int i = 0; i < _customers.Length; i++)
                {
                    if (_customers[i] != null && _customers[i].CustomerId == id)
                    {
                        _customers[i] = new Customer
                        {
                            CustomerId = customer.CustomerId,
                            Name = customer.Name,
                            Address = customer.Address,
                            PhoneNo = customer.PhoneNo,
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No Customer was found to Update!!!");
            }
            public void DeleteCustomer(int id)
            {
                //Iterate thru the array
                for (int i = 0; i < _customers.Length; i++)
                {
                    //find the matching Customer with id and non null
                    if (_customers[i] != null && _customers[i].CustomerId == id)
                    {
                        //set it to null. U cannot delete an object in .NET. 
                        _customers[i] = null;//Informal Deletion
                        //exit the function.
                        return;
                    }
                }
            }
            public Customer FindCustomer(int id)
            {
                foreach (Customer Customer in _customers)
                {
                    if (Customer.CustomerId == id)
                        return Customer;
                }
                throw new Exception("No Customer was found by id " + id);
            }
        }
    }

    namespace UserInterface
    {
        using Entities;
        class Util
        {
            public static string GetString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            public static int GetNumber(string question)
            {
                return int.Parse(GetString(question));
            }
            public static short GetShortNumber(string question) => short.Parse(GetString(question));

            public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
        }
        class UIClass
        {
            private static Repository.CustomerRepo repo = null;
            const string menu = "\n~~~~~~~~~~~~~~~~~~~~~~~~~CUSTOMER REPOSITORY MANAGER~~~~~~~~~~~~~~~~~~~~~~~\nTO ADD NEW CUSTOMER------------>PRESS 1\nTO UPDATE CUSTOMER DETAILS------------->PRESS 2\nTO DELETE A CUSTOMER----------->PRESS 3\nTO FIND BY ID-------------->PRESS 4\nPS: ANY OTHER KEY IS EXIT.............................................\n";
            static void Main(string[] args)
            {
                int size = Util.GetNumber("Enter the no of Customers in your store");
                repo = new Repository.CustomerRepo(size);
                var processing = true;
                do
                {
                    string choice = Util.GetString(menu);
                    processing = processMenu(choice);
                } while (processing);
            }
            private static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "1"://for adding
                        addingCustomerFeature();
                        break;
                    case "3"://for deleting
                        deletingCustomerFeature();
                        break;
                    case "2"://for updating
                        updatingCustomerFeature();
                        break;
                    case "4"://finding by id
                        findingByIdFeature();
                        break;
                    default:
                        return false;
                }
                return true;
            }
            private static void findingByIdFeature()
            {
                //take id from the user
                int id = Util.GetNumber("Enter the Id of the Customer to find");
                //call the repo function
                var foundCustomer = repo.FindCustomer(id);
                if (foundCustomer != null)
                {
                    //display the Customer details 
                    Console.WriteLine($"The Name of the Customer is {foundCustomer.Name} from {foundCustomer.Address}, dial {foundCustomer.PhoneNo} to contact the person and Customer ID is {foundCustomer.CustomerId}");
                }
                else
                {
                    Console.WriteLine("Customer not found to display!!!!");
                }
            }
            private static void updatingCustomerFeature()
            {
                //take inputs from the user
                var bk = createCustomer();
                //call the add method of the repo and pass the Customer into it. 
                repo.UpdateCustomer(bk.CustomerId, bk);
                //display the message
                Console.WriteLine("Customer details updated successfully");
            }
            private static Customer createCustomer()
            {
                int id = Util.GetNumber("Enter the Id of the Customer ");
                string Name = Util.GetString("Enter the Name ");
                string Address = Util.GetString("Enter the Address ");
                double PhoneNo = Util.GetDoubleNumber("Enter the PhoneNo of the Customer ");
                //create the new Customer object
                Customer bk = new Customer
                {
                    CustomerId = id,
                    Address = Address, 
                    Name = Name,
                    PhoneNo = PhoneNo,
                };
                return bk;
            }
            private static void deletingCustomerFeature()
            {
                //Ask the user to enter the id of the Customer
                int id = Util.GetNumber("Enter the Id of the Customer to delete");
                //call the Repo's function to delete
                repo.DeleteCustomer(id);
                //display the message
                Console.WriteLine("Customer deleted Successfully");
            }
            private static void addingCustomerFeature()
            {
                //take inputs from the user
                Customer bk = createCustomer();
                //call the add method of the repo and pass the Customer into it. 
                repo.AddNewCustomer(bk);
                //display the message
                Console.WriteLine("Customer added successfully");
            }
        }
    }
}