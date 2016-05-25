using CommunicatingBetweenControls.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommunicatingBetweenControls.UserControls
{
    /// <summary>
    /// Interaction logic for Jobs.xaml
    /// </summary>
    public partial class Jobs : UserControl
    {
        List<Job> _Jobs = new List<Job>
        {
            new Job { ID = 1, Title = "Area 1 Maintenance", StartDate = DateTime.Now.AddMonths(-36), EndDate = DateTime.Now.AddMonths(8) },
            new Job { ID = 2, Title = "Edge Park", StartDate = DateTime.Now.AddMonths(-9), EndDate = DateTime.Now.AddMonths(17) },
            new Job { ID = 3, Title = "Paint Benches", StartDate = DateTime.Now.AddMonths(-18), EndDate = DateTime.Now.AddMonths(26) },
            new Job { ID = 4, Title = "Build New Wall", StartDate = DateTime.Now.AddMonths(-27), EndDate = DateTime.Now.AddMonths(35) },
        };

        public Jobs()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            JobsComboBox.SelectedValuePath = "ID";
            JobsComboBox.DisplayMemberPath = "Title";
            JobsComboBox.ItemsSource = _Jobs;
        }

        private void JobsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mediator.GetInstance().OnJobChanged(this, (Job)JobsComboBox.SelectedItem);
        }
    }
}
