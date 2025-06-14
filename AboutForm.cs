using NLog;

namespace WinFormsApp1
{
    public partial class AboutForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public AboutForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var jsonSerialization = new JsonReadWrite();

            List<Pet> pets = jsonSerialization.Read();
            if (pets == null || pets.Count == 0)
            {
                logger.Error("Ошибка при чтении JSON");
                MessageBox.Show("Нет сохранённых животных.");
                return;
            }

            PetsTreeView.Nodes.Clear();

            foreach (Pet pett in pets)
            {
                TreeNode node = new TreeNode(pett.Name);
                node.Tag = pett; // сохраняем весь объект Pet в Tag
                PetsTreeView.Nodes.Add(node);
            }

            AnimalsDataGridView.DataSource = null;
            AnimalsDataGridView.DataSource = pets;
            //Pet pet = pets[0];
            //NameLabel.Text = $"Имя: {pet.Name}";
            //GenderLabel.Text = $"Пол: {pet.Gender}";
            //foreach (string p in pet.Characteristics)
            //{
            //    CharacteristicsLabel.Text = $"Особенности: {p}";
            //}
            //TypeLabel.Text = $"Тип: {pet.Type}";
            //BirthDateTimePicker.Value = pet.DateOfBirth;
            //HealthprogressBar.Value = pet.Health;
            //AnimalPictureBox.Image = Image.FromFile(pet.ImagePath);


        }

        private void PetsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is Pet pet)
            {
                // Отображаем данные
                NameLabel.Text = $"Имя: {pet.Name}";
                GenderLabel.Text = $"Пол: {pet.Gender}";
                TypeLabel.Text = $"Тип: {pet.Type}";
                BirthDateTimePicker.Value = pet.DateOfBirth;
                HealthprogressBar.Value = pet.Health;

                // Отображаем особенности
                CharacteristicsLabel.Text = "Особенности: ";
                if (pet.Characteristics != null && pet.Characteristics.Count > 0)
                {
                    CharacteristicsLabel.Text += string.Join(", ", pet.Characteristics);
                }
                else
                {
                    CharacteristicsLabel.Text += "Нет";
                }

                // Показываем изображение
                try
                {
                    if (File.Exists(pet.ImagePath))
                    {
                        AnimalPictureBox.Image = Image.FromFile(pet.ImagePath);
                    }
                    else
                    {
                        logger.Info("Изображение не найдено!");
                        AnimalPictureBox.Image = null;
                        MessageBox.Show("Изображение не найдено.");
                    }
                }
                catch (Exception ex)
                {
                    logger.Error("Ошибка при загрузки изображения.");
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                }
            }
        }

        private void AnimalsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(AnimalsDataGridView.SelectedRows == null)
            {
                logger.Error("Ошибка при выборе.");
                MessageBox.Show("Пустое!");
                return;
            }

            var pet = AnimalsDataGridView.CurrentRow.DataBoundItem as Pet;
            if (pet == null )
            {
                logger.Error("Ошибка при загрузки данных.");
                MessageBox.Show("Пустое!");
                return;
            }

            NameLabel.Text = $"Имя: {pet.Name}";
            GenderLabel.Text = $"Пол: {pet.Gender}";
            TypeLabel.Text = $"Тип: {pet.Type}";
            BirthDateTimePicker.Value = pet.DateOfBirth;
            HealthprogressBar.Value = pet.Health;

            CharacteristicsLabel.Text = "Особенности: ";
            if (pet.Characteristics != null && pet.Characteristics.Count > 0)
            {
                CharacteristicsLabel.Text += string.Join(", ", pet.Characteristics);
            }
            else
            {
                CharacteristicsLabel.Text += "Нет";
            }

            try
            {
                if (File.Exists(pet.ImagePath))
                {
                    logger.Info("Изображение найдено");
                    AnimalPictureBox.Image = Image.FromFile(pet.ImagePath);
                }
                else
                {
                    logger.Info("Изображение не найдено");
                    AnimalPictureBox.Image = null;
                    MessageBox.Show("Изображение не найдено.");
                }
            }
            catch (Exception ex)
            {
                logger.Error("Ошибка при чтении изображения.");
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
            
        }
    }
}
