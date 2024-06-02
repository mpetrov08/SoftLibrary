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
    public partial class ViewBookScreen : Form
    {
        public ViewBookScreen()
        {
            InitializeComponent();
            FillListBox();
        }

        public void FillListBox()
        {
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                try
                {
                    context.Database.EnsureCreated();

                    int iterationsNumber = context.Books.Count() + context.Books.First().Id;
                    for (int i = context.Books.First().Id; i < iterationsNumber; i++)
                    {
                        Book book = context.Books.Include(b => b.BookRents).ThenInclude(br => br.User).Where(b => b.Id == i).First();
                        string info = $"Заглавие: {book.Title}, Автор: {book.Author}, Код: {book.BookCode}" +
                            $", Резюме: {(string.IsNullOrEmpty(book.Description) ? "няма описание" : book.Description)}" +
                            $", Брой страници: {book.PagesCount}" +
                            $", Последно взета от: {(book.BookRents.Count() == 0 ? "не e взимана" : $"{book.BookRents.Last().User.FirstName} {book.BookRents.Last().User.SirName} {book.BookRents.Last().User.LastName}")}" +
                            $", В библиотеката ли е книгатa: {(book.BookRents.Count() == 0 ? "да" : (book.BookRents.Last().IsBookReturned ? "да" : "не"))}";


                        booksOutputListBox.Items.Add(info);
                    }
                }
                catch (Exception)
                {
                    booksOutputListBox.Items.Add("Грешка!!!");
                }
            }
        }
    }
}
