
namespace ExtraHWork
{
    //наследуемся от класса контакт 
    internal class Family : Contact
    {
        public string kinship { get; set; }       

        //добавляем в конструктор родство
        public Family(string firstName, string lastName, string phoneNumber, string kinship) : base(firstName, lastName, phoneNumber)
        {
            this.kinship = kinship;
        }

        //метод для отображения информации контакта(оверрайд)
        public override void DisplayInfo()
        {
            Print($"Name: {firstName} {lastName}");
            Print($"Phone number: {phoneNumber}");
            Print($"Kinship: {kinship}");
        }
    }
}
