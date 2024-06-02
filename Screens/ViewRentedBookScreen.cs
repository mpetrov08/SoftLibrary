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
    public partial class ViewRentedBookScreen : Form
    {
        public ViewRentedBookScreen()
        {
            InitializeComponent();
            bookCodeLabel.Text = string.Empty;
            bookNameLabel.Text = string.Empty;
            bookAuthorLabel.Text = string.Empty;
            bookPagesCountLabel.Text = string.Empty;
            userCodeLabel.Text = string.Empty;
            userNameLabel.Text = string.Empty;
            userPhoneNumberLabel.Text = string.Empty;
            userAddressLabel.Text = string.Empty;
            pickUpDateLabel.Text = string.Empty;
            returnDateLabel.Text = string.Empty;
            daysCountLabel.Text = string.Empty;
            isReturnedLabel.Text = string.Empty;
            errorLabel.Text = string.Empty;
        }

        private void checkTheRentButton_Click(object sender, EventArgs e)
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();

                try
                {
                    string rentCode = rentCodeTextBox.Text;
                    BookRent bookRent = context.BookRents
                                               .Include(e => e.Book)
                                               .Include(e => e.User)
                                               .First(br => br.RentCode == rentCode);

                    string bookCode = bookRent.Book.BookCode;
                    string bookName = bookRent.Book.Title;
                    string author = bookRent.Book.Author;
                    int pagesCount = bookRent.Book.PagesCount;
                    string userCode = bookRent.User.Code;
                    string userName = $"{bookRent.User.FirstName} {bookRent.User.SirName} {bookRent.User.LastName}";
                    string userPhoneNumber = bookRent.User.PhoneNumber;
                    string userAddress = bookRent.User.Address;
                    DateTime pickUpDate = bookRent.PickUpDate;
                    DateTime returnDate = bookRent.ReturnDate;
                    int totalDays = bookRent.TotalDays;

                    string IsReturned = string.Empty;
                    if (bookRent.IsBookReturned)
                    {
                        IsReturned = "Да";
                    }
                    else
                    {
                        IsReturned = "Не";
                    }

                    errorLabel.Text = string.Empty;
                    bookCodeLabel.Text = bookCode;
                    bookNameLabel.Text = bookName;
                    bookAuthorLabel.Text = author;
                    bookPagesCountLabel.Text = pagesCount.ToString();
                    userCodeLabel.Text = userCode;
                    userNameLabel.Text = userName;
                    userPhoneNumberLabel.Text = userPhoneNumber;
                    userAddressLabel.Text = userAddress;
                    pickUpDateLabel.Text = pickUpDate.ToString("dd//MM//yyyy");
                    returnDateLabel.Text = returnDate.ToString("dd//MM//yyyy");
                    daysCountLabel.Text = totalDays.ToString();
                    isReturnedLabel.Text = IsReturned;
                }
                catch (Exception)
                {
                    bookCodeLabel.Text = string.Empty;
                    bookNameLabel.Text = string.Empty;
                    bookAuthorLabel.Text = string.Empty;
                    bookPagesCountLabel.Text = string.Empty;
                    userCodeLabel.Text = string.Empty;
                    userNameLabel.Text = string.Empty;
                    userPhoneNumberLabel.Text = string.Empty;
                    userAddressLabel.Text = string.Empty;
                    pickUpDateLabel.Text = string.Empty;
                    returnDateLabel.Text = string.Empty;
                    returnDateLabel.Text = string.Empty;
                    daysCountLabel.Text = string.Empty;
                    errorLabel.Text = "!!!Грешка!!!";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
