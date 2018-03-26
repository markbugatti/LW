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
    public partial class FormCountry : Form
    {
        public FormCountry()
        {
            InitializeComponent();
        }

        private void save()
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void FormCountry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.dataSet1.Country);
            showRow(0);
            sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            //sqlCom = new SqlCommand();
            foreach (DataColumn item in dataSet1.Country.Columns)
            {
                string str = item.ColumnName;
                comboBox1.Items.Add(str);
            }
            if (dataSet1.Country.Columns.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        public bool pkExist()
        {
            DataRow dataRow = dataSet1.Tables["Country"].Rows.Find(textBox1.Text);
            return dataRow == null ? false : true;
        }

        public bool fldsFull()
        {
            return (textBox1.Text != "" && textBox2.Text != ""); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (!pkExist())
                    {
                        DataRow dataRow = dataSet1.Tables["Country"].NewRow();
                        dataRow["Id"] = textBox1.Text;
                        dataRow["Name"] = textBox2.Text;
                        dataSet1.Tables["Country"].Rows.Add(dataRow);
                        save();
                        updateAll();
                    }
                    else
                    {
                        MessageBox.Show("this index already exist");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (pkExist())
                    {
                        DataRow[] dataRow = dataSet1.Tables["Country"].Select("id = '" + textBox1.Text + " ' ");
                        dataRow[0]["id"] = textBox1.Text;
                        dataRow[0]["Name"] = textBox2.Text;
                        updateAll();
                        save();
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

        public void updateAll ()
        {
            if (formInstruments != null)
                formInstruments.Refill();
            if (formProducer != null)
                formProducer.Refill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                sqlTransaction = sqlCon.BeginTransaction();
                string command1 = "delete from producer where country = " + textBox1.Text;
                SqlCommand sqlCommand1 = new SqlCommand(command1, sqlCon);

                string command2 = "delete from instruments where country = " + textBox1.Text;
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlCon);

                string command3 = "delete from country where id = " + textBox1.Text;
                SqlCommand sqlCommand3 = new SqlCommand(command3, sqlCon);

                sqlCommand1.Transaction = sqlTransaction;
                sqlCommand2.Transaction = sqlTransaction;
                sqlCommand3.Transaction = sqlTransaction;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand2.ExecuteNonQuery();
                sqlCommand3.ExecuteNonQuery();
                
                sqlTransaction.Commit();

                this.countryTableAdapter.Fill(this.dataSet1.Country);

                sqlCon.Close();
                showRow(0);
                save();
                updateAll();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                sqlTransaction.Rollback();
                sqlCon.Close();
            }

        }

        private void FormCountry_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in dataSet1.Tables["Country"].Rows)
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
            if (countryDataGridView.Rows.Count > 0)
            {
                try
                {
                    DataRow dataRow = dataSet1.Tables["Country"].Rows[i];
                    textBox1.Text = dataRow["id"].ToString();
                    textBox2.Text = dataRow["name"].ToString();
                }
                catch
                {
                }
            }
        }

        private void countryDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showRow(e.RowIndex);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Text != "")
            {
                try
                {
                    sqlCon.Open();
                    string command1 = "select * from country where " + comboBox1.SelectedItem +" like '" + textBox3.Text + "%'";
                    SqlCommand sqlCommand1 = new SqlCommand(command1, sqlCon);
                    SqlDataAdapter sqlDataAdapter;
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter = new SqlDataAdapter(command1, sqlCon);
                    sqlDataAdapter.Fill(dataSet);
                    countryDataGridView.DataSource = dataSet.Tables[0];
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
                countryDataGridView.DataSource = countryBindingSource;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = dataSet1.Country.Rows.Find(textBox4.Text);
                if (dr != null)
                {
                    MessageBox.Show(dr["name"].ToString());
                }
                else
                {

                  
                   // countryDataGridView.DataSource = dataSet.Tables[0];
                    MessageBox.Show("index does not exist");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sort field has wrong types");
            }
        }
    }
}