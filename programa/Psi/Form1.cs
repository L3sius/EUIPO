using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace Psi
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private String path="empty";
        private String pathForApplicants = "empty";
        private String pathForTradeMarks = "empty";
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                path = strfilename;
                //MessageBox.Show(strfilename);
            }

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";" + "Persist Security Info = False; ";

            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT ID, APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE FROM TRADEMARKS"; // , APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE
                command.CommandText = query;




                OleDbDataAdapter da = new OleDbDataAdapter(command);
                
                da.Fill(dt);
                advancedDataGridView2.DataSource = dt;

                //checkConnection.Text = "veikia";
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            /*try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT ID, APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE FROM TRADEMARKS";
                command.CommandText = query;
               
               
                

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                advancedDataGridView1.DataSource = dt;

                //checkConnection.Text = "veikia";
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'euipo_db_OrigDataSet.Trademarks' table. You can move, or remove it, as needed.
            this.trademarksTableAdapter.Fill(this.euipo_db_OrigDataSet.Trademarks);
            // TODO: This line of code loads data into the 'euipo_db_OrigDataSet.Applicants' table. You can move, or remove it, as needed.
            this.applicantsTableAdapter.Fill(this.euipo_db_OrigDataSet.Applicants);







        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
            
            modifiedApplicants.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void AdvancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImportTradeMarks_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
            modiefiedTradeMarks.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Export_Click(object sender, EventArgs e)
        {
            DataSet dSet = new DataSet("New_DataSet");
            dSet.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dSet.Tables.Add(dt);
            //ExcelLibrary.DataSetHelper.CreateWorkbook("Psi Excel.xls", dSet);

            
        }

        private void AdvancedDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdvancedDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Trademarks.ID, Trademarks.ApplicationDate, Trademarks.StatusCode, Trademarks.ApplicantId, Trademarks.RepresentativeId, Trademarks.OppositionNumber, Trademarks.OppositionDate, Applicants.OrganizationName, Countries.CountryName, Applicants.Email, Trademarks.EmailSent AS Išraiška1, Languages.LanguageName AS FirstLanguage, Languages_1.LanguageName AS SecondLanguage FROM(((Countries INNER JOIN Applicants ON Countries.CountryCode = Applicants.CountryCode) INNER JOIN Trademarks ON Applicants.ID = Trademarks.ApplicantId) LEFT JOIN Languages ON Trademarks.FirstLanguage = Languages.LanguageCode) LEFT JOIN Languages AS Languages_1 ON Trademarks.SecondLanguage = Languages_1.LanguageCode WHERE(((Trademarks.ApplicantId)Is Not Null) AND((Trademarks.RepresentativeId)Is Null)) ORDER BY Trademarks.ApplicationDate DESC;";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //string query = "SELECT ID, APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE FROM TRADEMARKS"; // , APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            da.Fill(dt);
            advancedDataGridView2.DataSource = dt;

            //checkConnection.Text = "veikia";
            connection.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            String query = "SELECT Trademarks.ID, Trademarks.ApplicationDate, Trademarks.StatusCode, Trademarks.ApplicantId, Trademarks.RepresentativeId, Trademarks.OppositionNumber, Trademarks.OppositionDate, Applicants.OrganizationName, Countries.CountryName, Applicants.Email, Trademarks.EmailSent AS Išraiška1, Languages.LanguageName AS FirstLanguage, Languages_1.LanguageName AS SecondLanguage FROM(((Countries INNER JOIN Applicants ON Countries.CountryCode = Applicants.CountryCode) INNER JOIN Trademarks ON Applicants.ID = Trademarks.ApplicantId) LEFT JOIN Languages ON Trademarks.FirstLanguage = Languages.LanguageCode) LEFT JOIN Languages AS Languages_1 ON Trademarks.SecondLanguage = Languages_1.LanguageCode WHERE(((Trademarks.ApplicantId)Is Not Null) AND((Trademarks.RepresentativeId)Is Null) AND((Countries.CountryCode)In('AT', 'BE', 'BG', 'CY', 'HR', 'CZ', 'DK', 'EE', 'EM', 'FI', 'FR', 'DE', 'GR', 'HU', 'IE', 'IT', 'LV', 'LT', 'LU', 'MT', 'NL', 'PL', 'PT', 'RO', 'SK', 'SI', 'ES', 'SE', 'GB'))) ORDER BY Trademarks.ApplicationDate DESC;";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //string query = "SELECT ID, APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE FROM TRADEMARKS"; // , APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            da.Fill(dt);
            advancedDataGridView2.DataSource = dt;

            //checkConnection.Text = "veikia";
            connection.Close();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            String query = "SELECT Trademarks.ID, Trademarks.ApplicationDate, Trademarks.StatusCode, Trademarks.ApplicantId, Trademarks.RepresentativeId, Trademarks.OppositionNumber, Trademarks.OppositionDate, Applicants.OrganizationName, Countries.CountryName, Applicants.Email, Trademarks.EmailSent AS Išraiška1, Languages.LanguageName AS FirstLanguage, Languages_1.LanguageName AS SecondLanguage FROM(((Countries INNER JOIN Applicants ON Countries.CountryCode = Applicants.CountryCode) INNER JOIN Trademarks ON Applicants.ID = Trademarks.ApplicantId) LEFT JOIN Languages ON Trademarks.FirstLanguage = Languages.LanguageCode) LEFT JOIN Languages AS Languages_1 ON Trademarks.SecondLanguage = Languages_1.LanguageCode WHERE(((Trademarks.ApplicantId)Is Not Null) AND((Trademarks.RepresentativeId)Is Null) AND((Countries.CountryCode)Not In('AT', 'BE', 'BG', 'CY', 'HR', 'CZ', 'DK', 'EE', 'EM', 'FI', 'FR', 'DE', 'GR', 'HU', 'IE', 'IT', 'LV', 'LT', 'LU', 'MT', 'NL', 'PL', 'PT', 'RO', 'SK', 'SI', 'ES', 'SE', 'GB'))) ORDER BY Trademarks.ApplicationDate DESC;";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //string query = "SELECT ID, APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE FROM TRADEMARKS"; // , APPLICATIONDATE, STATUSCODE, APPLICANTID, REPRESENTATIVEID, OPPOSITIONNUMBER, OPPOSITIONDATE, FIRSTLANGUAGE, SECONDLANGUAGE
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            da.Fill(dt);
            advancedDataGridView2.DataSource = dt;

            //checkConnection.Text = "veikia";
            connection.Close();
        }
    }
}
