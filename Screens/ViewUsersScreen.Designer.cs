namespace SoftLibrary.Screens
{
    partial class ViewUsersScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsersScreen));
            usersOutputListBox = new ListBox();
            SuspendLayout();
            // 
            // usersOutputListBox
            // 
            usersOutputListBox.BackColor = Color.FromArgb(34, 34, 34);
            usersOutputListBox.ForeColor = Color.White;
            usersOutputListBox.FormattingEnabled = true;
            usersOutputListBox.ItemHeight = 15;
            usersOutputListBox.Location = new Point(12, 12);
            usersOutputListBox.Name = "usersOutputListBox";
            usersOutputListBox.Size = new Size(1327, 574);
            usersOutputListBox.TabIndex = 0;
            // 
            // ViewUsersScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1351, 600);
            Controls.Add(usersOutputListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewUsersScreen";
            Text = "ViewUsersScreen";
            ResumeLayout(false);
        }

        #endregion

        private ListBox usersOutputListBox;
    }
}