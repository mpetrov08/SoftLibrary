namespace SoftLibrary.Screens
{
    partial class RemoveUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUserScreen));
            userCodeLabel = new Label();
            userCodeTextBox = new TextBox();
            removeUserButton = new Button();
            errorLabel = new Label();
            succesfullyLabel = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // userCodeLabel
            // 
            userCodeLabel.AutoSize = true;
            userCodeLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userCodeLabel.ForeColor = Color.White;
            userCodeLabel.Location = new Point(21, 38);
            userCodeLabel.Name = "userCodeLabel";
            userCodeLabel.Size = new Size(213, 37);
            userCodeLabel.TabIndex = 0;
            userCodeLabel.Text = "Код на ученика";
            // 
            // userCodeTextBox
            // 
            userCodeTextBox.Location = new Point(253, 52);
            userCodeTextBox.Name = "userCodeTextBox";
            userCodeTextBox.Size = new Size(100, 23);
            userCodeTextBox.TabIndex = 1;
            // 
            // removeUserButton
            // 
            removeUserButton.BackColor = Color.FromArgb(34, 34, 34);
            removeUserButton.ForeColor = Color.White;
            removeUserButton.Location = new Point(24, 97);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(156, 41);
            removeUserButton.TabIndex = 2;
            removeUserButton.Text = "Изтрий ученик";
            removeUserButton.UseVisualStyleBackColor = false;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(59, 23);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "error";
            // 
            // succesfullyLabel
            // 
            succesfullyLabel.AutoSize = true;
            succesfullyLabel.ForeColor = Color.Lime;
            succesfullyLabel.Location = new Point(115, 23);
            succesfullyLabel.Name = "succesfullyLabel";
            succesfullyLabel.Size = new Size(65, 15);
            succesfullyLabel.TabIndex = 4;
            succesfullyLabel.Text = "succesfully";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(219, 98);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(155, 40);
            closeButton.TabIndex = 5;
            closeButton.Text = "Затвори прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // RemoveUserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(succesfullyLabel);
            Controls.Add(errorLabel);
            Controls.Add(removeUserButton);
            Controls.Add(userCodeTextBox);
            Controls.Add(userCodeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RemoveUserScreen";
            Text = "RemoveUserScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userCodeLabel;
        private TextBox userCodeTextBox;
        private Button removeUserButton;
        private Label errorLabel;
        private Label succesfullyLabel;
        private Button closeButton;
    }
}