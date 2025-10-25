
using CMCS.Pages;
using CMCS.Users;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lecture_Click(object sender, RoutedEventArgs e)
        {
            //new LecturerDashboard().Show();
            LectureLoginPage loginPage = new LectureLoginPage();
            loginPage.Show();
            this.Close();
        }

        private void Coordinator_Click(object sender, RoutedEventArgs e)
        {
            //new CoordinatorDashboard().Show();
            CordinatorLogin cordinatorLogin = new CordinatorLogin();
            cordinatorLogin.Show();
            this.Close();
        }

        private void Manager_Click(object sender, RoutedEventArgs e)
        {
            //new ManagerDashboard().Show();
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
            this.Close();
        }
    }
}