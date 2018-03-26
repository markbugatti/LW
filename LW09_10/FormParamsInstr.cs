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
    public partial class FormParamsInstr : Form
    {
        public FormParamsInstr()
        {
            InitializeComponent();
        }

        private void params_instrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.params_instrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormParamsInstr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1._params' table. You can move, or remove it, as needed.
            this.paramsTableAdapter.Fill(this.dataSet1._params);
            // TODO: This line of code loads data into the 'dataSet1.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter.Fill(this.dataSet1.Instruments);
            // TODO: This line of code loads data into the 'dataSet1.params_instr' table. You can move, or remove it, as needed.
            this.params_instrTableAdapter.Fill(this.dataSet1.params_instr);
            try
            {
                showRow(0);
            }
            catch { }
        }

        private bool pkExist()
        {
            DataRow dataRow1 = dataSet1.Tables["params_instr"].Rows.Find(comboBox1.Text);
            DataRow dataRow2 = dataSet1.Tables["params_instr"].Rows.Find(comboBox2.Text);
            return (dataRow1 != null && dataRow1 != null);
        }

        private bool fldsFull()
        {
            return (textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fldsFull())
            {
                try
                {
                    if (!pkExist())
                    {
                        DataRow dataRow = dataSet1.Tables["params_instr"].NewRow();
                        dataRow["Id_instr"] = comboBox1.Text;
                        dataRow["id_par"] = comboBox2.Text;
                        dataRow["value"] = textBox1.Text;
                        dataSet1.Tables["params_instr"].Rows.Add(dataRow);
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
                        DataRow[] dataRow = dataSet1.Tables["params_instr"].Select("Id_instr = '" + comboBox1.Text + " ' ");
                        dataRow[0]["Id_instr"] = comboBox1.Text;
                        dataRow[0]["id_par"] = comboBox2.Text;
                        dataRow[0]["value"] = textBox1.Text;
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
                dataSet1.Tables["params_instr"].Rows[params_instrBindingSource.Position].Delete();
            }
            catch { }
        }

        private void FormParamsInstr_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in dataSet1.Tables["params_instr"].Rows)
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
            DataRow dataRow = dataSet1.Tables["params_instr"].Rows[i];
            textBox1.Text = dataRow["value"].ToString();
            DataRow[] dataRows = dataSet1.Instruments.Select("id = '" + dataRow["id_instr"].ToString() + "'");
            comboBox1.SelectedIndex = comboBox1.FindString(dataRows[0]["name"].ToString());
            dataRows = dataSet1._params.Select("id_par = '" + dataRow["id_par"].ToString() + "'");
            comboBox1.SelectedIndex = comboBox1.FindString(dataRows[0]["name"].ToString());
        }

        private void params_instrDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
