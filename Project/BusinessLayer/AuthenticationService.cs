using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project.BusinessLayer
{
    internal class AuthenticationService
    {
        /*public void createFile()
        {
            if (!File.Exists("Users.txt"))
            {
                File.Create("Users.txt");
            }
        }*/

        public void registerUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Username cannot be empty.");
            }
            else if (name.IndexOf('|') != -1)
            {
                MessageBox.Show("Username may not contain '|'.");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.");
            }
            else
            {
                StreamWriter writer = new StreamWriter("Users.txt");
                writer.WriteLine(name + '|' + password);
                writer.Close();
            }
            
        }

        public bool isAuthenticated(string name, string password)
        {
            bool auth = false;
            bool correctName = false;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Username cannot be empty.");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.");
            }
            else
            {
                StreamReader reader = new StreamReader("Users.txt");
                string line = reader.ReadLine();

                while (line != null)
                {
                    string username = line.Remove(line.IndexOf('|'), line.Length - line.IndexOf('|'));
                    string pass = line.Remove(0, line.IndexOf('|')+1);

                    if (username == name)
                    {
                        correctName = true;
                        if (pass == password)
                        {
                            auth = true;
                        }
                    }
                    line = reader.ReadLine();
                }

                reader.Close();
                if (!correctName) {
                    MessageBox.Show("User was not found, please register.");
                } else 
                {
                    if (!auth)
                    {
                        MessageBox.Show("Password is incorrect.");
                    }
                }
            }
            return auth;
        }

    }
}

