using SoftLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftLibrary.Screens
{
    public partial class RemoveUserScreen : Form
    {
        public RemoveUserScreen()
        {
            InitializeComponent();
            errorLabel.Text = string.Empty;
            succesfullyLabel.Text = string.Empty;
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string userCode = userCodeTextBox.Text;
                    context.Users
                           .Remove(context.Users
                                          .First(u => u.Code == userCode));
                    context.SaveChanges();

                    errorLabel.Text = string.Empty;
                    succesfullyLabel.Text = $"Успешно е изтрит потребител с код {userCode}";
                }
                catch (Exception)
                {
                    succesfullyLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Грешен или несъществуващ код на потребителя!!!";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
