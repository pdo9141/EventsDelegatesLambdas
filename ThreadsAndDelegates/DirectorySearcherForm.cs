using System;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class DirectorySearcherForm : Form
    {
        public DirectorySearcherForm()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new DirectorySearcherForm());
        }

        private void directorySearcher_SearchComplete(object sender, System.EventArgs e)
        {
            SearchLabel.Text = String.Empty;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            directorySearcher.SearchCriteria = searchText.Text;
            SearchLabel.Text = "Searching...";
            directorySearcher.BeginSearch();
        }
    }
}
