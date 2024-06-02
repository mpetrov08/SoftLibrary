namespace SoftLibrary.Screens
{
    partial class ReturnBookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookScreen));
            rentCodeLabel = new Label();
            rentCodeTextBox = new TextBox();
            returnBookButton = new Button();
            closeButton = new Button();
            errorLabel = new Label();
            succesfullyLabel = new Label();
            SuspendLayout();
            // 
            // rentCodeLabel
            // 
            rentCodeLabel.AutoSize = true;
            rentCodeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rentCodeLabel.ForeColor = Color.White;
            rentCodeLabel.Location = new Point(12, 45);
            rentCodeLabel.Name = "rentCodeLabel";
            rentCodeLabel.Size = new Size(255, 37);
            rentCodeLabel.TabIndex = 0;
            rentCodeLabel.Text = "Код на поръчката";
            // 
            // rentCodeTextBox
            // 
            rentCodeTextBox.Location = new Point(273, 61);
            rentCodeTextBox.Name = "rentCodeTextBox";
            rentCodeTextBox.Size = new Size(100, 20);
            rentCodeTextBox.TabIndex = 1;
            // 
            // returnBookButton
            // 
            returnBookButton.BackColor = Color.FromArgb(34, 34, 34);
            returnBookButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            returnBookButton.ForeColor = Color.White;
            returnBookButton.Location = new Point(12, 96);
            returnBookButton.Name = "returnBookButton";
            returnBookButton.Size = new Size(179, 38);
            returnBookButton.TabIndex = 2;
            returnBookButton.Text = "Върни книгата";
            returnBookButton.UseVisualStyleBackColor = false;
            returnBookButton.Click += returnBookButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(197, 96);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(178, 38);
            closeButton.TabIndex = 3;
            closeButton.Text = "Затвори Прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(31, 19);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "error";
            // 
            // succesfullyLabel
            // 
            succesfullyLabel.AutoSize = true;
            succesfullyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            succesfullyLabel.ForeColor = Color.Lime;
            succesfullyLabel.Location = new Point(166, 19);
            succesfullyLabel.Name = "succesfullyLabel";
            succesfullyLabel.Size = new Size(65, 15);
            succesfullyLabel.TabIndex = 5;
            succesfullyLabel.Text = "succesfully";
            // 
            // ReturnBookScreen
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(916, 477);
            Controls.Add(succesfullyLabel);
            Controls.Add(errorLabel);
            Controls.Add(closeButton);
            Controls.Add(returnBookButton);
            Controls.Add(rentCodeTextBox);
            Controls.Add(rentCodeLabel);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReturnBookScreen";
            Text = "ReturnBookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rentCodeLabel;
        private TextBox rentCodeTextBox;
        private Button returnBookButton;
        private Button closeButton;
        private Label errorLabel;
        private Label succesfullyLabel;
    }
}