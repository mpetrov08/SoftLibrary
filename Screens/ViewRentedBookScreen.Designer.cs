namespace SoftLibrary.Screens
{
    partial class ViewRentedBookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRentedBookScreen));
            messageLabel = new Label();
            rentCodeTextBox = new TextBox();
            checkTheRentButton = new Button();
            closeButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            bookCodeLabel = new Label();
            bookNameLabel = new Label();
            bookAuthorLabel = new Label();
            bookPagesCountLabel = new Label();
            userCodeLabel = new Label();
            userNameLabel = new Label();
            userPhoneNumberLabel = new Label();
            pickUpDateLabel = new Label();
            returnDateLabel = new Label();
            daysCountLabel = new Label();
            isReturnedLabel = new Label();
            label1 = new Label();
            userAddressLabel = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            messageLabel.ForeColor = Color.White;
            messageLabel.Location = new Point(21, 35);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(193, 37);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Код на Наема";
            // 
            // rentCodeTextBox
            // 
            rentCodeTextBox.Location = new Point(229, 49);
            rentCodeTextBox.Name = "rentCodeTextBox";
            rentCodeTextBox.Size = new Size(100, 23);
            rentCodeTextBox.TabIndex = 1;
            // 
            // checkTheRentButton
            // 
            checkTheRentButton.BackColor = Color.FromArgb(34, 34, 34);
            checkTheRentButton.ForeColor = Color.White;
            checkTheRentButton.Location = new Point(21, 92);
            checkTheRentButton.Name = "checkTheRentButton";
            checkTheRentButton.Size = new Size(149, 40);
            checkTheRentButton.TabIndex = 2;
            checkTheRentButton.Text = "Провери";
            checkTheRentButton.UseVisualStyleBackColor = false;
            checkTheRentButton.Click += checkTheRentButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(34, 34, 34);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(180, 92);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(149, 40);
            closeButton.TabIndex = 3;
            closeButton.Text = "Затвори Прозореца";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 176);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 4;
            label2.Text = "Код на книгата:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 204);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 5;
            label3.Text = "Име на книгата:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 232);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 6;
            label4.Text = "Автор:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 258);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 7;
            label5.Text = "Брой страници:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 286);
            label6.Name = "label6";
            label6.Size = new Size(220, 28);
            label6.TabIndex = 8;
            label6.Text = "Код на потребителя:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 314);
            label7.Name = "label7";
            label7.Size = new Size(225, 28);
            label7.TabIndex = 9;
            label7.Text = "Име на потребителя:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 340);
            label8.Name = "label8";
            label8.Size = new Size(266, 28);
            label8.TabIndex = 10;
            label8.Text = "Телефон на потребителя:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(526, 176);
            label9.Name = "label9";
            label9.Size = new Size(338, 28);
            label9.TabIndex = 11;
            label9.Text = "Дата, на която е взета книгата:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(526, 232);
            label10.Name = "label10";
            label10.Size = new Size(362, 28);
            label10.TabIndex = 12;
            label10.Text = "Дата, на която трябва да се върне:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(526, 286);
            label11.Name = "label11";
            label11.Size = new Size(320, 28);
            label11.TabIndex = 13;
            label11.Text = "Дни, за които книгата е взета:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(526, 340);
            label12.Name = "label12";
            label12.Size = new Size(236, 28);
            label12.TabIndex = 14;
            label12.Text = "Върната ли е книгата:";
            // 
            // bookCodeLabel
            // 
            bookCodeLabel.AutoSize = true;
            bookCodeLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookCodeLabel.ForeColor = Color.White;
            bookCodeLabel.Location = new Point(191, 177);
            bookCodeLabel.Name = "bookCodeLabel";
            bookCodeLabel.Size = new Size(72, 28);
            bookCodeLabel.TabIndex = 15;
            bookCodeLabel.Text = "output";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookNameLabel.ForeColor = Color.White;
            bookNameLabel.Location = new Point(190, 205);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(72, 28);
            bookNameLabel.TabIndex = 16;
            bookNameLabel.Text = "output";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookAuthorLabel.ForeColor = Color.White;
            bookAuthorLabel.Location = new Point(96, 232);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(72, 28);
            bookAuthorLabel.TabIndex = 17;
            bookAuthorLabel.Text = "output";
            // 
            // bookPagesCountLabel
            // 
            bookPagesCountLabel.AutoSize = true;
            bookPagesCountLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookPagesCountLabel.ForeColor = Color.White;
            bookPagesCountLabel.Location = new Point(180, 258);
            bookPagesCountLabel.Name = "bookPagesCountLabel";
            bookPagesCountLabel.Size = new Size(72, 28);
            bookPagesCountLabel.TabIndex = 18;
            bookPagesCountLabel.Text = "output";
            // 
            // userCodeLabel
            // 
            userCodeLabel.AutoSize = true;
            userCodeLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userCodeLabel.ForeColor = Color.White;
            userCodeLabel.Location = new Point(243, 286);
            userCodeLabel.Name = "userCodeLabel";
            userCodeLabel.Size = new Size(72, 28);
            userCodeLabel.TabIndex = 19;
            userCodeLabel.Text = "output";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(242, 314);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(72, 28);
            userNameLabel.TabIndex = 20;
            userNameLabel.Text = "output";
            // 
            // userPhoneNumberLabel
            // 
            userPhoneNumberLabel.AutoSize = true;
            userPhoneNumberLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userPhoneNumberLabel.ForeColor = Color.White;
            userPhoneNumberLabel.Location = new Point(289, 342);
            userPhoneNumberLabel.Name = "userPhoneNumberLabel";
            userPhoneNumberLabel.Size = new Size(72, 28);
            userPhoneNumberLabel.TabIndex = 21;
            userPhoneNumberLabel.Text = "output";
            // 
            // pickUpDateLabel
            // 
            pickUpDateLabel.AutoSize = true;
            pickUpDateLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pickUpDateLabel.ForeColor = Color.White;
            pickUpDateLabel.Location = new Point(870, 176);
            pickUpDateLabel.Name = "pickUpDateLabel";
            pickUpDateLabel.Size = new Size(72, 28);
            pickUpDateLabel.TabIndex = 22;
            pickUpDateLabel.Text = "output";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            returnDateLabel.ForeColor = Color.White;
            returnDateLabel.Location = new Point(883, 232);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new Size(72, 28);
            returnDateLabel.TabIndex = 23;
            returnDateLabel.Text = "output";
            // 
            // daysCountLabel
            // 
            daysCountLabel.AutoSize = true;
            daysCountLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            daysCountLabel.ForeColor = Color.White;
            daysCountLabel.Location = new Point(852, 286);
            daysCountLabel.Name = "daysCountLabel";
            daysCountLabel.Size = new Size(72, 28);
            daysCountLabel.TabIndex = 24;
            daysCountLabel.Text = "output";
            // 
            // isReturnedLabel
            // 
            isReturnedLabel.AutoSize = true;
            isReturnedLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            isReturnedLabel.ForeColor = Color.White;
            isReturnedLabel.Location = new Point(770, 340);
            isReturnedLabel.Name = "isReturnedLabel";
            isReturnedLabel.Size = new Size(72, 28);
            isReturnedLabel.TabIndex = 25;
            isReturnedLabel.Text = "output";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 368);
            label1.Name = "label1";
            label1.Size = new Size(239, 28);
            label1.TabIndex = 26;
            label1.Text = "Адрес на потребителя:";
            // 
            // userAddressLabel
            // 
            userAddressLabel.AutoSize = true;
            userAddressLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userAddressLabel.ForeColor = Color.White;
            userAddressLabel.Location = new Point(266, 370);
            userAddressLabel.Name = "userAddressLabel";
            userAddressLabel.Size = new Size(72, 28);
            userAddressLabel.TabIndex = 27;
            userAddressLabel.Text = "output";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.FromArgb(34, 34, 34);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(486, 117);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 28;
            errorLabel.Text = "error";
            // 
            // ViewRentedBookScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1012, 450);
            Controls.Add(errorLabel);
            Controls.Add(userAddressLabel);
            Controls.Add(label1);
            Controls.Add(isReturnedLabel);
            Controls.Add(daysCountLabel);
            Controls.Add(returnDateLabel);
            Controls.Add(pickUpDateLabel);
            Controls.Add(userPhoneNumberLabel);
            Controls.Add(userNameLabel);
            Controls.Add(userCodeLabel);
            Controls.Add(bookPagesCountLabel);
            Controls.Add(bookAuthorLabel);
            Controls.Add(bookNameLabel);
            Controls.Add(bookCodeLabel);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(closeButton);
            Controls.Add(checkTheRentButton);
            Controls.Add(rentCodeTextBox);
            Controls.Add(messageLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewRentedBookScreen";
            Text = "ViewRentedBookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageLabel;
        private TextBox rentCodeTextBox;
        private Button checkTheRentButton;
        private Button closeButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label bookCodeLabel;
        private Label bookNameLabel;
        private Label bookAuthorLabel;
        private Label bookPagesCountLabel;
        private Label userCodeLabel;
        private Label userNameLabel;
        private Label userPhoneNumberLabel;
        private Label pickUpDateLabel;
        private Label returnDateLabel;
        private Label daysCountLabel;
        private Label isReturnedLabel;
        private Label label1;
        private Label userAddressLabel;
        private Label errorLabel;
    }
}