namespace SoftLibrary.Screens
{
    partial class ViewBookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookScreen));
            booksOutputListBox = new ListBox();
            SuspendLayout();
            // 
            // booksOutputListBox
            // 
            booksOutputListBox.BackColor = Color.FromArgb(34, 34, 34);
            booksOutputListBox.ForeColor = Color.White;
            booksOutputListBox.FormattingEnabled = true;
            booksOutputListBox.ItemHeight = 15;
            booksOutputListBox.Location = new Point(12, 12);
            booksOutputListBox.Name = "booksOutputListBox";
            booksOutputListBox.Size = new Size(1095, 439);
            booksOutputListBox.TabIndex = 0;
            // 
            // ViewBookScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1119, 462);
            Controls.Add(booksOutputListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewBookScreen";
            Text = "ViewBookScreen";
            ResumeLayout(false);
        }

        #endregion

        private ListBox booksOutputListBox;
    }
}