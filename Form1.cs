﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenseMeasureImporter
{
    public partial class SenseImporter : Form
    {
        private CancellationTokenSource token = new CancellationTokenSource();   
        private int definitionColumnIndex = 4;
        private QlikAPIS qlik;
        private string appId;

        public SenseImporter()
        {            
            InitializeComponent();
            Connect();
        }

        private void Connect()
        {
            try
            {
                qlik = new QlikAPIS();
                var apps = qlik.GetAppList();
                listBox1.DataSource = apps;
                listBox1.DisplayMember = "AppName";
                listBox1.ValueMember = "AppId";
                btnConnect.Hide();
                btnCreateMeasures.Enabled = true;
                btnFile.Enabled = true;
                cmbSheets.Enabled = true;
            }
            catch (Exception ex)
            {
                connectionLost(ex, "Error connecting to the sense API");
            }
        }

        private void connectionLost(Exception ex, string title)
        {
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnConnect.Show();
            btnCreateMeasures.Enabled = false;
            btnFile.Enabled = false;
            cmbSheets.Enabled = false;
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.xls|*.xls|*.csv|*.csv";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var file = openFileDialog1.FileName;         
            lblFile.Text = file;
            lblFile.Show();
            var excel = new LinqToExcel.ExcelQueryFactory(openFileDialog1.FileName);

            if (file.Substring(file.Length - 3) == "csv")
            {
                dataGridView1.DataSource = excel.Worksheet<measure>().ToList();
            }
            else
            {
                cmbSheets.DataSource = excel.GetWorksheetNames().ToList();   
            }
                  
        }

        private async void checkMeasures(int index = -1)
        {
            var measures = new List<measure>();

            if (index == -1)
            {
                measures = dataGridView1.DataSource as List<measure>;
            }
            else
            {
                measures.Add((dataGridView1.DataSource as List<measure>)[index]);                
            }

            if (measures != null)
            {
                try
                {                                   
                    token.Cancel();
                    token.Dispose();
                    token = new CancellationTokenSource();
          
                    await Task.Run(() => qlik.CheckMeasures(appId, measures, token));
                                        
                    if (measures.Where(f => f.useMeasure).Count() == 0)
                    {
                        btnCheckUncheck.Text = "Check All";
                    }
                    else
                    {
                        btnCheckUncheck.Text = "Uncheck All";
                    }
                }
                catch (Exception ex)
                {
                    connectionLost(ex, "Error validating measures");
                }
            }
            progressBar1.Value = 0;
            Status.Text = "";
            Status.Hide();
            dataGridView1.Refresh();
        }

        private void createMeasures_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Status.Hide();
            //var taglist = new List<string>();
            List<measure> measures = dataGridView1.DataSource as List<measure>;
            int i = 0;
            if (measures != null)
            {
                foreach (var m in measures.Where(row => row.useMeasure && row.definition != null))
                {
                    try
                    {
                        qlik.SaveMeasure(appId, m.title, m.description, m.tags.Split(';').ToList(), m.definition);
                        i++;
                    }
                    catch (Exception ex)
                    {
                        connectionLost(ex, "Error creating measure");
                    }
              
                    progressBar1.Value = i / measures.Where(f => f.useMeasure).Count() * 100;
                    Status.Text = string.Format("Created {0} of {1} selected measures. Total measures in table: {2}.", i.ToString(), measures.Where(f => f.useMeasure).Count(), measures.Count().ToString());
                    Status.Show();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var excel = new LinqToExcel.ExcelQueryFactory(openFileDialog1.FileName);
            dataGridView1.DataSource = excel.Worksheet<measure>(cmbSheets.SelectedValue.ToString()).ToList();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                appId = listBox1.SelectedValue.ToString();
                checkMeasures();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == definitionColumnIndex)
            {
                checkMeasures(e.RowIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            appId = listBox1.SelectedValue.ToString();
            checkMeasures();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnCheckUncheck_Click(object sender, EventArgs e)
        {
            List<measure> measures = dataGridView1.DataSource as List<measure>;

            if (btnCheckUncheck.Text == "Uncheck All" && measures.Where(f => f.useMeasure).Count() > 0)
            {
                foreach (var m in measures)
                {
                    m.useMeasure = false;
                }
                btnCheckUncheck.Text = "Check All";
            }
            else
            {
                foreach (var m in measures)
                {
                    m.useMeasure = true;
                }
                btnCheckUncheck.Text = "Uncheck All";
            }

            dataGridView1.Refresh();

        }
    }
}
