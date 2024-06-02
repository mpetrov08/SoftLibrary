namespace SoftLibrary.Screens
{
    partial class RentABookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentABookScreen));
            bookCodeLabel = new Label();
            userCodeLabel = new Label();
            pickUpDateLabel = new Label();
            returnDateLabel = new Label();
            bookCodeTextBox = new TextBox();
            userCodeTextBox = new TextBox();
            pickUpDateTextBox = new TextBox();
            returnDateTextBox = new TextBox();
            rentABookButton = new Button();
            rentBookMessage = new Label();
            rentCodeLabel = new Label();
            label1 = new Label();
            errorLabel = new Label();
            succesfullyLabel = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // bookCodeLabel
            // 
            bookCodeLabel.AutoSize = true;
            bookCodeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookCodeLabel.ForeColor = Color.White;
            bookCodeLabel.Location = new Point(12, 36);
            bookCodeLabel.Name = "bookCodeLabel";
            bookCodeLabel.Size = new Size(221, 37);
            bookCodeLabel.TabIndex = 0;
            bookCodeLabel.Text = "Код на книгата";
            // 
            // userCodeLabel
            // 
            userCodeLabel.AutoSize = true;
            userCodeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userCodeLabel.ForeColor = Color.White;
            userCodeLabel.Location = new Point(12, 87);
            userCodeLabel.Name = "userCodeLabel";
            userCodeLabel.Size = new Size(292, 37);
            userCodeLabel.TabIndex = 1;
            userCodeLabel.Text = "Код на потребителя";
            // 
            // pickUpDateLabel
            // 
            pickUpDateLabel.AutoSize = true;
            pickUpDateLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pickUpDateLabel.ForeColor = Color.White;
            pickUpDateLabel.Location = new Point(12, 133);
            pickUpDateLabel.Name = "pickUpDateLabel";
            pickUpDateLabel.Size = new Size(401, 37);
            pickUpDateLabel.TabIndex = 2;
            pickUpDateLabel.Text = "Дата на взимане на книгата";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            returnDateLabel.ForeColor = Color.White;
            returnDateLabel.Location = new Point(12, 183);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new Size(604, 37);
            returnDateLabel.TabIndex = 3;
            returnDateLabel.Text = "Дата, на която трябва да се върна книгата";
            // 
            // bookCodeTextBox
            // 
            bookCodeTextBox.Location = new Point(239, 50);
            bookCodeTextBox.Name = "bookCodeTextBox";
            bookCodeTextBox.Size = new Size(100, 23);
            bookCodeTextBox.TabIndex = 4;
            // 
            // userCodeTextBox
            // 
            userCodeTextBox.Location = new Point(310, 101);
            userCodeTextBox.Name = "userCodeTextBox";
            userCodeTextBox.Size = new Size(100, 23);
            userCodeTextBox.TabIndex = 5;
            // 
            // pickUpDateTextBox
            // 
            pickUpDateTextBox.Location = new Point(419, 147);
            pickUpDateTextBox.Name = "pickUpDateTextBox";
            pickUpDateTextBox.Size = new Size(100, 23);
            pickUpDateTextBox.TabIndex = 6;
            // 
            // returnDateTextBox
            // 
            returnDateTextBox.Location = new Point(622, 197);
            returnDateTextBox.Name = "returnDateTextBox";
            returnDateTextBox.Size = new Size(100, 23);
            returnDateTextBox.TabIndex = 7;
            // 
            // rentABookButton
            // 
            rentABookButton.BackColor = Color.FromArgb(34, 34, 34);
            rentABookButton.ForeColor = Color.White;
            rentABookButton.Location = new Point(164, 240);
            rentABookButton.Name = "rentABookButton";
            rentABookButton.Size = new Size(172, 41);
            rentABookButton.TabIndex = 8;
            rentABookButton.Text = "Вземи Книгата";
            rentABookButton.UseVisualStyleBackColor = false;
            rentABookButton.Click += rentABookButton_Click;
            // 
            // rentBookMessage
            // 
            rentBookMessage.AutoSize = true;
            rentBookMessage.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rentBookMessage.ForeColor = Color.White;
            rentBookMessage.Location = new Point(12, 301);
            rentBookMessage.Name = "rentBookMessage";
            rentBookMessage.Size = new Size(324, 37);
            rentBookMessage.TabIndex = 9;
            rentBookMessage.Text = "Кодът на поръчката е:";
            // 
            // rentCodeLabel
            // 
            rentCodeLabel.AutoSize = true;
            rentCodeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rentCodeLabel.ForeColor = Color.White;
            rentCodeLabel.Location = new Point(342, 301);
            rentCodeLabel.Name = "rentCodeLabel";
            rentCodeLabel.Size = new Size(92, 37);
            rentCodeLabel.TabIndex = 10;
            rentCodeLabel.Text = "label6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(198, 363);
            label1.Name = "label1";
            label1.Size = new Size(418, 15);
            label1.TabIndex = 11;
            label1.Text = "*Датите трябва да бъдата въведени в следния формат: \"месец/ден/година\"";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(86, 413);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 12;
            errorLabel.Text = "error";
            // 
            // succesfullyLabel
            // 
            succesfullyLabel.AutoSize = true;
            succesfullyLabel.ForeColor = Color.Lime;
            succesfullyLabel.Location = new Point(512, 413);
            succesfullyLabel.Name = "succesfullyLabel";
            succesfullyLabel.Size = new Size(65, 15);
            succesfullyLabel.TabIndex = 13;
            succesfullyLabel.Text = "succesfully";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(380, 240);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(172, 41);
            closeButton.TabIndex = 14;
            closeButton.Text = "Затвори Прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // RentABookScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(817, 484);
            Controls.Add(closeButton);
            Controls.Add(succesfullyLabel);
            Controls.Add(errorLabel);
            Controls.Add(label1);
            Controls.Add(rentCodeLabel);
            Controls.Add(rentBookMessage);
            Controls.Add(rentABookButton);
            Controls.Add(returnDateTextBox);
            Controls.Add(pickUpDateTextBox);
            Controls.Add(userCodeTextBox);
            Controls.Add(bookCodeTextBox);
            Controls.Add(returnDateLabel);
            Controls.Add(pickUpDateLabel);
            Controls.Add(userCodeLabel);
            Controls.Add(bookCodeLabel);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentABookScreen";
            Text = "RentABookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookCodeLabel;
        private Label userCodeLabel;
        private Label pickUpDateLabel;
        private Label returnDateLabel;
        private TextBox bookCodeTextBox;
        private TextBox userCodeTextBox;
        private TextBox pickUpDateTextBox;
        private TextBox returnDateTextBox;
        private Button rentABookButton;
        private Label rentBookMessage;
        private Label rentCodeLabel;
        private Label label1;
        private Label errorLabel;
        private Label succesfullyLabel;
        private Button closeButton;
    }
}