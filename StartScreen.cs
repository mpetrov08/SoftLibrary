using SoftLibrary.Data;
using SoftLibrary.Screens;

namespace SoftLibrary
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            using (SoftLibraryContext context = new SoftLibraryContext())
            {
                context.Database.EnsureCreated();
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookScreen addBookScreen = new AddBookScreen();
            addBookScreen.Show();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            RemoveBookScreen removeBookScreen = new RemoveBookScreen();
            removeBookScreen.Show();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserScreen addUserScreen = new AddUserScreen();
            addUserScreen.Show();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            RemoveUserScreen removeUserScreen = new RemoveUserScreen();
            removeUserScreen.Show();
        }

        private void rentABookButton_Click(object sender, EventArgs e)
        {
            RentABookScreen rentABookScreen = new RentABookScreen();
            rentABookScreen.Show();
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            ReturnBookScreen returnBookScreen = new ReturnBookScreen();
            returnBookScreen.Show();
        }

        private void viewRentedBookButton_Click(object sender, EventArgs e)
        {
            ViewRentedBookScreen viewRentedBookScreen = new ViewRentedBookScreen();
            viewRentedBookScreen.Show();
        }

        private void viewBooksButton_Click(object sender, EventArgs e)
        {
            ViewBookScreen viewBookScreen = new ViewBookScreen();
            viewBookScreen.Show();
        }

        private void howToUseButton_Click(object sender, EventArgs e)
        {
            HowToUseAppScreen howToUseAppScreen = new HowToUseAppScreen();
            howToUseAppScreen.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewUsersButton_Click(object sender, EventArgs e)
        {
            ViewUsersScreen viewUsersScreen = new ViewUsersScreen();
            viewUsersScreen.Show();
        }
    }
}