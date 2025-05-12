using System.Data;
using System.Windows.Forms;
using Npgsql;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HireFire
{
    public partial class MainWindow : Form
    {
        //string connectionString = "Server=localhost;Port=5432;Database=HireFire; User Id = postgres; Password=277353;";
        public MainWindow()
        {
            InitializeComponent();
            //SqlConnectionReader();
        }

        private void MainWindow_Load(object sender, EventArgs e) { }

        private void Acception1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            LoginRegister_Page login_register_control = new LoginRegister_Page();
            login_register_control.Dock = DockStyle.Fill;

            this.Controls.Add(login_register_control);

        }
        /*private void SqlConnectionReader()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM \"AllAccounts\"";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                //dataGridView1.DataSource = data;
            }

            command.Dispose();
            sqlConnection.Close();

        }
*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
