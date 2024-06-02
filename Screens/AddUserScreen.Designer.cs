namespace SoftLibrary.Screens
{
    partial class AddUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserScreen));
            nameLabel = new Label();
            sirNameLabel = new Label();
            lastNameLabel = new Label();
            phoneNumberLabel = new Label();
            addressLabel = new Label();
            ageLabel = new Label();
            classLabel = new Label();
            nameTextBox = new TextBox();
            sirNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            addressTextBox = new TextBox();
            ageTextBox = new TextBox();
            classTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            addUserButton = new Button();
            errorLabel = new Label();
            succesfullyLabel = new Label();
            codeLabel = new Label();
            codeTextBox = new TextBox();
            closeButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(26, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Име";
            // 
            // sirNameLabel
            // 
            sirNameLabel.AutoSize = true;
            sirNameLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            sirNameLabel.ForeColor = Color.White;
            sirNameLabel.Location = new Point(26, 132);
            sirNameLabel.Name = "sirNameLabel";
            sirNameLabel.Size = new Size(129, 37);
            sirNameLabel.TabIndex = 1;
            sirNameLabel.Text = "Презиме";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.White;
            lastNameLabel.Location = new Point(26, 183);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(136, 37);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Фамилия";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(393, 34);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(128, 37);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Телефон";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addressLabel.ForeColor = Color.White;
            addressLabel.Location = new Point(393, 179);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(91, 37);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Адрес";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ageLabel.ForeColor = Color.White;
            ageLabel.Location = new Point(393, 131);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(129, 37);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Възраст";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            classLabel.ForeColor = Color.White;
            classLabel.Location = new Point(393, 84);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(355, 37);
            classLabel.TabIndex = 6;
            classLabel.Text = "Клас (не е задължително)";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(168, 99);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 7;
            // 
            // sirNameTextBox
            // 
            sirNameTextBox.Location = new Point(168, 146);
            sirNameTextBox.Name = "sirNameTextBox";
            sirNameTextBox.Size = new Size(100, 23);
            sirNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(168, 194);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(490, 193);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(381, 23);
            addressTextBox.TabIndex = 10;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(528, 145);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(100, 23);
            ageTextBox.TabIndex = 11;
            // 
            // classTextBox
            // 
            classTextBox.Location = new Point(771, 98);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(100, 23);
            classTextBox.TabIndex = 12;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(551, 48);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 13;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(34, 34, 34);
            addUserButton.ForeColor = Color.White;
            addUserButton.Location = new Point(268, 259);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(169, 43);
            addUserButton.TabIndex = 14;
            addUserButton.Text = "Добави потребител";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(31, 273);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 15;
            errorLabel.Text = "error";
            // 
            // succesfullyLabel
            // 
            succesfullyLabel.AutoSize = true;
            succesfullyLabel.ForeColor = Color.Lime;
            succesfullyLabel.Location = new Point(516, 273);
            succesfullyLabel.Name = "succesfullyLabel";
            succesfullyLabel.Size = new Size(65, 15);
            succesfullyLabel.TabIndex = 16;
            succesfullyLabel.Text = "succesfully";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            codeLabel.ForeColor = Color.White;
            codeLabel.Location = new Point(31, 34);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(64, 37);
            codeLabel.TabIndex = 17;
            codeLabel.Text = "Код";
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(168, 48);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(100, 23);
            codeTextBox.TabIndex = 18;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(268, 322);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(166, 41);
            closeButton.TabIndex = 19;
            closeButton.Text = "Затвори прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // AddUserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(883, 450);
            Controls.Add(closeButton);
            Controls.Add(codeTextBox);
            Controls.Add(codeLabel);
            Controls.Add(succesfullyLabel);
            Controls.Add(errorLabel);
            Controls.Add(addUserButton);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(classTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(sirNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(classLabel);
            Controls.Add(ageLabel);
            Controls.Add(addressLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(sirNameLabel);
            Controls.Add(nameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUserScreen";
            Text = "AddUserScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label sirNameLabel;
        private Label lastNameLabel;
        private Label phoneNumberLabel;
        private Label addressLabel;
        private Label ageLabel;
        private Label classLabel;
        private TextBox nameTextBox;
        private TextBox sirNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox addressTextBox;
        private TextBox ageTextBox;
        private TextBox classTextBox;
        private TextBox phoneNumberTextBox;
        private Button addUserButton;
        private Label errorLabel;
        private Label succesfullyLabel;
        private Label codeLabel;
        private TextBox codeTextBox;
        private Button closeButton;
    }
}