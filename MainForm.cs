
namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        List<Pet> pets = new List<Pet>();
        public string ImagePath; 

        public MainForm()
        {
            InitializeComponent();
            TypeListBox.Items.Add("�����");
            TypeListBox.Items.Add("������");
            TypeListBox.Items.Add("�����");

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
                MessageBox.Show("�� �� ����� ���!");
            }

            bool result = int.TryParse(HealthTextBox.Text, out int enteredAge);
            if (!result)
            {
                MessageBox.Show("������������ �������!");
                enteredAge = 1;
            }
            string gender = "";
            if (MaleRadioButton.Checked)
            {
                gender = "�����";
            }
            if (FemaleRadioButton.Checked)
            { 
                gender = "�����";
            }

            if (VaccinatedCheckBox.Checked)
            {
                listCharacterictic.Add("������");
            }
            if (AggressiveCheckBox.Checked)
            {
                listCharacterictic.Add("�����������");
            }
            if (SleepDayCheckBox.Checked)
            {
                listCharacterictic.Add("���� ����");
            }

            string selectedType = TypeListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("�� �� ������� ��� ���������!");
                return;
            }

            DateTime dateBirth = dateTimePickerBirth.Value;

            string ImagePathForClass = ImagePath;

            bool resultForHealth = int.TryParse(HealthTextBox.Text, out int Health);


            if (!resultForHealth)
            {
                MessageBox.Show("������������ ��������!");
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
