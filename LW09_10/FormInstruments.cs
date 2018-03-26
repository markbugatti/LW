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
    public partial class FormInstruments : Form
    {
        public FormInstruments()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        }
        FormCountry formCountry;
        FormProducer formProducer;
        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCountry = new FormCountry();
            formCountry.formInstruments = this;
            //if (formCountry != null)
            //    formProducer.formCountry = formCountry;
            formCountry.Visible = true;
        }

        private void producerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducer = new FormProducer();
            formProducer.formInstruments = this;

            formProducer.Visible = true;
        }

        private void paramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParams form = new FormParams();
            form.Visible = true;
        }

        private void paramsInstrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParamsInstr form = new FormParamsInstr();
            form.Visible = true;
        }

        private void instrumentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instrumentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        public void Refill()
        {
            // TODO: This line of code loads data into the 'dataSet1.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.dataSet1.Country);
            // TODO: This line of code loads data into the 'dataSet1.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.dataSet1.Producer);
            // TODO: This line of code loads data into the 'dataSet1.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter.Fill(this.dataSet1.Instruments);
        }


        private void FormInstruments_Load(object sender, EventArgs e)
        {
            Refill();
            try
            {
                showRow(0);
            }
            catch
            {

            }
        }

        private bool pkExist()
        {
            DataRow dataRow = dataSet1.Tables["Instruments"].Rows.Find(textBox1.Text);
            return dataRow == null ? false : true;
        }

        private bool fldsFull()
        {
            return (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && comboBox1.Text != "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (!pkExist())
                    {
                        DataRow dataRow = dataSet1.Tables["Instruments"].NewRow();
                        dataRow["Id"] = textBox1.Text;
                        dataRow["Name"] = textBox2.Text;
                        dataRow["specification"] = textBox3.Text;

                        DataRow[] rows = dataSet1.Producer.Select("name = '" + comboBox1.Text + "'");
                        dataRow["producer"] = rows[0]["id"];
                        rows = dataSet1.Country.Select("name = '" + comboBox2.Text + "'");
                        dataRow["Country"] = rows[0]["id"];
                        dataSet1.Tables["Instruments"].Rows.Add(dataRow);
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
                        DataRow[] dataRow = dataSet1.Tables["Instruments"].Select("id = '" + textBox1.Text + " ' ");
                        dataRow[0]["Id"] = textBox1.Text;
                        dataRow[0]["Name"] = textBox2.Text;
                        dataRow[0]["specification"] = textBox3.Text;
                        dataRow[0]["producer"] = comboBox1.Text;
                        dataRow[0]["Country"] = comboBox2.Text;
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
            try
            {
               dataSet1.Tables["Instruments"].Rows[instrumentsBindingSource.Position].Delete();
            }
            catch { }
        }

        private void FormInstruments_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in dataSet1.Tables["Instruments"].Rows)
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
            DataRow dataRow = dataSet1.Tables["Instruments"].Rows[i];
            textBox1.Text = dataRow["id"].ToString();
            textBox2.Text = dataRow["name"].ToString();
            textBox3.Text = dataRow["specification"].ToString();
            DataRow[] dataRows = dataSet1.Producer.Select("id = '" + dataRow["producer"].ToString() + "'");
            comboBox1.SelectedIndex = comboBox1.FindString(dataRows[0]["name"].ToString());
            dataRows = dataSet1.Country.Select("id = '" + dataRow["country"].ToString() + "'");
            comboBox2.SelectedIndex = comboBox2.FindString(dataRows[0]["name"].ToString());
        }

        private void instrumentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                try
                {
                    sqlCon.Open();
                    string command1 = "select * from instruments where name like '" + textBox4.Text + "%'";
                    SqlCommand sqlCommand1 = new SqlCommand(command1, sqlCon);
                    SqlDataAdapter sqlDataAdapter;
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter = new SqlDataAdapter(command1, sqlCon);
                    sqlDataAdapter.Fill(dataSet);
                    instrumentsDataGridView.DataSource = dataSet.Tables[0];
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlCon.Close();
                }
            }
            else
            {
                instrumentsDataGridView.DataSource = instrumentsBindingSource;
            }
        }
    }
}
