namespace LW09_10
{
    partial class FormParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParams));
            this.dataSet1 = new LW09_10.DataSet1();
            this.paramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paramsTableAdapter = new LW09_10.DataSet1TableAdapters.paramsTableAdapter();
            this.tableAdapterManager = new LW09_10.DataSet1TableAdapters.TableAdapterManager();
            this.paramsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.paramsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paramsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsBindingNavigator)).BeginInit();
            this.paramsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paramsBindingSource
            // 
            this.paramsBindingSource.DataMember = "params";
            this.paramsBindingSource.DataSource = this.dataSet1;
            // 
            // paramsTableAdapter
            // 
            this.paramsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.InstrumentsTableAdapter = null;
            this.tableAdapterManager.params_instrTableAdapter = null;
            this.tableAdapterManager.paramsTableAdapter = this.paramsTableAdapter;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LW09_10.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paramsBindingNavigator
            // 
            this.paramsBindingNavigator.AddNewItem = null;
            this.paramsBindingNavigator.BindingSource = this.paramsBindingSource;
            this.paramsBindingNavigator.CountItem = null;
            this.paramsBindingNavigator.DeleteItem = null;
            this.paramsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.paramsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramsBindingNavigatorSaveItem});
            this.paramsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paramsBindingNavigator.MoveFirstItem = null;
            this.paramsBindingNavigator.MoveLastItem = null;
            this.paramsBindingNavigator.MoveNextItem = null;
            this.paramsBindingNavigator.MovePreviousItem = null;
            this.paramsBindingNavigator.Name = "paramsBindingNavigator";
            this.paramsBindingNavigator.PositionItem = null;
            this.paramsBindingNavigator.Size = new System.Drawing.Size(948, 27);
            this.paramsBindingNavigator.TabIndex = 0;
            this.paramsBindingNavigator.Text = "bindingNavigator1";
            // 
            // paramsBindingNavigatorSaveItem
            // 
            this.paramsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paramsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paramsBindingNavigatorSaveItem.Image")));
            this.paramsBindingNavigatorSaveItem.Name = "paramsBindingNavigatorSaveItem";
            this.paramsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.paramsBindingNavigatorSaveItem.Text = "Save Data";
            this.paramsBindingNavigatorSaveItem.Click += new System.EventHandler(this.paramsBindingNavigatorSaveItem_Click);
            // 
            // paramsDataGridView
            // 
            this.paramsDataGridView.AllowUserToAddRows = false;
            this.paramsDataGridView.AutoGenerateColumns = false;
            this.paramsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paramsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.paramsDataGridView.DataSource = this.paramsBindingSource;
            this.paramsDataGridView.Location = new System.Drawing.Point(16, 34);
            this.paramsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.paramsDataGridView.Name = "paramsDataGridView";
            this.paramsDataGridView.ReadOnly = true;
            this.paramsDataGridView.Size = new System.Drawing.Size(592, 271);
            this.paramsDataGridView.TabIndex = 1;
            this.paramsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.paramsDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_par";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_par";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "measure";
            this.dataGridViewTextBoxColumn3.HeaderText = "measure";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "desc";
            this.dataGridViewTextBoxColumn4.HeaderText = "desc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "id_par";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(695, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(695, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(695, 98);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "measure";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(695, 130);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "desc";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(839, 126);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 320);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paramsDataGridView);
            this.Controls.Add(this.paramsBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormParams";
            this.Text = "FormParams";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParams_FormClosing);
            this.Load += new System.EventHandler(this.FormParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsBindingNavigator)).EndInit();
            this.paramsBindingNavigator.ResumeLayout(false);
            this.paramsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource paramsBindingSource;
        private DataSet1TableAdapters.paramsTableAdapter paramsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paramsBindingNavigator;
        private System.Windows.Forms.ToolStripButton paramsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView paramsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}