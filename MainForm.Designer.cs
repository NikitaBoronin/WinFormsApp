
namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLabel = new Label();
            GenderLabel = new Label();
            CharacteristicsLabel = new Label();
            TypeLabel = new Label();
            BirthLabel = new Label();
            LoadImageLabel = new Label();
            HealthLabel = new Label();
            NameTextBox = new TextBox();
            MaleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            VaccinatedCheckBox = new CheckBox();
            AggressiveCheckBox = new CheckBox();
            SleepDayCheckBox = new CheckBox();
            TypeListBox = new ListBox();
            dateTimePickerBirth = new DateTimePicker();
            LoadPathButton = new Button();
            SeeButton = new Button();
            SaveButton = new Button();
            HealthTextBox = new TextBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(28, 24);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Кличка:";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(28, 59);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(40, 20);
            GenderLabel.TabIndex = 1;
            GenderLabel.Text = "Пол:";
            // 
            // CharacteristicsLabel
            // 
            CharacteristicsLabel.AutoSize = true;
            CharacteristicsLabel.Location = new Point(28, 97);
            CharacteristicsLabel.Name = "CharacteristicsLabel";
            CharacteristicsLabel.Size = new Size(109, 20);
            CharacteristicsLabel.TabIndex = 2;
            CharacteristicsLabel.Text = "Особенности: ";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(28, 140);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(38, 20);
            TypeLabel.TabIndex = 3;
            TypeLabel.Text = "Тип:";
            // 
            // BirthLabel
            // 
            BirthLabel.AutoSize = true;
            BirthLabel.Location = new Point(29, 303);
            BirthLabel.Name = "BirthLabel";
            BirthLabel.Size = new Size(119, 20);
            BirthLabel.TabIndex = 4;
            BirthLabel.Text = "Дата рождения:";
            // 
            // LoadImageLabel
            // 
            LoadImageLabel.AutoSize = true;
            LoadImageLabel.Location = new Point(29, 355);
            LoadImageLabel.Name = "LoadImageLabel";
            LoadImageLabel.Size = new Size(119, 20);
            LoadImageLabel.TabIndex = 5;
            LoadImageLabel.Text = "Загрузить Фото:";
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.Location = new Point(29, 401);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(79, 20);
            HealthLabel.TabIndex = 6;
            HealthLabel.Text = "Здоровье:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(114, 24);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(268, 27);
            NameTextBox.TabIndex = 7;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(114, 66);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(75, 24);
            MaleRadioButton.TabIndex = 8;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Самец";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(309, 66);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(73, 24);
            FemaleRadioButton.TabIndex = 9;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Самка";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // VaccinatedCheckBox
            // 
            VaccinatedCheckBox.AutoSize = true;
            VaccinatedCheckBox.Location = new Point(143, 96);
            VaccinatedCheckBox.Name = "VaccinatedCheckBox";
            VaccinatedCheckBox.Size = new Size(83, 24);
            VaccinatedCheckBox.TabIndex = 10;
            VaccinatedCheckBox.Text = "Привит";
            VaccinatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // AggressiveCheckBox
            // 
            AggressiveCheckBox.AutoSize = true;
            AggressiveCheckBox.Location = new Point(266, 96);
            AggressiveCheckBox.Name = "AggressiveCheckBox";
            AggressiveCheckBox.Size = new Size(116, 24);
            AggressiveCheckBox.TabIndex = 11;
            AggressiveCheckBox.Text = "Агрессивен ";
            AggressiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // SleepDayCheckBox
            // 
            SleepDayCheckBox.AutoSize = true;
            SleepDayCheckBox.Location = new Point(388, 97);
            SleepDayCheckBox.Name = "SleepDayCheckBox";
            SleepDayCheckBox.Size = new Size(104, 24);
            SleepDayCheckBox.TabIndex = 12;
            SleepDayCheckBox.Text = "Спит днём";
            SleepDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypeListBox
            // 
            TypeListBox.FormattingEnabled = true;
            TypeListBox.Location = new Point(97, 140);
            TypeListBox.Name = "TypeListBox";
            TypeListBox.Size = new Size(150, 84);
            TypeListBox.TabIndex = 13;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(155, 303);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(286, 27);
            dateTimePickerBirth.TabIndex = 14;
            // 
            // LoadPathButton
            // 
            LoadPathButton.Location = new Point(155, 351);
            LoadPathButton.Name = "LoadPathButton";
            LoadPathButton.Size = new Size(286, 29);
            LoadPathButton.TabIndex = 15;
            LoadPathButton.Text = "Загрузить путь к изображению";
            LoadPathButton.UseVisualStyleBackColor = true;
            LoadPathButton.Click += LoadPathButton_Click;
            // 
            // SeeButton
            // 
            SeeButton.Location = new Point(674, 20);
            SeeButton.Name = "SeeButton";
            SeeButton.Size = new Size(94, 29);
            SeeButton.TabIndex = 17;
            SeeButton.Text = "Показать";
            SeeButton.UseVisualStyleBackColor = true;
            SeeButton.Click += SeeButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(536, 319);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(232, 102);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Сохранить данные";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // HealthTextBox
            // 
            HealthTextBox.Location = new Point(155, 401);
            HealthTextBox.Name = "HealthTextBox";
            HealthTextBox.Size = new Size(286, 27);
            HealthTextBox.TabIndex = 21;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HealthTextBox);
            Controls.Add(SaveButton);
            Controls.Add(SeeButton);
            Controls.Add(LoadPathButton);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(TypeListBox);
            Controls.Add(SleepDayCheckBox);
            Controls.Add(AggressiveCheckBox);
            Controls.Add(VaccinatedCheckBox);
            Controls.Add(FemaleRadioButton);
            Controls.Add(MaleRadioButton);
            Controls.Add(NameTextBox);
            Controls.Add(HealthLabel);
            Controls.Add(LoadImageLabel);
            Controls.Add(BirthLabel);
            Controls.Add(TypeLabel);
            Controls.Add(CharacteristicsLabel);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label NameLabel;
        private Label GenderLabel;
        private Label CharacteristicsLabel;
        private Label TypeLabel;
        private Label BirthLabel;
        private Label LoadImageLabel;
        private Label HealthLabel;
        private TextBox NameTextBox;
        private RadioButton MaleRadioButton;
        private RadioButton FemaleRadioButton;
        private CheckBox VaccinatedCheckBox;
        private CheckBox AggressiveCheckBox;
        private CheckBox SleepDayCheckBox;
        private ListBox TypeListBox;
        private DateTimePicker dateTimePickerBirth;
        private Button LoadPathButton;
        private Button SeeButton;
        private Button SaveButton;
        private TextBox HealthTextBox;
    }
}
