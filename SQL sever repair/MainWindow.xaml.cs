using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQL_sever_repair
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"server=(localdb)\v11.0");
            using (connection)
            {
                connection.Open();

                string sql = string.Format(@"
                                            CREATE DATABASE
                                                [Test]
                                            ON PRIMARY (
                                               NAME=Test_data,
                                               FILENAME = '{0}\Database.mdf'
                                            )
                                            LOG ON (
                                                NAME=Test_log,
                                                FILENAME = '{0}\sql_log.ldf'
                                            )",
                                                        @"B:\Desktop\Student Management System\bin\Debug"
                                                    );

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
