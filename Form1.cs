using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;                                  // in order to use the database in the code
using System.Threading;

namespace Login_Form_Application
{
    public partial class Login_btn : Form
    {
        // The password to login is: 
        public Login_btn()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"desktop-386g63p\hassansqlserver.Youtube.dbo=True");                  //Now we are Connected to the dataBase that we created.
        private void Login_btn_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)              //Loginbtn_Click_Event
        {

            // Specifiying infromations in order to login 

            string username, user_password;

            username = UserName_txt.Text;                        //Assiging the value which is gotten by UserName_txt to the username. 
            user_password = Password_txt.Text;                    //Assiging the password which is gotten by Password_txt to the User_password.


            try
            {
                string querry = "SELECT * FROM LOING WHERE USERNAME = '" + UserName_txt.Text + "' AND Password = '" + Password_txt.Text + "'";              //Selecting the informations and passing it into querry 

                SqlDataAdapter adapter = new SqlDataAdapter(querry,connect);   // Creating  SqlDataAdapter called adapter and passing query which is holding the userName And Password informations And also passing Connect which is holding the databse which we created.

                DataTable dtable = new DataTable();                         // Creating a new table of datas 

                adapter.Fill(dtable);                                    // Here the adapter will the table with the informations that we entered like UserName and Password informations.
                                                                         
                //Check where the table is empty or not if it is lets insert the values in the table 


                if(dtable.Rows.Count > 0)                               //Putting the values accoridng to the table's row.
                {
                    username = UserName_txt.Text;
                    user_password = Password_txt.Text;


                    //Page that needed to be load next 

                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Invalid login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);        // if the details are entered wrong.
                    UserName_txt.Clear();
                    Password_txt.Clear();

                    //To focus UserName 

                   UserName_txt.Focus();


                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connect.Close();                               //Closing the server or the database that we were created.
            }
          

        }

        private void Clear_btn_Click(object sender, EventArgs e)               //Clear Button's Click Event 
        {

            UserName_txt.Clear();
            Password_txt.Clear();

            UserName_txt.Focus();

        }

        private void Exit_btn_Click(object sender, EventArgs e)  //Exit button
        {

            DialogResult res;
            res = MessageBox.Show("Do You Want to exit", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {

                Application.Exit();


            }
            else
            {
                this.Show();
            }
            


        }
    }
}
