using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Sprint_1
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {//This will close the program
            MessageBox.Show("You are closing this program!");
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //This will clear the text boxes and the result label
            firstNameTextBox.Text = null;
            initialTextBox.Text = null;
            lastNameTextBox.Text = null;
            userTextBox.Text = null;
            emailTextBox.Text = null;
            reenterTextBox.Text = null;
            passwordTextBox.Text = null;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {//thsi takes to login form
            loginForm newform = new loginForm();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //sql connection, add files to database
            try
            {
             string hash = "0xB109F3BBBC244EB82441917ED06D618B9008DD09B3BEFD1B5E07394C706A8BB980B1D7785E5976EC049B46DF5F1326AF5A2EA6D103FD07C95385FFAB0CACBC86";

            SqlConnection con = new SqlConnection(@"Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamMBSR;User ID=234a_TeamMBSR;Password=TeamMBSR_FA20_(^#"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Users values ('" + firstNameTextBox.Text +
             "','" + initialTextBox.Text + "','" + lastNameTextBox.Text + "','" + userTextBox.Text + "','" +
             emailTextBox.Text + "', CONVERT(varbinary(max), '" + hash + "'), 'SU')", con);
    
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    //this will take to login page
                    //loginForm frm1 = new loginForm();
                    //frm1.ShowDialog();

                }
                else
                    MessageBox.Show("Invalid username or password");
            }
            catch
            {
                MessageBox.Show("Subscribed!");
                loginForm frm1 = new loginForm();
                frm1.ShowDialog();
            }
        }
    }
}
