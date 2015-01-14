using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAL.DAO;

namespace EmployeeInformationSystem.UI
{
    public partial class UpdateUI : Form
    {
        public UpdateUI(int id)
        {
            InitializeComponent();
            Employee anEmployee = anEmployeeManager.GetAnEmployee(id);

            idTextBox.Text = anEmployee.Id.ToString();
            nameTextBox.Text = anEmployee.Name;
            emailTextBox.Text = anEmployee.Email;
            addressTextBox.Text = anEmployee.Address;
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "Id";
            designationComboBox.DataSource = null;
            designationComboBox.DataSource = anEmployeeManager.LoadDesignationList();
           // designationComboBox.SelectedValue = anEmployee.EmployeeDesignation.Id;
        }
        EmployeeManager anEmployeeManager =new EmployeeManager();

        private void updateButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Id = Convert.ToInt32(idTextBox.Text);
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            //anEmployee.EmployeeDesignation.Id = Convert.ToInt32(designationComboBox.SelectedValue);
            string msg = anEmployeeManager.Update(anEmployee);
            MessageBox.Show(msg);
        }
    }
}
