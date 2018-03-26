namespace LW09_10
{
    partial class FormParamsInstr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParamsInstr));
            this.dataSet1 = new LW09_10.DataSet1();
            this.params_instrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.params_instrTableAdapter = new LW09_10.DataSet1TableAdapters.params_instrTableAdapter();
            this.tableAdapterManager = new LW09_10.DataSet1TableAdapters.TableAdapterManager();
            this.params_instrBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.params_instrBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.params_instrDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentsTableAdapter = new LW09_10.DataSet1TableAdapters.InstrumentsTableAdapter();
            this.paramsTableAdapter = new LW09_10.DataSet1TableAdapters.paramsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.params_instrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.params_instrBindingNavigator)).BeginInit();
            this.params_instrBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.params_instrDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // params_instrBindingSource
            // 
            this.params_instrBindingSource.DataMember = "params_instr";
            this.params_instrBindingSource.DataSource = this.dataSet1;
            // 
            // params_instrTableAdapter
            // 
            this.params_instrTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.InstrumentsTableAdapter = null;
            this.tableAdapterManager.params_instrTableAdapter = this.params_instrTableAdapter;
            this.tableAdapterManager.paramsTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LW09_10.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // params_instrBindingNavigator
            // 
            this.params_instrBindingNavigator.AddNewItem = null;
            this.params_instrBindingNavigator.BindingSource = this.params_instrBindingSource;
            this.params_instrBindingNavigator.CountItem = null;
            this.params_instrBindingNavigator.DeleteItem = null;
            this.params_instrBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.params_instrBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.params_instrBindingNavigatorSaveItem});
            this.params_instrBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.params_instrBindingNavigator.MoveFirstItem = null;
            this.params_instrBindingNavigator.MoveLastItem = null;
            this.params_instrBindingNavigator.MoveNextItem = null;
            this.params_instrBindingNavigator.MovePreviousItem = null;
            this.params_instrBindingNavigator.Name = "params_instrBindingNavigator";
            this.params_instrBindingNavigator.PositionItem = null;
            this.params_instrBindingNavigator.Size = new System.Drawing.Size(829, 27);
            this.params_instrBindingNavigator.TabIndex = 0;
            this.params_instrBindingNavigator.Text = "bindingNavigator1";
            // 
            // params_instrBindingNavigatorSaveItem
            // 
            this.params_instrBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.params_instrBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("params_instrBindingNavigatorSaveItem.Image")));
            this.params_instrBindingNavigatorSaveItem.Name = "params_instrBindingNavigatorSaveItem";
            this.params_instrBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.params_instrBindingNavigatorSaveItem.Text = "Save Data";
            this.params_instrBindingNavigatorSaveItem.Click += new System.EventHandler(this.params_instrBindingNavigatorSaveItem_Click);
            // 
            // params_instrDataGridView
            // 
            this.params_instrDataGridView.AllowUserToAddRows = false;
            this.params_instrDataGridView.AutoGenerateColumns = false;
            this.params_instrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.params_instrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.params_instrDataGridView.DataSource = this.params_instrBindingSource;
            this.params_instrDataGridView.Location = new System.Drawing.Point(16, 34);
            this.params_instrDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.params_instrDataGridView.Name = "params_instrDataGridView";
            this.params_instrDataGridView.ReadOnly = true;
            this.params_instrDataGridView.Size = new System.Drawing.Size(457, 271);
            this.params_instrDataGridView.TabIndex = 1;
            this.params_instrDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.params_instrDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_instr";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_instr";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_par";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_par";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "value";
            this.dataGridViewTextBoxColumn3.HeaderText = "value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 33);
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
            this.label1.Location = new System.Drawing.Point(483, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "id_instr";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "id_par";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "value";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 110);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.instrumentsBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id";
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.paramsBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(548, 73);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "id_par";
            // 
            // paramsBindingSource
            // 
            this.paramsBindingSource.DataMember = "params";
            this.paramsBindingSource.DataSource = this.dataSet1;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // paramsTableAdapter
            // 
            this.paramsTableAdapter.ClearBeforeFill = true;
            // 
            // FormParamsInstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 315);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.params_instrDataGridView);
            this.Controls.Add(this.params_instrBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormParamsInstr";
            this.Text = "FormParamsInstr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParamsInstr_FormClosing);
            this.Load += new System.EventHandler(this.FormParamsInstr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.params_instrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.params_instrBindingNavigator)).EndInit();
            this.params_instrBindingNavigator.ResumeLayout(false);
            this.params_instrBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.params_instrDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource params_instrBindingSource;
        private DataSet1TableAdapters.params_instrTableAdapter params_instrTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator params_instrBindingNavigator;
        private System.Windows.Forms.ToolStripButton params_instrBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView params_instrDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource instrumentsBindingSource;
        private DataSet1TableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.BindingSource paramsBindingSource;
        private DataSet1TableAdapters.paramsTableAdapter paramsTableAdapter;
    }
}