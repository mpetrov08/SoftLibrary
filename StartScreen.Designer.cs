namespace SoftLibrary
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            appName = new Label();
            viewBooksButton = new Button();
            addBookButton = new Button();
            howToUseButton = new Button();
            rentABookButton = new Button();
            pictureBox1 = new PictureBox();
            removeBookButton = new Button();
            addUserButton = new Button();
            removeUserButton = new Button();
            closeButton = new Button();
            returnBookButton = new Button();
            viewRentedBookButton = new Button();
            viewUsersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            appName.ForeColor = Color.White;
            appName.Location = new Point(669, 384);
            appName.Name = "appName";
            appName.Size = new Size(253, 37);
            appName.TabIndex = 0;
            appName.Text = "СофтБиблиотека";
            // 
            // viewBooksButton
            // 
            viewBooksButton.BackColor = Color.FromArgb(34, 34, 34);
            viewBooksButton.ForeColor = Color.White;
            viewBooksButton.Location = new Point(799, 603);
            viewBooksButton.Name = "viewBooksButton";
            viewBooksButton.Size = new Size(244, 50);
            viewBooksButton.TabIndex = 1;
            viewBooksButton.Text = "Разгледай Книгите";
            viewBooksButton.UseVisualStyleBackColor = false;
            viewBooksButton.Click += viewBooksButton_Click;
            // 
            // addBookButton
            // 
            addBookButton.BackColor = Color.FromArgb(34, 34, 34);
            addBookButton.ForeColor = Color.White;
            addBookButton.Location = new Point(524, 437);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(244, 50);
            addBookButton.TabIndex = 2;
            addBookButton.Text = "Добави книга";
            addBookButton.UseVisualStyleBackColor = false;
            addBookButton.Click += addBookButton_Click;
            // 
            // howToUseButton
            // 
            howToUseButton.BackColor = Color.FromArgb(34, 34, 34);
            howToUseButton.ForeColor = Color.White;
            howToUseButton.Location = new Point(799, 661);
            howToUseButton.Name = "howToUseButton";
            howToUseButton.Size = new Size(244, 50);
            howToUseButton.TabIndex = 3;
            howToUseButton.Text = "Как да използвам приложението";
            howToUseButton.UseVisualStyleBackColor = false;
            howToUseButton.Click += howToUseButton_Click;
            // 
            // rentABookButton
            // 
            rentABookButton.BackColor = Color.FromArgb(34, 34, 34);
            rentABookButton.ForeColor = Color.White;
            rentABookButton.Location = new Point(524, 547);
            rentABookButton.Name = "rentABookButton";
            rentABookButton.Size = new Size(244, 50);
            rentABookButton.TabIndex = 4;
            rentABookButton.Text = "Наемане на Книга";
            rentABookButton.UseVisualStyleBackColor = false;
            rentABookButton.Click += rentABookButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(480, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 359);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // removeBookButton
            // 
            removeBookButton.BackColor = Color.FromArgb(34, 34, 34);
            removeBookButton.ForeColor = Color.White;
            removeBookButton.Location = new Point(799, 437);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(244, 50);
            removeBookButton.TabIndex = 6;
            removeBookButton.Text = "Премахни книга";
            removeBookButton.UseVisualStyleBackColor = false;
            removeBookButton.Click += removeBookButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(34, 34, 34);
            addUserButton.ForeColor = Color.White;
            addUserButton.Location = new Point(526, 493);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(242, 48);
            addUserButton.TabIndex = 7;
            addUserButton.Text = "Добави Потребител";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // removeUserButton
            // 
            removeUserButton.BackColor = Color.FromArgb(34, 34, 34);
            removeUserButton.ForeColor = Color.White;
            removeUserButton.Location = new Point(799, 493);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(244, 48);
            removeUserButton.TabIndex = 8;
            removeUserButton.Text = "Премахни Потребител";
            removeUserButton.UseVisualStyleBackColor = false;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(524, 729);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(519, 51);
            closeButton.TabIndex = 9;
            closeButton.Text = "Затвори Приложението";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // returnBookButton
            // 
            returnBookButton.BackColor = Color.FromArgb(34, 34, 34);
            returnBookButton.ForeColor = Color.White;
            returnBookButton.Location = new Point(799, 547);
            returnBookButton.Name = "returnBookButton";
            returnBookButton.Size = new Size(242, 50);
            returnBookButton.TabIndex = 10;
            returnBookButton.Text = "Връщане на книга";
            returnBookButton.UseVisualStyleBackColor = false;
            returnBookButton.Click += returnBookButton_Click;
            // 
            // viewRentedBookButton
            // 
            viewRentedBookButton.BackColor = Color.FromArgb(34, 34, 34);
            viewRentedBookButton.ForeColor = Color.White;
            viewRentedBookButton.Location = new Point(524, 603);
            viewRentedBookButton.Name = "viewRentedBookButton";
            viewRentedBookButton.Size = new Size(244, 50);
            viewRentedBookButton.TabIndex = 11;
            viewRentedBookButton.Text = "Прегледай наета книга";
            viewRentedBookButton.UseVisualStyleBackColor = false;
            viewRentedBookButton.Click += viewRentedBookButton_Click;
            // 
            // viewUsersButton
            // 
            viewUsersButton.BackColor = Color.FromArgb(34, 34, 34);
            viewUsersButton.ForeColor = Color.White;
            viewUsersButton.Location = new Point(524, 659);
            viewUsersButton.Name = "viewUsersButton";
            viewUsersButton.Size = new Size(242, 50);
            viewUsersButton.TabIndex = 12;
            viewUsersButton.Text = "Прегледай потребители";
            viewUsersButton.UseVisualStyleBackColor = false;
            viewUsersButton.Click += viewUsersButton_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1531, 792);
            Controls.Add(viewUsersButton);
            Controls.Add(viewRentedBookButton);
            Controls.Add(returnBookButton);
            Controls.Add(closeButton);
            Controls.Add(removeUserButton);
            Controls.Add(addUserButton);
            Controls.Add(removeBookButton);
            Controls.Add(pictureBox1);
            Controls.Add(rentABookButton);
            Controls.Add(howToUseButton);
            Controls.Add(addBookButton);
            Controls.Add(viewBooksButton);
            Controls.Add(appName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartScreen";
            Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appName;
        private Button viewBooksButton;
        private Button addBookButton;
        private Button howToUseButton;
        private Button rentABookButton;
        private PictureBox pictureBox1;
        private Button removeBookButton;
        private Button addUserButton;
        private Button removeUserButton;
        private Button closeButton;
        private Button returnBookButton;
        private Button viewRentedBookButton;
        private Button viewUsersButton;
    }
}