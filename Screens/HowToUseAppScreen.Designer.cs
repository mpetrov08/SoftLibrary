namespace SoftLibrary.Screens
{
    partial class HowToUseAppScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToUseAppScreen));
            howToUseAppGuide = new RichTextBox();
            label1 = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // howToUseAppGuide
            // 
            howToUseAppGuide.BackColor = Color.FromArgb(34, 34, 34);
            howToUseAppGuide.ForeColor = Color.White;
            howToUseAppGuide.Location = new Point(12, 79);
            howToUseAppGuide.Name = "howToUseAppGuide";
            howToUseAppGuide.Size = new Size(990, 518);
            howToUseAppGuide.TabIndex = 0;
            howToUseAppGuide.Text = resources.GetString("howToUseAppGuide.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(224, 21);
            label1.Name = "label1";
            label1.Size = new Size(543, 37);
            label1.TabIndex = 1;
            label1.Text = "Как да използвате \"СофтБиблиотека\"?";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(426, 620);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(160, 43);
            closeButton.TabIndex = 2;
            closeButton.Text = "Затвори прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // HowToUseAppScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1014, 675);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(howToUseAppGuide);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HowToUseAppScreen";
            Text = "HowToUseAppScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox howToUseAppGuide;
        private Label label1;
        private Button closeButton;
    }
}