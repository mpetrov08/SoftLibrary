using SoftLibrary.Data.Models;
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
using Microsoft.EntityFrameworkCore;

namespace SoftLibrary.Screens
{
    public partial class ViewUsersScreen : Form
    {
        public ViewUsersScreen()
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

                    int iterationsNumber = context.Users.Count() + context.Users.First().Id;
                    for (int i = context.Users.First().Id; i < iterationsNumber; i++)
                    {
                        User user = context.Users.Include(b => b.BookRents).ThenInclude(br => br.Book).Where(b => b.Id == i).First();
                        string info = $"Код: {user.Code}, Име: {user.FirstName} {user.SirName} {user.LastName}, Телефон: {user.PhoneNumber}, Възраст: {user.Age}, Адрес: {user.Address}" +
                                      $", Клас: {(string.IsNullOrEmpty(user.Class) ? "няма въведен клас" : user.Class)}" +
                                      $", Броя на всички взети книги: {user.BookRents.Count()}" +
                                      $", Брой на невърнати книги: {user.BookRents.Where(br => br.IsBookReturned == false).Count()}" +
                                      $", Кодове на наем на невърнатите книги: {string.Join(", ", user.BookRents.Where(br => br.IsBookReturned == false).Select(br => br.RentCode))}";

                        usersOutputListBox.Items.Add(info);
                    }
                }
                catch (Exception)
                {
                    usersOutputListBox.Items.Add("Грешка!!!");
                }
            }
        }
    }
}
