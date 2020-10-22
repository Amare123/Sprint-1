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
using System.Configuration;

namespace Sprint_1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {//This will close the program
            MessageBox.Show("You are closing this program!");
            this.Close();
        }
        //sql connection
        SqlConnection con = new SqlConnection(@"Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamMBSR;User ID=234a_TeamMBSR;Password=TeamMBSR_FA20_(^#"); // making connection   


        private void loginButton_Click(object sender, EventArgs e)
        {
            //this helps to login after users subscribe
            try
            {

                string Password = "";
                string Username = "";
                //string strCon = ConfigurationManager.ConnectionStrings["EPortfolioConnectionString"].ToString();


                bool IsExist = false;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblUserRegistration where UserName='" + userTextBox.Text + "'", con);
                cmd = new SqlCommand("select Username,word from tbl_Check where USername=@Username and word=@word");
                cmd.Parameters.AddWithValue("@Username", userTextBox.Text.ToString());
                cmd.Parameters.AddWithValue("@word", passwordTextBox.Text.ToString());


                
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Password = sdr.GetString(2);  //get the user password from db if the user name is exist in that.  
                    IsExist = true;
                }
                con.Close();
                if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
                {
                    //if (Cryptography.Decrypt(Password).Equals(passwordTextBox.Text))
                    //{
                    //    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    //welcomeForm frm1 = new welcomeForm();
                    //    //frm1.ShowDialog();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}                 

                }
                else  //showing the error message if user credential is wrong  
                {
                    MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                //takes to the next form
                MessageBox.Show("Welcome!");
                welcomeForm frm1 = new welcomeForm();
                frm1.ShowDialog();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {//this close the program
            this.Close();
        }
    }
}













//private void clearButton_Click(object sender, EventArgs e)
//{
//    userTextBox.Text = null;
//    passwordTextBox.Text = null;
//}

//private void clickButton_Click(object sender, EventArgs e)
//{
//    registrationForm newform = new registrationForm();
//    this.Hide();
//    newform.ShowDialog();
//    this.Show();
//}

//private void loginButton_Click(object sender, EventArgs e)
//{
//    SqlConnection con = new SqlConnection(@"Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamMBSR;User ID=234a_TeamMBSR;Password=TeamMBSR_FA20_(^#"); // making connection


//    if (userTextBox.Text == "" || passwordTextBox.Text == "")
//    {

//    }

//    else

//    {

//        SqlCommand scmd;
//        SqlDataReader sdr;



//        SqlCommand scmd = new SqlCommand("insert into time(project,iteration)values('" + this.name1.SelectedValue + "','" + this.iteration.SelectedValue + "')", conn);



//        scmd = new SqlCommand("select Username,word from tbl_Check where USername=@Username and word=@word");

//        scmd.Parameters.AddWithValue("@Username", userTextBox.Text.ToString());

//        scmd.Parameters.AddWithValue("@word", passwordTextBox.Text.ToString());

//        sdr = scmd.ExecuteReader();

//        if (sdr.HasRows)

//        {

//            sdr.Close();

//            MessageBox.Show("Welcome- The Username and word is Correct", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

//        }

//        else

//        {

//            MessageBox.Show("Invalid Username or word", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

//        }

//}
//    }

