using ExtraHWork;

PhoneBook phoneBook = new PhoneBook();

Contact contact1 = new Contact("Michael", "Jackson", "0672558672");
Contact contact2 = new Contact("Eddy", "Gordo", "0632134252");
Family contact3 = new Family("Robert", "Pattinson", "067672534", "Father");

phoneBook.AddContact(contact1);
phoneBook.AddContact(contact2);
phoneBook.AddContact(contact3);
phoneBook.RemoveContact(contact2);

Contact foundContact = phoneBook.SearchContactByName("Eddy", "Gordo");
if (foundContact != null)
{
    Console.WriteLine("Found Contact: ");
    foundContact.DisplayInfo();
}
else
{
    Console.WriteLine("Contact not found.");
}

phoneBook.DisplayPhoneBook();