using NLog;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        List<Pet> pets = new List<Pet>();
        public string ImagePath; 

        public MainForm()
        {
            InitializeComponent();
            TypeListBox.Items.Add("Кошка");
            TypeListBox.Items.Add("Собака");
            TypeListBox.Items.Add("Хомяк");

        }

        private void LoadPathButton_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            opf.ShowDialog();
            ImagePath = opf.FileName;
        }

        private void SeeButton_Click(Object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<string> listCharacterictic = new List<string>();
            
            string enteredName = NameTextBox.Text;

            if (string.IsNullOrEmpty(enteredName) )
            {
                logger.Error("Ошибка при загрузке вводе имени.");
                MessageBox.Show("Вы не ввели имя!");
            }

            bool result = int.TryParse(HealthTextBox.Text, out int enteredAge);
            if (!result)
            {
                logger.Error("Ошибка при загрузке вводе возраста.");
                MessageBox.Show("Некорректный возраст!");
                enteredAge = 1;
            }
            string gender = "";
            if (MaleRadioButton.Checked)
            {
                gender = "Самец";
            }
            if (FemaleRadioButton.Checked)
            { 
                gender = "Самка";
            }

            if (VaccinatedCheckBox.Checked)
            {
                listCharacterictic.Add("Привит");
            }
            if (AggressiveCheckBox.Checked)
            {
                listCharacterictic.Add("Агрессивный");
            }
            if (SleepDayCheckBox.Checked)
            {
                listCharacterictic.Add("Спит днем");
            }

            string selectedType = TypeListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedType))
            {
                logger.Error("Ошибка при загрузке вводе типа.");
                MessageBox.Show("Вы не выбрали тип животного!");
                return;
            }

            DateTime dateBirth = dateTimePickerBirth.Value;

            string ImagePathForClass = ImagePath;

            bool resultForHealth = int.TryParse(HealthTextBox.Text, out int Health);


            if (!resultForHealth)
            {
                logger.Error("Ошибка при загрузке вводе здоровья.");
                MessageBox.Show("Некорректное здоровье!");
                Health = 0;
            }


            pets.Add(new Pet(enteredName, gender, listCharacterictic, selectedType, dateBirth, Health, ImagePathForClass));
            var XMLserialization = new XmlReadWrite();
            var Jsonserialization = new JsonReadWrite();

            XMLserialization.Write(pets);
            Jsonserialization.Write(pets);
            NameTextBox.Clear();
            HealthTextBox.Clear();

            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;

            VaccinatedCheckBox.Checked = false;
            AggressiveCheckBox.Checked = false;
            SleepDayCheckBox.Checked = false;

            TypeListBox.ClearSelected();

            dateTimePickerBirth.Value = DateTime.Now;

            ImagePath = null;
        }
    }
}
