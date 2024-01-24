using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WpfLogin
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        ///*
        string ConnStr = @"Data Source = (LocalDB)/MSSQLLocalDB; " +
           "AttachDbFilename = C:/Users/Jinu/source/repos/WpfApp1/WpfLogin/Login.mdf; integrated Security = True";
        //*/


        /*
            string ConnStr = @"Data Source = DESKTOP-1NK6BMC/SQLEXPRESS; " +
            "AttachDbFilename = C:/Users/Jinu/source/repos/WpfApp1/WpfLogin/Login.mdf; integrated Security = True";
        */

        //C:\Users\Jinu\source\repos\WpfApp1\WpfLogin\

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = string.Format("SELECT COUNT(*) FROM LoginTable " +
                    "WHERE UserName = '{0}' AND Password = '{1}'",
                    txtUserName.Text, txtPassword.Password);
                SqlCommand comm = new SqlCommand(sql, conn);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)
                    MessageBox.Show("성공");
                else
                    MessageBox.Show("실패");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
