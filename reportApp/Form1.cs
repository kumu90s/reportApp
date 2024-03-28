using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warning = Microsoft.Reporting.WinForms.Warning;


namespace reportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetReportDataSource();
            this.reportViewer1.RefreshReport();
        }

        private void View_Click(object sender, EventArgs e)
        {
            SetReportDataSource();
            //ReportDataSource customerList = new ReportDataSource("DataSet1", CustomerInfo());
            //reportViewer1.LocalReport.ReportPath = @"C:\Users\Raju\source\repos\reportApp\reportApp\Report1.rdlc";
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(customerList);
        }
        private void SetReportDataSource()
        {
            // Create a data source instance
            var data = CustomerInfo();
            DataSet1 ds = new DataSet1();
            foreach(var row in data)
            {
                DataRow rd = ds.customerData.NewRow();
                rd["SNo"] = row.Sno;
                rd["Date"] = row.date;
                rd["CustomerId"] = row.customerId;
                rd["Name"]= row.name;
                rd["cellPhone"] = row.phone;
                rd["Email"] = row.email;
                ds.customerData.Rows.Add(rd);
            }
            ReportDataSource customerList = new ReportDataSource("DataSet1", (IEnumerable)ds.customerData);
            // Set the report path
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Raju\source\repos\reportApp\reportApp\Report1.rdlc";
            // Clear existing data sources before adding the new one
            reportViewer1.LocalReport.DataSources.Clear();
            // Add the data source to the report viewer
            reportViewer1.LocalReport.DataSources.Add(customerList);
        }
        private List<customerDto> CustomerInfo()
        {
            List<customerDto> dataTable = new List<customerDto>();
            string connectionString = @"Data Source=DESKTOP-K08BV9R\SQLEXPRESS;Initial Catalog=logDb;Integrated Security=True;Encrypt=False";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //string query = "SELECT [Sno.],[date],[customer ID],[Name],[cell Phone],[Email] FROM RDLCtable";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT [Sno.],[date],[customer ID],[Name],[cell Phone],[Email] FROM RDLCtable";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    // Execute the query and load data into DataTable
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            dataTable.Add(new customerDto()
                            {
                                Sno = rd["Sno."].ToString(),
                                date = rd["date"].ToString(),
                                customerId = rd["customer ID"].ToString(),
                                name = rd["Name"].ToString(),
                                phone = rd["cell Phone"].ToString(),
                                email = rd["Email"].ToString()
                            });
                        }
                    }
                }
            }
            return dataTable;
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K08BV9R\SQLEXPRESS;Initial Catalog=logDb;Integrated Security=True;Encrypt=False");
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "select * from RDLCtable";
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Connection = con;
            //    con.Open();
            //    var rd = cmd.ExecuteReader();
            //    dataTable.Load(rd);
            //    return dataTable;
            //}
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamIds;
            string mimeType;
            string encoding;
            string extension;

            // Render the report as PDF
            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

            // Save the PDF to a file
            string filePath = @"C:\Users\Raju\Report.pdf";
            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            MessageBox.Show("PDF report generated successfully at: " + filePath, "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }  
    }
}
