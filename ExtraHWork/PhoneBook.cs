

namespace ExtraHWork
{
    internal class PhoneBook
    {
        //создаем лист контактов
        private List<Contact> contacts = new List<Contact>();       

        //метод для добавления контакта в List
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        //метод для удаления контакта from List
        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        //поиск по имени 
        public Contact SearchContactByName(string FirstName, string LastName)
        {
            return contacts.Find(contacts => contacts.firstName == FirstName && contacts.lastName == LastName);
        }

        //отображение всей книги контактов 
        public void DisplayPhoneBook()
        {
            Contact.Print("Phone Book: ");
            foreach (Contact contact in contacts)
            {
                contact.DisplayInfo();
            }
        }
    }
}
