using SoftLibrary.Data;
using SoftLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftLibrary.Screens
{
    public partial class AddUserScreen : Form
    {
        public AddUserScreen()
        {
            InitializeComponent();
            errorLabel.Text = string.Empty;
            succesfullyLabel.Text = string.Empty;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string code = codeTextBox.Text;
                    string firstName = nameTextBox.Text;
                    string sirName = sirNameTextBox.Text;
                    string lastName = lastNameTextBox.Text;
                    string address = addressTextBox.Text;
                    string phoneNumber = phoneNumberTextBox.Text;
                    int age = int.Parse(ageTextBox.Text);
                    string userClass = classTextBox.Text;

                    if (context.Users.Any(u => u.FirstName == firstName
                    && u.SirName == sirName
                    && u.LastName == lastName
                    || u.Code == code))
                    {
                        succesfullyLabel.Text = string.Empty;
                        errorLabel.Text = "!!!Потребителят вече съществува!!!";
                    }
                    else if (string.IsNullOrEmpty(firstName)
                        || string.IsNullOrEmpty(sirName)
                        || string.IsNullOrEmpty(lastName)
                        || string.IsNullOrEmpty(sirName)
                        || string.IsNullOrEmpty(code)
                        || string.IsNullOrEmpty(address)
                        || string.IsNullOrEmpty(phoneNumber))
                    {
                        succesfullyLabel.Text = string.Empty;
                        errorLabel.Text = "!!!Има празно поле!!!";
                    }
                    else
                    {
                        User user = new User
                        {
                            Code = code,
                            FirstName = firstName,
                            SirName = sirName,
                            LastName = lastName,
                            Address = address,
                            PhoneNumber = phoneNumber,
                            Age = age,
                            Class = userClass,
                        };

                        context.Users.Add(user);
                        context.SaveChanges();

                        errorLabel.Text = string.Empty;
                        succesfullyLabel.Text = "Успешно добавен потребител!";
                    }
                }
                catch (Exception)
                {
                    succesfullyLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Грешка!!!";
                }
            }

            nameTextBox.Text = string.Empty;
            sirNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
            classTextBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
