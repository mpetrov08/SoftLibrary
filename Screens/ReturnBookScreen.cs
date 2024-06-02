using SoftLibrary.Data;
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
    public partial class ReturnBookScreen : Form
    {
        public ReturnBookScreen()
        {
            InitializeComponent();
            errorLabel.Text = string.Empty;
            succesfullyLabel.Text = string.Empty;
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string rentCode = rentCodeTextBox.Text;

                    context.BookRents.First(br => br.RentCode == rentCode).IsBookReturned = true;
                    context.SaveChanges();

                    errorLabel.Text = string.Empty;
                    succesfullyLabel.Text = "Книгата е успешно върната!";
                }
                catch (Exception)
                {
                    succesfullyLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Неправилен код!!!";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
