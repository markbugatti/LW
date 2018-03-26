using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW09_10
{
    public partial class FormParams : Form
    {
        public FormParams()
        {
            InitializeComponent();
        }

        private void paramsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paramsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormParams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1._params' table. You can move, or remove it, as needed.
            this.paramsTableAdapter.Fill(this.dataSet1._params);

        }

        public bool pkExist()
        {
            DataRow dataRow = dataSet1.Tables["Params"].Rows.Find(textBox1.Text);
            return dataRow == null ? false : true;
        }

        public bool fldsFull()
        {
            return (textBox1.Text != "" && textBox2.Text != "" &&  textBox3.Text != "" && textBox4.Text != "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (!pkExist())
                    {
                        DataRow dataRow = dataSet1.Tables["Params"].NewRow();
                        dataRow["Id_par"] = textBox1.Text;
                        dataRow["Name"] = textBox2.Text;
                        dataRow["measure"] = textBox3.Text;
                        dataRow["desc"] = textBox4.Text;
                        dataSet1.Tables["Params"].Rows.Add(dataRow);
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
                        DataRow[] dataRow = dataSet1.Tables["Params"].Select("Id_par = '" + textBox1.Text + " ' ");
                        dataRow[0]["Id_par"] = textBox1.Text;
                        dataRow[0]["Name"] = textBox2.Text;
                        dataRow[0]["measure"] = textBox3.Text;
                        dataRow[0]["desc"] = textBox4.Text;
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
                dataSet1.Tables["Params"].Rows[paramsBindingSource.Position].Delete();
            }
            catch { }
        }

        private void FormParams_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in dataSet1.Tables["Params"].Rows)
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
            DataRow dataRow = dataSet1.Tables["Params"].Rows[i];
            textBox1.Text = dataRow["id_par"].ToString();
            textBox2.Text = dataRow["name"].ToString();
            textBox3.Text = dataRow["measure"].ToString();
            textBox4.Text = dataRow["desc"].ToString();
        }

        private void paramsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
