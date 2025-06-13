namespace WinFormsApp1
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PetsTreeView = new TreeView();
            AnimalPictureBox = new PictureBox();
            LoadButton = new Button();
            HealthLabel = new Label();
            BirthLabel = new Label();
            TypeLabel = new Label();
            CharacteristicsLabel = new Label();
            GenderLabel = new Label();
            NameLabel = new Label();
            HealthprogressBar = new ProgressBar();
            BirthDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PetsTreeView
            // 
            PetsTreeView.Location = new Point(22, 12);
            PetsTreeView.Name = "PetsTreeView";
            PetsTreeView.Size = new Size(395, 166);
            PetsTreeView.TabIndex = 0;
            PetsTreeView.AfterSelect += PetsTreeView_AfterSelect;
            // 
            // AnimalPictureBox
            // 
            AnimalPictureBox.Location = new Point(549, 12);
            AnimalPictureBox.Name = "AnimalPictureBox";
            AnimalPictureBox.Size = new Size(230, 193);
            AnimalPictureBox.TabIndex = 1;
            AnimalPictureBox.TabStop = false;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(549, 376);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(181, 59);
            LoadButton.TabIndex = 2;
            LoadButton.Text = "Загрузить данные";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.Location = new Point(22, 376);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(79, 20);
            HealthLabel.TabIndex = 13;
            HealthLabel.Text = "Здоровье:";
            // 
            // BirthLabel
            // 
            BirthLabel.AutoSize = true;
            BirthLabel.Location = new Point(22, 331);
            BirthLabel.Name = "BirthLabel";
            BirthLabel.Size = new Size(119, 20);
            BirthLabel.TabIndex = 12;
            BirthLabel.Text = "Дата рождения:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(22, 301);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(38, 20);
            TypeLabel.TabIndex = 11;
            TypeLabel.Text = "Тип:";
            // 
            // CharacteristicsLabel
            // 
            CharacteristicsLabel.AutoSize = true;
            CharacteristicsLabel.Location = new Point(22, 265);
            CharacteristicsLabel.Name = "CharacteristicsLabel";
            CharacteristicsLabel.Size = new Size(109, 20);
            CharacteristicsLabel.TabIndex = 10;
            CharacteristicsLabel.Text = "Особенности: ";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(22, 236);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(40, 20);
            GenderLabel.TabIndex = 9;
            GenderLabel.Text = "Пол:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(22, 195);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 20);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Кличка:";
            // 
            // HealthprogressBar
            // 
            HealthprogressBar.Location = new Point(135, 376);
            HealthprogressBar.Name = "HealthprogressBar";
            HealthprogressBar.Size = new Size(261, 20);
            HealthprogressBar.TabIndex = 14;
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(147, 331);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(250, 27);
            BirthDateTimePicker.TabIndex = 15;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BirthDateTimePicker);
            Controls.Add(HealthprogressBar);
            Controls.Add(HealthLabel);
            Controls.Add(BirthLabel);
            Controls.Add(TypeLabel);
            Controls.Add(CharacteristicsLabel);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Controls.Add(LoadButton);
            Controls.Add(AnimalPictureBox);
            Controls.Add(PetsTreeView);
            Name = "AboutForm";
            Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView PetsTreeView;
        private PictureBox AnimalPictureBox;
        private Button LoadButton;
        private Label HealthLabel;
        private Label BirthLabel;
        private Label TypeLabel;
        private Label CharacteristicsLabel;
        private Label GenderLabel;
        private Label NameLabel;
        private ProgressBar HealthprogressBar;
        private DateTimePicker BirthDateTimePicker;
    }
}