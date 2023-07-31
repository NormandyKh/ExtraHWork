
namespace ExtraHWork
{
    internal class Contact
    {
        //переменные с автосвойством 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        //конструктор
        public Contact(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        //метод для отображения информации контакта(виртуальный)
        public virtual void DisplayInfo()
        {
            Print($"Name: {firstName} {lastName}");
            Print($"Phone number: {phoneNumber}");
        }

        //заменяем cw
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
