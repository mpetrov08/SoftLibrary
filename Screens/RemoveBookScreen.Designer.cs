namespace SoftLibrary.Screens
{
    partial class RemoveBookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBookScreen));
            bookCodeLabel = new Label();
            bookCodeTextBox = new TextBox();
            deleteButton = new Button();
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
            bookCodeLabel.Location = new Point(23, 55);
            bookCodeLabel.Name = "bookCodeLabel";
            bookCodeLabel.Size = new Size(221, 37);
            bookCodeLabel.TabIndex = 0;
            bookCodeLabel.Text = "Код на книгата";
            // 
            // bookCodeTextBox
            // 
            bookCodeTextBox.Location = new Point(250, 70);
            bookCodeTextBox.Name = "bookCodeTextBox";
            bookCodeTextBox.Size = new Size(100, 23);
            bookCodeTextBox.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(34, 34, 34);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(23, 112);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(168, 37);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Изтрий";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(49, 25);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "error";
            // 
            // succesfullyLabel
            // 
            succesfullyLabel.AutoSize = true;
            succesfullyLabel.ForeColor = Color.Lime;
            succesfullyLabel.Location = new Point(87, 25);
            succesfullyLabel.Name = "succesfullyLabel";
            succesfullyLabel.Size = new Size(65, 15);
            succesfullyLabel.TabIndex = 4;
            succesfullyLabel.Text = "succesfully";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(211, 112);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(168, 37);
            closeButton.TabIndex = 5;
            closeButton.Text = "Затвори прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // RemoveBookScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(succesfullyLabel);
            Controls.Add(errorLabel);
            Controls.Add(deleteButton);
            Controls.Add(bookCodeTextBox);
            Controls.Add(bookCodeLabel);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RemoveBookScreen";
            Text = "RemoveBookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookCodeLabel;
        private TextBox bookCodeTextBox;
        private Button deleteButton;
        private Label errorLabel;
        private Label succesfullyLabel;
        private Button closeButton;
    }
}