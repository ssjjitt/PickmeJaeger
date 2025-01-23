using PickmeJaeger.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PickmeJaeger
{
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            OpenControl(controls.login);
        }

        public enum controls
        {
            login,
            register
        }

        public void OpenControl(controls pages)
        {
            if (pages == controls.login)
            {
                Main.Navigate(new LoginControl(this));
            }
            else if (pages == controls.register)
            {
                Main.Navigate(new RegisterControl(this));
            }
        }

        private void Authorization_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-9FDAEQH;Trusted_Connection=Yes;DataBase=PickmeJaeger;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
