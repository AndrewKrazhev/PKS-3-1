﻿namespace PKS_3_1
{
    partial class Form3
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
            System.Windows.Forms.Label deloNameLabel;
            System.Windows.Forms.Label deloDescLabel;
            System.Windows.Forms.Label deloBeginLabel;
            System.Windows.Forms.Label deloEndLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.arhiveDataSet = new PKS_3_1.ArhiveDataSet();
            this.delaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delaTableAdapter = new PKS_3_1.ArhiveDataSetTableAdapters.DelaTableAdapter();
            this.tableAdapterManager = new PKS_3_1.ArhiveDataSetTableAdapters.TableAdapterManager();
            this.delaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.delaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deloEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deloBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deloDescTextBox = new System.Windows.Forms.TextBox();
            this.deloNameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.opisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opisTableAdapter = new PKS_3_1.ArhiveDataSetTableAdapters.OpisTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            deloNameLabel = new System.Windows.Forms.Label();
            deloDescLabel = new System.Windows.Forms.Label();
            deloBeginLabel = new System.Windows.Forms.Label();
            deloEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingNavigator)).BeginInit();
            this.delaBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deloNameLabel
            // 
            deloNameLabel.AutoSize = true;
            deloNameLabel.Location = new System.Drawing.Point(9, 22);
            deloNameLabel.Name = "deloNameLabel";
            deloNameLabel.Size = new System.Drawing.Size(63, 13);
            deloNameLabel.TabIndex = 0;
            deloNameLabel.Text = "Delo Name:";
            // 
            // deloDescLabel
            // 
            deloDescLabel.AutoSize = true;
            deloDescLabel.Location = new System.Drawing.Point(12, 48);
            deloDescLabel.Name = "deloDescLabel";
            deloDescLabel.Size = new System.Drawing.Size(60, 13);
            deloDescLabel.TabIndex = 2;
            deloDescLabel.Text = "Delo Desc:";
            // 
            // deloBeginLabel
            // 
            deloBeginLabel.AutoSize = true;
            deloBeginLabel.Location = new System.Drawing.Point(10, 75);
            deloBeginLabel.Name = "deloBeginLabel";
            deloBeginLabel.Size = new System.Drawing.Size(62, 13);
            deloBeginLabel.TabIndex = 4;
            deloBeginLabel.Text = "Delo Begin:";
            // 
            // deloEndLabel
            // 
            deloEndLabel.AutoSize = true;
            deloEndLabel.Location = new System.Drawing.Point(18, 101);
            deloEndLabel.Name = "deloEndLabel";
            deloEndLabel.Size = new System.Drawing.Size(54, 13);
            deloEndLabel.TabIndex = 6;
            deloEndLabel.Text = "Delo End:";
            // 
            // arhiveDataSet
            // 
            this.arhiveDataSet.DataSetName = "ArhiveDataSet";
            this.arhiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delaBindingSource
            // 
            this.delaBindingSource.DataMember = "Dela";
            this.delaBindingSource.DataSource = this.arhiveDataSet;
            // 
            // delaTableAdapter
            // 
            this.delaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DelaTableAdapter = this.delaTableAdapter;
            this.tableAdapterManager.FondsTableAdapter = null;
            this.tableAdapterManager.OpisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PKS_3_1.ArhiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // delaBindingNavigator
            // 
            this.delaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.delaBindingNavigator.BindingSource = this.delaBindingSource;
            this.delaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.delaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.delaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.delaBindingNavigatorSaveItem});
            this.delaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.delaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.delaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.delaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.delaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.delaBindingNavigator.Name = "delaBindingNavigator";
            this.delaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.delaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.delaBindingNavigator.TabIndex = 0;
            this.delaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // delaBindingNavigatorSaveItem
            // 
            this.delaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("delaBindingNavigatorSaveItem.Image")));
            this.delaBindingNavigatorSaveItem.Name = "delaBindingNavigatorSaveItem";
            this.delaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.delaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.delaBindingNavigatorSaveItem.Click += new System.EventHandler(this.delaBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delaDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(209, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дела";
            // 
            // delaDataGridView
            // 
            this.delaDataGridView.AutoGenerateColumns = false;
            this.delaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.delaDataGridView.DataSource = this.delaBindingSource;
            this.delaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delaDataGridView.Location = new System.Drawing.Point(3, 16);
            this.delaDataGridView.Name = "delaDataGridView";
            this.delaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.delaDataGridView.Size = new System.Drawing.Size(585, 443);
            this.delaDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeloName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DeloName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DeloDesc";
            this.dataGridViewTextBoxColumn3.HeaderText = "DeloDesc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DeloBegin";
            this.dataGridViewTextBoxColumn4.HeaderText = "DeloBegin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DeloEnd";
            this.dataGridViewTextBoxColumn5.HeaderText = "DeloEnd";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FondNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "FondNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OpisNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "OpisNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(deloEndLabel);
            this.groupBox2.Controls.Add(this.deloEndDateTimePicker);
            this.groupBox2.Controls.Add(deloBeginLabel);
            this.groupBox2.Controls.Add(this.deloBeginDateTimePicker);
            this.groupBox2.Controls.Add(deloDescLabel);
            this.groupBox2.Controls.Add(this.deloDescTextBox);
            this.groupBox2.Controls.Add(deloNameLabel);
            this.groupBox2.Controls.Add(this.deloNameTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 462);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактиование";
            // 
            // deloEndDateTimePicker
            // 
            this.deloEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.delaBindingSource, "DeloEnd", true));
            this.deloEndDateTimePicker.Location = new System.Drawing.Point(78, 97);
            this.deloEndDateTimePicker.Name = "deloEndDateTimePicker";
            this.deloEndDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.deloEndDateTimePicker.TabIndex = 7;
            // 
            // deloBeginDateTimePicker
            // 
            this.deloBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.delaBindingSource, "DeloBegin", true));
            this.deloBeginDateTimePicker.Location = new System.Drawing.Point(78, 71);
            this.deloBeginDateTimePicker.Name = "deloBeginDateTimePicker";
            this.deloBeginDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.deloBeginDateTimePicker.TabIndex = 5;
            // 
            // deloDescTextBox
            // 
            this.deloDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delaBindingSource, "DeloDesc", true));
            this.deloDescTextBox.Location = new System.Drawing.Point(78, 45);
            this.deloDescTextBox.Name = "deloDescTextBox";
            this.deloDescTextBox.Size = new System.Drawing.Size(121, 20);
            this.deloDescTextBox.TabIndex = 3;
            // 
            // deloNameTextBox
            // 
            this.deloNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delaBindingSource, "DeloName", true));
            this.deloNameTextBox.Location = new System.Drawing.Point(78, 19);
            this.deloNameTextBox.Name = "deloNameTextBox";
            this.deloNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.deloNameTextBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.delaBindingSource, "OpisNumber", true));
            this.comboBox1.DataSource = this.opisBindingSource;
            this.comboBox1.DisplayMember = "OpisName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            // 
            // opisBindingSource
            // 
            this.opisBindingSource.DataMember = "Opis";
            this.opisBindingSource.DataSource = this.arhiveDataSet;
            // 
            // opisTableAdapter
            // 
            this.opisTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.delaBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingNavigator)).EndInit();
            this.delaBindingNavigator.ResumeLayout(false);
            this.delaBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delaDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArhiveDataSet arhiveDataSet;
        private System.Windows.Forms.BindingSource delaBindingSource;
        private ArhiveDataSetTableAdapters.DelaTableAdapter delaTableAdapter;
        private ArhiveDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator delaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton delaBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView delaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker deloEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker deloBeginDateTimePicker;
        private System.Windows.Forms.TextBox deloDescTextBox;
        private System.Windows.Forms.TextBox deloNameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource opisBindingSource;
        private ArhiveDataSetTableAdapters.OpisTableAdapter opisTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}