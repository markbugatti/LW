using System.Data.SqlClient;

namespace LW09_10
{
    partial class FormInstruments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruments));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsInstrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new LW09_10.DataSet1();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentsTableAdapter = new LW09_10.DataSet1TableAdapters.InstrumentsTableAdapter();
            this.tableAdapterManager = new LW09_10.DataSet1TableAdapters.TableAdapterManager();
            this.instrumentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.instrumentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.instrumentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.producerTableAdapter = new LW09_10.DataSet1TableAdapters.ProducerTableAdapter();
            this.countryTableAdapter = new LW09_10.DataSet1TableAdapters.CountryTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingNavigator)).BeginInit();
            this.instrumentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.producerToolStripMenuItem,
            this.paramsToolStripMenuItem,
            this.paramsInstrToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // producerToolStripMenuItem
            // 
            this.producerToolStripMenuItem.Name = "producerToolStripMenuItem";
            this.producerToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.producerToolStripMenuItem.Text = "Producer";
            this.producerToolStripMenuItem.Click += new System.EventHandler(this.producerToolStripMenuItem_Click);
            // 
            // paramsToolStripMenuItem
            // 
            this.paramsToolStripMenuItem.Name = "paramsToolStripMenuItem";
            this.paramsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.paramsToolStripMenuItem.Text = "Params";
            this.paramsToolStripMenuItem.Click += new System.EventHandler(this.paramsToolStripMenuItem_Click);
            // 
            // paramsInstrToolStripMenuItem
            // 
            this.paramsInstrToolStripMenuItem.Name = "paramsInstrToolStripMenuItem";
            this.paramsInstrToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.paramsInstrToolStripMenuItem.Text = "ParamsInstr";
            this.paramsInstrToolStripMenuItem.Click += new System.EventHandler(this.paramsInstrToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this.dataSet1;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.InstrumentsTableAdapter = this.instrumentsTableAdapter;
            this.tableAdapterManager.params_instrTableAdapter = null;
            this.tableAdapterManager.paramsTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LW09_10.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // instrumentsBindingNavigator
            // 
            this.instrumentsBindingNavigator.AddNewItem = null;
            this.instrumentsBindingNavigator.BindingSource = this.instrumentsBindingSource;
            this.instrumentsBindingNavigator.CountItem = null;
            this.instrumentsBindingNavigator.DeleteItem = null;
            this.instrumentsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.instrumentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentsBindingNavigatorSaveItem});
            this.instrumentsBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.instrumentsBindingNavigator.MoveFirstItem = null;
            this.instrumentsBindingNavigator.MoveLastItem = null;
            this.instrumentsBindingNavigator.MoveNextItem = null;
            this.instrumentsBindingNavigator.MovePreviousItem = null;
            this.instrumentsBindingNavigator.Name = "instrumentsBindingNavigator";
            this.instrumentsBindingNavigator.PositionItem = null;
            this.instrumentsBindingNavigator.Size = new System.Drawing.Size(1119, 27);
            this.instrumentsBindingNavigator.TabIndex = 1;
            this.instrumentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // instrumentsBindingNavigatorSaveItem
            // 
            this.instrumentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instrumentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("instrumentsBindingNavigatorSaveItem.Image")));
            this.instrumentsBindingNavigatorSaveItem.Name = "instrumentsBindingNavigatorSaveItem";
            this.instrumentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.instrumentsBindingNavigatorSaveItem.Text = "Save Data";
            this.instrumentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.instrumentsBindingNavigatorSaveItem_Click);
            // 
            // instrumentsDataGridView
            // 
            this.instrumentsDataGridView.AllowUserToAddRows = false;
            this.instrumentsDataGridView.AutoGenerateColumns = false;
            this.instrumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.instrumentsDataGridView.DataSource = this.instrumentsBindingSource;
            this.instrumentsDataGridView.Location = new System.Drawing.Point(0, 64);
            this.instrumentsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.instrumentsDataGridView.Name = "instrumentsDataGridView";
            this.instrumentsDataGridView.ReadOnly = true;
            this.instrumentsDataGridView.Size = new System.Drawing.Size(736, 286);
            this.instrumentsDataGridView.TabIndex = 2;
            this.instrumentsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.instrumentsDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "producer";
            this.dataGridViewTextBoxColumn3.HeaderText = "producer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "specification";
            this.dataGridViewTextBoxColumn4.HeaderText = "specification";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn5.HeaderText = "country";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(751, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(839, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.producerBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(839, 134);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Id";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.dataSet1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(839, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "producer";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(839, 169);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "specification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "country";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.countryBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(839, 202);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "Id";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.dataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1008, 201);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(815, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Filter";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(975, 302);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Filter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(867, 302);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FormInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.instrumentsDataGridView);
            this.Controls.Add(this.instrumentsBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInstruments";
            this.Text = "FormInstruments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInstruments_FormClosing);
            this.Load += new System.EventHandler(this.FormInstruments_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingNavigator)).EndInit();
            this.instrumentsBindingNavigator.ResumeLayout(false);
            this.instrumentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramsInstrToolStripMenuItem;
        public DataSet1 dataSet1;
        public System.Windows.Forms.BindingSource instrumentsBindingSource;
        public DataSet1TableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator instrumentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton instrumentsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView instrumentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.BindingSource producerBindingSource;
        public DataSet1TableAdapters.ProducerTableAdapter producerTableAdapter;
        public System.Windows.Forms.BindingSource countryBindingSource;
        public DataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private SqlConnection sqlCon;
        private SqlCommand sqlCom;
    }
}