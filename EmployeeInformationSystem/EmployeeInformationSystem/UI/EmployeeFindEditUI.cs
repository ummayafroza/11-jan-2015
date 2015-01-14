using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAL.DAO;

namespace EmployeeInformationSystem.UI
{
    public partial class EmployeeFindEditUI : Form
    {
        public EmployeeFindEditUI()
        {
            InitializeComponent();

        }
        EmployeeManager anEmployeeManager = new EmployeeManager();

        private void resultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = resultListView.SelectedItems[0];
            Employee selectedEmployee = (Employee)selectedItem.Tag;

            UpdateUI aUpdateUi = new UpdateUI(selectedEmployee.Id);
            aUpdateUi.Show();

            
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            resultListView.Items.Clear();
            List<Employee> aList = anEmployeeManager.SearchEmployee(searchTextBox.Text);

            foreach (Employee employee in aList)
            {
                ListViewItem aListViewItem = new ListViewItem();

                aListViewItem.Text = employee.Id.ToString();
                aListViewItem.SubItems.Add(employee.Name);
                aListViewItem.SubItems.Add(employee.Email);
                aListViewItem.Tag = employee;
                resultListView.Items.Add(aListViewItem);
            }

        }

        private void resultListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
