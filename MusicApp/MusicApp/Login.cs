using Microsoft.Data.SqlClient;
using System.Data;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MusicAppDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {   
            String username, user_password;
            username = txtBox_Username.Text;
            user_password = txtBox_Password.Text;
            try
            {
                String query = "SELECT * FROM Users WHERE Username = '"+txtBox_Username+ "' AND Password = '+"+txtBox_Password+"'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    username = txtBox_Username.Text;
                    user_password = txtBox_Password.Text;

                    MainMenuUser menuUser = new MainMenuUser();
                    menuUser.Show();
                    this.Hide();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Login Information");
                txtBox_Username.Clear();
                txtBox_Password.Clear();
            }
            finally
            {
                connection.Close();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }
    }
}