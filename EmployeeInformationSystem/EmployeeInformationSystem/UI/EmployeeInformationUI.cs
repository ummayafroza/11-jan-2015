using System.Windows.Forms;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAL.DAO;

namespace EmployeeInformationSystem.UI
{
    public partial class EmployeeInformationUI : Form
    {
        DesignationManager aDesignationManager = new DesignationManager();
        EmployeeManager aEmployeeManager = new EmployeeManager();
        public EmployeeInformationUI()
        {
            InitializeComponent();
            designationComboBox.DisplayMember = "Title";
        }

        private void saveEmployeeButton_Click(object sender, System.EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            Designation selectedDesignation = (Designation) designationComboBox.SelectedItem;
            anEmployee.EmployeeDesignation = selectedDesignation;
            string msg = aEmployeeManager.Save(anEmployee);
            MessageBox.Show(msg);
        }

        private void EmployeeInformationUI_Load(object sender, System.EventArgs e)
        {
            designationComboBox.DataSource = aDesignationManager.GetAll();
        }
    }
}
