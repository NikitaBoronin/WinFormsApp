namespace WinFormsApp1
{
    public class Pet
    {
        public Pet(string name, string gender, List<string> characteristics, string type, DateTime birthday, int health, string PhotoImage)
        {
            Name = name;
            Gender = gender;
            Characteristics = characteristics;
            Type = type;
            DateOfBirth = birthday;
            Health = health;
            ImagePath = PhotoImage;
        }

        public Pet()
        {
            
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Characteristics { get; set; } = new List<string>();
        public string Type { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Health { get; set; }
        public string ImagePath { get; set; }
    }
    
}
