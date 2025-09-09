using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CMCS.Pages
{
    /// <summary>
    /// Interaction logic for CoordinatorDashboard.xaml
    /// </summary>
    public partial class CoordinatorDashboard : Window
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();
        }

        private void ReviewClaim_Click (object sender, RoutedEventArgs e)
        {
            ReviewClaimPage Rp = new ReviewClaimPage();
            Rp.Show();
            this.Close();
        }

        private void ApproveOrReject_Click (object sender, RoutedEventArgs e)
        {
            ApproveOrRejectPage Rp = new ApproveOrRejectPage();
            Rp.Show();
        }
    }
}
