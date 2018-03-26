namespace LW09_10
{
    partial class FormProducer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducer));
            this.dataSet1 = new LW09_10.DataSet1();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new LW09_10.DataSet1TableAdapters.ProducerTableAdapter();
            this.tableAdapterManager = new LW09_10.DataSet1TableAdapters.TableAdapterManager();
            this.producerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.producerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.producerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new LW09_10.DataSet1TableAdapters.CountryTableAdapter();
            this.instrumentsTableAdapter = new LW09_10.DataSet1TableAdapters.InstrumentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingNavigator)).BeginInit();
            this.producerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.dataSet1;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.InstrumentsTableAdapter = null;
            this.tableAdapterManager.params_instrTableAdapter = null;
            this.tableAdapterManager.paramsTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = this.producerTableAdapter;
            this.tableAdapterManager.UpdateOrder = LW09_10.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producerBindingNavigator
            // 
            this.producerBindingNavigator.AddNewItem = null;
            this.producerBindingNavigator.BindingSource = this.producerBindingSource;
            this.producerBindingNavigator.CountItem = null;
            this.producerBindingNavigator.DeleteItem = null;
            this.producerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.producerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.producerBindingNavigatorSaveItem});
            this.producerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.producerBindingNavigator.MoveFirstItem = null;
            this.producerBindingNavigator.MoveLastItem = null;
            this.producerBindingNavigator.MoveNextItem = null;
            this.producerBindingNavigator.MovePreviousItem = null;
            this.producerBindingNavigator.Name = "producerBindingNavigator";
            this.producerBindingNavigator.PositionItem = null;
            this.producerBindingNavigator.Size = new System.Drawing.Size(812, 27);
            this.producerBindingNavigator.TabIndex = 0;
            this.producerBindingNavigator.Text = "bindingNavigator1";
            // 
            // producerBindingNavigatorSaveItem
            // 
            this.producerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.producerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("producerBindingNavigatorSaveItem.Image")));
            this.producerBindingNavigatorSaveItem.Name = "producerBindingNavigatorSaveItem";
            this.producerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.producerBindingNavigatorSaveItem.Text = "Save Data";
            this.producerBindingNavigatorSaveItem.Click += new System.EventHandler(this.producerBindingNavigatorSaveItem_Click);
            // 
            // producerDataGridView
            // 
            this.producerDataGridView.AllowUserToAddRows = false;
            this.producerDataGridView.AutoGenerateColumns = false;
            this.producerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.producerDataGridView.DataSource = this.producerBindingSource;
            this.producerDataGridView.Location = new System.Drawing.Point(0, 34);
            this.producerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.producerDataGridView.Name = "producerDataGridView";
            this.producerDataGridView.ReadOnly = true;
            this.producerDataGridView.Size = new System.Drawing.Size(465, 271);
            this.producerDataGridView.TabIndex = 1;
            this.producerDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.producerDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn3.HeaderText = "country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(532, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(532, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "country";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(701, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.countryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.dataSet1;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 313);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.producerDataGridView);
            this.Controls.Add(this.producerBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProducer";
            this.Text = "FormProducer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProducer_FormClosing);
            this.Load += new System.EventHandler(this.FormProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingNavigator)).EndInit();
            this.producerBindingNavigator.ResumeLayout(false);
            this.producerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private DataSet1TableAdapters.ProducerTableAdapter producerTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator producerBindingNavigator;
        private System.Windows.Forms.ToolStripButton producerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView producerDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private DataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
        private DataSet1TableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public FormInstruments formInstruments;
        public FormCountry formCountry;

    }
}