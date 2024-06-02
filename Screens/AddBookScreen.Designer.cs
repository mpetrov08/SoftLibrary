namespace SoftLibrary
{
    partial class AddBookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookScreen));
            BookCodeLabel = new Label();
            titleLabel = new Label();
            descriptionLabel = new Label();
            authorLabel = new Label();
            pagesCountLabel = new Label();
            descriptionTextBox = new TextBox();
            titleTextBox = new TextBox();
            bookCodeTextBox = new TextBox();
            authorTextBox = new TextBox();
            pagesCountTextBox = new TextBox();
            addABookButton = new Button();
            errorLabel = new Label();
            succesfullLabel = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // BookCodeLabel
            // 
            BookCodeLabel.AutoSize = true;
            BookCodeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BookCodeLabel.ForeColor = Color.White;
            BookCodeLabel.Location = new Point(25, 29);
            BookCodeLabel.Name = "BookCodeLabel";
            BookCodeLabel.Size = new Size(64, 37);
            BookCodeLabel.TabIndex = 2;
            BookCodeLabel.Text = "Код";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.Control;
            titleLabel.Location = new Point(25, 88);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(133, 37);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Заглавие";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Location = new Point(25, 143);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(394, 37);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Резюме (не е задължително)";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            authorLabel.ForeColor = Color.White;
            authorLabel.Location = new Point(579, 29);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(103, 37);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Автор";
            // 
            // pagesCountLabel
            // 
            pagesCountLabel.AutoSize = true;
            pagesCountLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pagesCountLabel.ForeColor = Color.White;
            pagesCountLabel.Location = new Point(579, 88);
            pagesCountLabel.Name = "pagesCountLabel";
            pagesCountLabel.Size = new Size(216, 37);
            pagesCountLabel.TabIndex = 6;
            pagesCountLabel.Text = "Брой страници";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(425, 157);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(164, 102);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 8;
            // 
            // bookCodeTextBox
            // 
            bookCodeTextBox.Location = new Point(95, 43);
            bookCodeTextBox.Name = "bookCodeTextBox";
            bookCodeTextBox.Size = new Size(100, 23);
            bookCodeTextBox.TabIndex = 9;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(695, 43);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(100, 23);
            authorTextBox.TabIndex = 10;
            // 
            // pagesCountTextBox
            // 
            pagesCountTextBox.Location = new Point(801, 102);
            pagesCountTextBox.Name = "pagesCountTextBox";
            pagesCountTextBox.Size = new Size(100, 23);
            pagesCountTextBox.TabIndex = 11;
            // 
            // addABookButton
            // 
            addABookButton.BackColor = Color.FromArgb(34, 34, 34);
            addABookButton.ForeColor = Color.White;
            addABookButton.Location = new Point(579, 143);
            addABookButton.Name = "addABookButton";
            addABookButton.Size = new Size(309, 57);
            addABookButton.TabIndex = 12;
            addABookButton.Text = "Добави Книга";
            addABookButton.UseVisualStyleBackColor = false;
            addABookButton.Click += addABookButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(318, 64);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 13;
            errorLabel.Text = "error";
            // 
            // succesfullLabel
            // 
            succesfullLabel.AutoSize = true;
            succesfullLabel.ForeColor = Color.Lime;
            succesfullLabel.Location = new Point(318, 88);
            succesfullLabel.Name = "succesfullLabel";
            succesfullLabel.Size = new Size(65, 15);
            succesfullLabel.TabIndex = 14;
            succesfullLabel.Text = "succesfully";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(373, 233);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(309, 57);
            closeButton.TabIndex = 15;
            closeButton.Text = "Затвори прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // AddBookScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1045, 450);
            Controls.Add(closeButton);
            Controls.Add(succesfullLabel);
            Controls.Add(errorLabel);
            Controls.Add(addABookButton);
            Controls.Add(pagesCountTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(bookCodeTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(pagesCountLabel);
            Controls.Add(authorLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(BookCodeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBookScreen";
            Text = "AddBookScreen";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label BookCodeLabel;
        private Label titleLabel;
        private Label descriptionLabel;
        private Label authorLabel;
        private Label pagesCountLabel;
        private TextBox descriptionTextBox;
        private TextBox titleTextBox;
        private TextBox bookCodeTextBox;
        private TextBox authorTextBox;
        private TextBox pagesCountTextBox;
        private Button addABookButton;
        private Label errorLabel;
        private Label succesfullLabel;
        private Button closeButton;
    }
}