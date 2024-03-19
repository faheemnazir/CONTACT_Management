namespace contacts;

public class manageContacts
{
    private List<Contact> contacts;

    public manageContacts()
    {
        contacts = new List<Contact>();
    }

    public void AddContact()
    {
        Contact newContact = new Contact();

        Console.WriteLine("Enter First Name:");
        newContact.FirstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        newContact.LastName = Console.ReadLine();

        Console.WriteLine("Enter Zip Code:");
        newContact.ZipCode = Console.ReadLine();

        Console.WriteLine("Enter Address:");
        newContact.Address = Console.ReadLine();

        Console.WriteLine("Enter City:");
        newContact.City = Console.ReadLine();

        Console.WriteLine("Enter Phone Number:");
        newContact.PhoneNumber = Console.ReadLine();

        Console.WriteLine("Enter Email:");
        newContact.Email = Console.ReadLine();

        contacts.Add(newContact);
        Console.WriteLine("Contact added successfully!");
    }

    public void DeleteContact()
    {
        Console.WriteLine("Enter the First Name of the contact you want to delete:");
        string firstName = Console.ReadLine();

        Contact contactToRemove = contacts.Find(contact => contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        if (contactToRemove != null)
        {
            contacts.Remove(contactToRemove);
            Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    public void EditContact()
    {
        Console.WriteLine("Enter the First Name of the contact you want to edit:");
        string firstName = Console.ReadLine();

        Contact contactToEdit = contacts.Find(contact => contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        if (contactToEdit != null)
        {
            Console.WriteLine("Enter new First Name:");
            contactToEdit.FirstName = Console.ReadLine();

            Console.WriteLine("Enter new Last Name:");
            contactToEdit.LastName = Console.ReadLine();

            Console.WriteLine("Enter new Zip Code:");
            contactToEdit.ZipCode = Console.ReadLine();

            Console.WriteLine("Enter new Address:");
            contactToEdit.Address = Console.ReadLine();

            Console.WriteLine("Enter new City:");
            contactToEdit.City = Console.ReadLine();

            Console.WriteLine("Enter new Phone Number:");
            contactToEdit.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter new Email:");
            contactToEdit.Email = Console.ReadLine();

            Console.WriteLine("Contact edited successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    public void DisplayAllContacts()
    {
        Console.WriteLine("Contacts:");
        foreach (var contact in contacts)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"First Name: {contact.FirstName}\n Last Name: {contact.LastName} \n " +
                              $"Zip Code: {contact.ZipCode} \n Address: {contact.Address} \n " +
                              $"City: {contact.City}\n Phone Number: {contact.PhoneNumber} \n" +
                              $"Email: {contact.Email}");
            Console.WriteLine("---------------------------------------------------------------------------");
        }
    }
}