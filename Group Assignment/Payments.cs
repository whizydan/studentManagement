using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class Payments : Form
    {
        string binder;
        public Payments(string username)
        {
            InitializeComponent();
            updateView(username);
            binder = username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            var transaction_code = textBox1.Text;
            var class_id = textBox4.Text;
            var comment = textBox2.Text;
            var amount = textBox3.Text;
            var subject = textBox5.Text;

            var sql_update_class = $@"update classes set paid = 'paid' where id = '{class_id}'";
            
            //get all data for student to generate invoice
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var update_class = new SqlCommand(sql_update_class, conn);
                update_class.ExecuteNonQuery();
                string sqlString = $@"select * from Students where username = '{binder}'";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            var level = oReader["level"];
                            var password = oReader["ICPassport"].ToString();
                            var name = oReader["name"].ToString();
                            var sql_update_transactions = $@"insert into 
                                transactions(name,transaction_code,amount,description,subject,level) 
                                values('{binder}','{transaction_code}','{amount}','{comment}','{subject}','{level}')";
                            var transact = new SqlCommand(sql_update_transactions, conn);
                            generatePdf(password,amount,subject,name);
                            oReader.Close();
                            updateView(binder);
                            transact.ExecuteNonQuery();
                            break;
                        }
                    }
                }
            }
        }

        private void generatePdf(string password,string amount,string subject,string name)
        {
            var date = DateTime.Now;
            var invoice_number = Guid.NewGuid().ToString("N"); ;
            var html = $@"
                        <html>
                        <head>
                          <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
                          <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""></script>
                          <title>Invoice</title>
                          </ head >
                          <body>
                          <br><br>
                          <div class=""container"">
                          <div class=""card"">
                          <div class=""card-header"">
                            INVOICE
                          </div>
                          <div class=""card-body"">
                            <h5 class=""card-title"">{name}</h5>
                            <p class=""card-text"">Username : {binder}</p>
                            <p class=""card-text"">Amount : {amount}</p>
                            <p class=""card-text"">Date : {date}</p>
                            <p class=""card-text"">Subject : {subject}</p>
                            <p class=""card-text"">invoice number : {invoice_number}</p>
    
                          </div>
                        </div>
                          </div>

                        </body>
                        </html>
                                
                             ";

            var Renderer = new IronPdf.ChromePdfRenderer();
            Renderer.RenderingOptions.FirstPageNumber = 1;
            Renderer.RenderingOptions.HtmlFooter = new IronPdf.HtmlHeaderFooter()
            {

                MaxHeight = 15, //millimeters
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
                DrawDividerLine = true
            };
            using PdfDocument Pdf = Renderer.RenderHtmlAsPdf(html);

            //PDF Settings
            Pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            Pdf.SecuritySettings.UserPassword = password;
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                folderName = folderName + "\\invoice.pdf";
                Pdf.SaveAs(folderName);
            }

        }

        private void updateView(string username)
        {
            SqlDataAdapter da;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = $@"select * from classes where  student = '{username}'";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    //grid data for all students
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
