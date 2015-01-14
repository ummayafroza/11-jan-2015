using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.DAL.DAO;

namespace EmployeeInformationSystem.DAL.DBGateway
{
    class EmployeeDBGateway
    {
        string connectionStr = ConfigurationManager.ConnectionStrings["connectionStringForEmployeDB"].ConnectionString;
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;
        public EmployeeDBGateway()
        {
            aSqlConnection = new SqlConnection(connectionStr);
        }

        public void Save(Employee anEmployee)
        {
            string query = "INSERT INTO tbl_Employee VALUES ('" + anEmployee.Name + "','" + anEmployee.Email + "', '" + anEmployee.Address + "', '" + anEmployee.EmployeeDesignation.Id + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<Employee> GetAll()
        {
            string query = "SELECT * FROM tbl_Employee";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query,aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            List<Employee> employeeList = new List<Employee>();

            while (aDataReader.Read())
            {
                Employee anEmployee = new Employee();
                anEmployee.Id = Convert.ToInt32(aDataReader["Id"]);
                anEmployee.Name = aDataReader["Name"].ToString();
                anEmployee.Email = aDataReader["Email"].ToString();
                anEmployee.Address = aDataReader["Address"].ToString();
                anEmployee.EmployeeDesignation.Id = Convert.ToInt32(aDataReader["Designation_Id"]);
                employeeList.Add(anEmployee);
            }
            aDataReader.Close();
            aSqlConnection.Close();
            return employeeList;

        }
        public Employee Find(string email)
        {
            string query = "SELECT * FROM tbl_Employee WHERE Email = '" + email + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            Employee anEmployee;

            if (aDataReader.HasRows)
            {
                anEmployee = new Employee();
                aDataReader.Read();
                anEmployee.Id = Convert.ToInt32(aDataReader["Id"]);
                anEmployee.Name = aDataReader["Name"].ToString();
                anEmployee.Email = aDataReader["Email"].ToString();
                anEmployee.Address = aDataReader["Address"].ToString();
                anEmployee.EmployeeDesignation.Id = Convert.ToInt32(aDataReader["Designation_Id"]);

                aDataReader.Close();
                aSqlConnection.Close();
                return anEmployee;
            }
            else
            {
                aSqlConnection.Close();
                return null;
            }
        }
        public List<Employee> SearchEmployee(string name)
        {
            List<Employee> employeeList = new List<Employee>();
            string query = "SELECT * FROM tbl_Employee";
            aSqlConnection.Open();
            Employee employee ;
            if (!String.IsNullOrEmpty(name))
            {
                query = "SELECT * FROM tbl_Employee WHERE Name = '"+name + "'";
            }

            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            

            while (aDataReader.Read())
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(aDataReader["Id"]);
                employee.Name = aDataReader["Name"].ToString();
                employee.Email = aDataReader["Email"].ToString();
                employee.Address = aDataReader["Address"].ToString();
               // employee.EmployeeDesignation.Id = Convert.ToInt32(aDataReader["Designation_Id"]);
                employeeList.Add(employee);
            }
            
            aDataReader.Close();
            aSqlConnection.Close();
            return employeeList;

        }

        public Employee GetAnEmployee(int id)
        {
            Employee anEmployee = new Employee();
            string query = "SELECT * FROM tbl_Employee WHERE Id = '"+ id +"'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query,aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            aSqlDataReader.Read();

            anEmployee.Id = Convert.ToInt32(aSqlDataReader["Id"]);
            anEmployee.Name = aSqlDataReader["Name"].ToString();
            anEmployee.Email = aSqlDataReader["Email"].ToString();
            anEmployee.Address = aSqlDataReader["Address"].ToString();
            //anEmployee.EmployeeDesignation.Id= Convert.ToInt32(aSqlDataReader["Designation_Id"]);
            
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return anEmployee;

        }

        public int Update(Employee anEmployee)
        {
            string query = "UPDATE tbl_Employee SET Name= '" + anEmployee.Name + "' , Email= '" + anEmployee.Email +"' , Address='" + anEmployee.Address + "' WHERE Id ='" + anEmployee.Id + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query,aSqlConnection);
            int rowAffected = aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            return rowAffected;

        }
    }
}
