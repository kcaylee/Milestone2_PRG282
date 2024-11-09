using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Project.BusinessLayer;
using System.Xml.Linq;

namespace Project.DataLayer
{
    internal class DataHandler
    {
        string connection = @"Server=HOODED_PC\MSSQLSERVER01;Initial Catalog=PRG282_Project;Integrated Security=SSPI";
        
        public DataTable getAllInfo()
        {
            try
            {
                string qDisplay = "SELECT Students.StudentNum, Students.StudentName, " +
                    "Students.StudentSurname, Students.StudentDOB, Students.PhoneNum, Students.HomeAddress, " +
                    "Modules.ModuleCode, Modules.ModuleName, Modules.ModuleLink, Modules.ModuleDescription, " +
                    "Genders.GenderID, Genders.GenderName " +
                    "FROM Students " +
                    "INNER JOIN StudentModules ON students.StudentNum = StudentModules.StudentNum " +
                    "INNER JOIN Modules ON Modules.ModuleCode = StudentModules.ModuleCode " +
                    "INNER JOIN Genders ON Genders.GenderID = Students.GenderID;";
                SqlDataAdapter da = new SqlDataAdapter(qDisplay, connection);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public DataTable Search(string search)
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            string qDisplay = "SELECT Students.StudentNum, Students.StudentName, " +
                "Students.StudentSurname, Students.StudentDOB, Students.PhoneNum, Students.HomeAddress, " +
                "Modules.ModuleCode, Modules.ModuleName, Modules.ModuleLink, Modules.ModuleDescription, " +
                "Genders.GenderID, Genders.GenderName " +
                "FROM Students " +
                "INNER JOIN StudentModules ON students.StudentNum = StudentModules.StudentNum " +
                "INNER JOIN Modules ON Modules.ModuleCode = StudentModules.ModuleCode " +
                "INNER JOIN Genders ON Genders.GenderID = Students.GenderID " +
                $"WHERE Students.StudentNum = '{search}'";
            SqlDataAdapter da = new SqlDataAdapter(qDisplay, connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getStudent()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            string qDisplay = "SELECT * FROM Students";
            SqlDataAdapter da = new SqlDataAdapter(qDisplay, connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getModule()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            string qDisplay = "SELECT * FROM Modules";
            SqlDataAdapter da = new SqlDataAdapter(qDisplay, connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void StUpdate(Student student) 
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            string qUpdate = $"UPDATE Students " +
                $"SET StudentName = '{student.StudentName1}', StudentSurname = '{student.StudentSurname1}', StudentDOB = '{student.StudentDOB1}', " +
                $"PhoneNum = '{student.PhoneNum1}', HomeAddress = '{student.HomeAddress1}' WHERE StudentNum = '{student.StudentNum1}';";
            SQLCom(qUpdate, connection);
        }

        public void MoUpdate(Module module)
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            string qUpdate = $"UPDATE Modules " +
                $"SET ModuleDescription = '{module.ModuleDescription1}', ModuleName = '{module.ModuleName1}', ModuleLink = '{module.ModuleLink1}' " +
                $"WHERE ModuleCode = '{module.ModuleCode1}';";
            SQLCom(qUpdate, connection);
        }

        public void Delete(string stNum)
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            string qDisplay = "SELECT Students.StudentNum, Students.StudentName, " +
                "Students.StudentSurname, Students.StudentDOB, Students.PhoneNum, Students.HomeAddress, " +
                "Modules.ModuleCode, Modules.ModuleName, Modules.ModuleLink, Modules.ModuleDescription, " +
                "Genders.GenderID, Genders.GenderName " +
                "FROM Students " +
                "INNER JOIN StudentModules ON students.StudentNum = StudentModules.StudentNum " +
                "INNER JOIN Modules ON Modules.ModuleCode = StudentModules.ModuleCode " +
                "INNER JOIN Genders ON Genders.GenderID = Students.GenderID " +
                $"WHERE Students.StudentNum = '{stNum}'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qDisplay, connection);

            da.Fill(dt);
            string mc ="0";
            foreach (DataRow dr in dt.Rows)
            {
                mc = dr["ModuleCode"].ToString();                
            }

            string Delete = $"DELETE FROM StudentModules WHERE StudentNum = '{stNum}' AND ModuleCode = '{mc}'";
            SQLCom(Delete, connection);

            Delete = $"DELETE FROM Students WHERE StudentNum = '{stNum}';";
            SQLCom(Delete, connection);

            Delete = $"DELETE FROM Modules WHERE ModuleCode = '{mc}';";
            SQLCom(Delete, connection);
        }

        public void StInsert(Student student)
        {
            try
            {
                string Insert = $"INSERT INTO Students (StudentNum, StudentName, StudentSurname, StudentDOB, GenderID, PhoneNum, HomeAddress)" +
                    $"VALUES ('{student.StudentNum1}', '{student.StudentName1}', '{student.StudentSurname1}', " +
                    $"CONVERT(DATE, '{student.StudentDOB1}'), " +
                    $"{student.GenderID1}, '{student.PhoneNum1}', '{student.HomeAddress1}');";
                SQLCom(Insert, connection);

                //Insert = $"INSERT INTO StudentModules (StudentNum)" +
                //    $"VALUES ('{student.StudentNum1}');";
                //SQLCom(Insert, connection);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void MoInsert(Module module)
        {
            try
            {
                string Insert = $"INSERT INTO Modules (ModuleCode, ModuleName, ModuleDescription, ModuleLink) " +
                    $"VALUES ('{module.ModuleCode1}', '{module.ModuleName1}', '{module.ModuleDescription1}', '{module.ModuleLink1}');";
                SQLCom(Insert, connection);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        public void SQLCom(string q, string conn)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand com = new SqlCommand(q, con))
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

            
        }
    }
}
