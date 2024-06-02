using SoftLibrary.Data;
using SoftLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftLibrary
{
    public partial class AddBookScreen : Form
    {
        public AddBookScreen()
        {
            InitializeComponent();
            errorLabel.Text = string.Empty;
            succesfullLabel.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addABookButton_Click(object sender, EventArgs e)
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string bookCode = bookCodeTextBox.Text;
                    string title = titleTextBox.Text;
                    string description = descriptionTextBox.Text;
                    string author = authorTextBox.Text;
                    int pages = int.Parse(pagesCountTextBox.Text);

                    if (context.Books.Any(b => b.BookCode == bookCode
                    || b.Title == title))
                    {
                        succesfullLabel.Text = string.Empty;
                        errorLabel.Text = "!!!Вече има книга със същото заглавие или код!!!";
                    }
                    else if (string.IsNullOrEmpty(bookCode)
                             || string.IsNullOrEmpty(title)
                             || string.IsNullOrEmpty(author))
                    {
                        succesfullLabel.Text = string.Empty;
                        errorLabel.Text = "!!!Има липсващи данни!!!";
                    }
                    else
                    {
                        Book book = new Book
                        {
                            BookCode = bookCode,
                            Title = title,
                            Description = description,
                            Author = author,
                            PagesCount = pages,
                        };

                        context.Books.Add(book);
                        context.SaveChanges();

                        errorLabel.Text = string.Empty;
                        succesfullLabel.Text = "Книгата е добавена успешно!";
                    }
                }
                catch (Exception)
                {
                    succesfullLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Грешка!!!";
                }
            }

            bookCodeTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            authorTextBox.Text = string.Empty;
            pagesCountTextBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
