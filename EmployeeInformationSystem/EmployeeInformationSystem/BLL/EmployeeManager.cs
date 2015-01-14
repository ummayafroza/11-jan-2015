using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.DAL.DAO;
using EmployeeInformationSystem.DAL.DBGateway;

namespace EmployeeInformationSystem.BLL
{
    class EmployeeManager
    {
    EmployeeDBGateway anEmployeeDbGateway = new EmployeeDBGateway();
        public string Save(Employee anEmployee)
        {
            Employee employee = anEmployeeDbGateway.Find(anEmployee.Email);
            if (employee == null)
            {
                anEmployeeDbGateway.Save(anEmployee);
                return "Employee added successfully.";
            }
            else
            {
                return "Duplicate email. Try with different one.";
            }
        }

        public List<Employee> SearchEmployee(string name)
        {
            return anEmployeeDbGateway.SearchEmployee(name);

        }

        public List<Designation> LoadDesignationList()
        {
            DesignationDBGateway aDesignationDbGateway = new DesignationDBGateway();
            return aDesignationDbGateway.LoadDesignationList();
        }


        public Employee GetAnEmployee(int id)
        {
            return anEmployeeDbGateway.GetAnEmployee(id);
        }

        public string Update(Employee anEmployee)
        {
            if (anEmployeeDbGateway.Update(anEmployee) > 0)
            {
                return "Successfully updated.";
            }
            else
            {
                return "Sorry! Couldn't update properly.";
            }
        }
    }
}
