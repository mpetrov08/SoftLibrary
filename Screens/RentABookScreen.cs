using SoftLibrary.Data;
using SoftLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftLibrary.Screens
{
    public partial class RentABookScreen : Form
    {
        public RentABookScreen()
        {
            InitializeComponent();
            rentCodeLabel.Text = string.Empty;
            errorLabel.Text = string.Empty;
            succesfullyLabel.Text = string.Empty;
        }

        private void rentABookButton_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            rentCodeLabel.Text = string.Empty;

            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string bookCode = bookCodeTextBox.Text;
                    string userCode = userCodeTextBox.Text;
                    DateTime pickUpDate = Convert.ToDateTime(pickUpDateTextBox.Text);
                    DateTime returnDate = Convert.ToDateTime(returnDateTextBox.Text);

                    BookRent bookRent = new BookRent
                    {
                        RentCode = CodeGenerator(context.BookRents.Count() + 1),
                        BookId = context.Books.First(b => b.BookCode == bookCode).Id,
                        UserId = context.Users.First(u => u.Code == userCode).Id,
                        PickUpDate = pickUpDate,
                        ReturnDate = returnDate,
                        TotalDays = (returnDate - pickUpDate).Days
                    };

                    rentCodeLabel.Text = bookRent.RentCode;

                    context.BookRents.Add(bookRent);
                    context.SaveChanges();

                    errorLabel.Text = string.Empty;
                    succesfullyLabel.Text = "Книгата е успешно наета!";
                }
                catch (Exception)
                {
                    succesfullyLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Има грешни или невалидни данни!!!";
                }

                bookCodeTextBox.Text = string.Empty;
                userCodeTextBox.Text = string.Empty;
                pickUpDateTextBox.Text = string.Empty;
                returnDateTextBox.Text = string.Empty;
            }
        }

        private string CodeGenerator(int id)
        {
            Random rnd = new Random();
            char generatedLetter = (char)('A' + rnd.Next(26));

            int randomThreeDigitNumber = rnd.Next(100, 999);

            string lastLetters = string.Empty;
            for (int i = 0; i < 2; i++)
            {
                lastLetters += (char)('A' + rnd.Next(26));
            }

            return $"{generatedLetter}{id}{randomThreeDigitNumber}{lastLetters}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
