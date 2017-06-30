using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Outsurance_Ass
{
    public partial class frmFileLoad : Form
    {
        private List<Data> dataList;
        private OpenFileDialog openFile = new OpenFileDialog();
        
        public frmFileLoad()
        {
            InitializeComponent();
            openFile.InitialDirectory = Path.GetFullPath(@"..\..\..\") + @"Data\";
        }

        private void btnGetFileData_Click(object sender, EventArgs e)
        {
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataList = new List<Data>();
                    string dataFileName = openFile.FileName;
                    lblName.Text = dataFileName;
                    int cnt = 0;
                    foreach (string data in File.ReadAllLines(dataFileName))
                    {
                        cnt++;
                        if (cnt == 1) continue; //Exclude Header Line
                        string[] fields = data.Split(',');
                        Data fileData = new Data();
                        fileData.FirstName = fields[0].ToString();
                        fileData.LastName = fields[1].ToString();
                        fileData.Address = fields[2].ToString();
                        fileData.PhoneNumber = fields[3].ToString();
                        dataList.Add(fileData);
                    }
                    dgViewData.DataSource = dataList;
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "Error Occurred While Loading The File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            CreateReport1();
            CreateReport2();
            lblReportLocation.Text = openFile.InitialDirectory;

            DialogResult result = MessageBox.Show("Reports created", "Reports.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateReport1 ()
        {
            //Report 1
            string reportFileName1 = openFile.InitialDirectory + "\\ReportFile1.txt";
            List<string> file1 = new List<string>();

            List<string> FirtnameLastnameList = new List<string>();
            FirtnameLastnameList.AddRange(dataList.Select(d => d.FirstName).ToList<string>());
            FirtnameLastnameList.AddRange(dataList.Select(d => d.LastName).ToList<string>());

            var list =
            FirtnameLastnameList.GroupBy(d => d)
            .OrderByDescending(d => d.Count())
            .ThenBy(d => d.Key)
            .ToDictionary(d => d.Key, d => d.Count());

            file1.Add("Frequency Descending");
            file1.Add("____________________");
            foreach (KeyValuePair<string, int> record in list)
            {
                file1.Add(record.Key + "\t" + record.Value);
            }

            file1.Add("\n");

            var list2 = list.OrderBy(d => d.Key);
            file1.Add("Alphabetically Ascending");
            file1.Add("________________________");
            foreach (KeyValuePair<string, int> record in list2)
            {
                file1.Add(record.Key + "\t" + record.Value);
            }

            File.WriteAllLines(reportFileName1, file1);
        }

        private void CreateReport2()
        {
            //Report 2
            string reportFileName2 = openFile.InitialDirectory + "\\ReportFile2.txt";
            List<string> file2 = new List<string>();

            file2.Add("Alphabetically By Street Name");
            file2.Add("_____________________________");
            List<string> AddressList = (from data in dataList
                                        orderby data.Address.Split(' ')[1] ascending
                                        select data.Address).ToList<string>();
            foreach (string record in AddressList)
            {
                file2.Add(record);
            }
            File.WriteAllLines(reportFileName2, file2);
        }
    }

    public class Data
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
