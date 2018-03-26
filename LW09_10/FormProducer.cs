using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW09_10
{
    public partial class FormProducer : Form
    {
        public FormProducer()
        {
            InitializeComponent();
        }

        private void producerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        public void Refill()
        {
            // TODO: This line of code loads data into the 'dataSet1.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter.Fill(this.dataSet1.Instruments);
            // todo: this line of code loads data into the 'dataset1.country' table. you can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.dataSet1.Country);
            // TODO: This line of code loads data into the 'dataSet1.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.dataSet1.Producer);
        }

        private void FormProducer_Load(object sender, EventArgs e)
        {
            Refill();
            try
            {
                showRow(0);
            }
            catch { }
        }

        private bool pkExist()
        {
            DataRow dataRow = dataSet1.Tables["Producer"].Rows.Find(textBox1.Text);
            return dataRow == null ? false : true;
        }

        private bool fldsFull()
        {
            return (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (!pkExist())
                    {
                        DataRow dataRow = dataSet1.Tables["Producer"].NewRow();
                        dataRow["Id"] = textBox1.Text;
                        dataRow["name"] = textBox2.Text;
                        DataRow[] rows = dataSet1.Country.Select("name = '" + comboBox1.Text + "'");
                        dataRow["Country"] = rows[0]["id"];
                        dataSet1.Tables["Producer"].Rows.Add(dataRow);
                        producerBindingNavigatorSaveItem_Click(null, null);
                        formInstruments.Refill(); 
                    }
                    else
                    {
                        MessageBox.Show("this index already exist");
                    }
                }
                catch
                {
                    MessageBox.Show("some of fields has wrong types");
                }
            }
            else
            {
                MessageBox.Show("some of field is empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (pkExist())
                    {
                        DataRow[] dataRow = dataSet1.Tables["Producer"].Select("id = '" + textBox1.Text + " ' ");
                        dataRow[0]["id"] = textBox1.Text;
                        dataRow[0]["name"] = textBox2.Text;
                        DataRow[] rows = dataSet1.Country.Select("name = '" + comboBox1.Text + "'");
                        dataRow[0]["country"] = rows[0]["id"];
                    }
                    else
                    {
                        MessageBox.Show("this index does not exist");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("some of fields has wrong types");
                }
            }
            else
            {
                MessageBox.Show("some of field is empty");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if(producerBindingSource.Position > -1)
            try
            {
                dataSet1.Tables["Producer"].Rows[producerBindingSource.Position].Delete();
            }
            catch { }
        }

        private void FormProducer_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in dataSet1.Tables["Producer"].Rows)
            {
                if (dr.RowState != DataRowState.Unchanged)
                {
                    MessageBox.Show("SaveMe");
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void showRow(int i)
        {
            DataRow dataRow = dataSet1.Tables["Producer"].Rows[i];
            textBox1.Text = dataRow["id"].ToString();
            textBox2.Text = dataRow["name"].ToString();
            DataRow[] dataRows = dataSet1.Country.Select("id = '" + dataRow["country"].ToString() + "'");
            comboBox1.SelectedIndex = comboBox1.FindString(dataRows[0]["name"].ToString());
        }

        private void producerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                showRow(e.RowIndex);
            }
            catch
            {
                MessageBox.Show("Out of range");
            }
        }
    }
}
