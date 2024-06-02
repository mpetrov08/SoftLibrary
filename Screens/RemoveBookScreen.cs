using Microsoft.EntityFrameworkCore;
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
    public partial class RemoveBookScreen : Form
    {
        public RemoveBookScreen()
        {
            InitializeComponent();
            errorLabel.Text = string.Empty;
            succesfullyLabel.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string bookCode = bookCodeTextBox.Text;
                    context.Books
                           .Remove(context.Books
                                          .First(b => bookCode == b.BookCode));
                    context.SaveChanges();

                    errorLabel.Text = string.Empty;
                    succesfullyLabel.Text = $"Успешно е изтрита книгата с код {bookCode}";
                }
                catch (Exception)
                {
                    succesfullyLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Грешен или несъществуващ код на книгата!!!";
                }

                bookCodeTextBox.Text = string.Empty;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
