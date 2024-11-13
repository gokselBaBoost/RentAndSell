namespace RentAndSell.Car.FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            cBoxYil = new ComboBox();
            btnSave = new Button();
            cBoxSanzimanTipi = new ComboBox();
            cBoxMotorTipi = new ComboBox();
            cBoxYakitTuru = new ComboBox();
            txtModel = new TextBox();
            txtMarka = new TextBox();
            nbrUpDownYil = new NumericUpDown();
            txtYili = new TextBox();
            dgvArabaList = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motorTipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yakitTuruDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanzimanTipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arabaViewModelBindingSource = new BindingSource(components);
            txtCarId = new TextBox();
            btnRead = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrUpDownYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArabaList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arabaViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRead);
            groupBox1.Controls.Add(txtCarId);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(cBoxYil);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cBoxSanzimanTipi);
            groupBox1.Controls.Add(cBoxMotorTipi);
            groupBox1.Controls.Add(cBoxYakitTuru);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMarka);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "YENİ KAYIT";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 231);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Record ID";
            txtId.Size = new Size(102, 23);
            txtId.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(170, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(89, 202);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cBoxYil
            // 
            cBoxYil.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxYil.Location = new Point(6, 86);
            cBoxYil.Name = "cBoxYil";
            cBoxYil.Size = new Size(237, 23);
            cBoxYil.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(8, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cBoxSanzimanTipi
            // 
            cBoxSanzimanTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxSanzimanTipi.FormattingEnabled = true;
            cBoxSanzimanTipi.Location = new Point(6, 173);
            cBoxSanzimanTipi.Name = "cBoxSanzimanTipi";
            cBoxSanzimanTipi.Size = new Size(237, 23);
            cBoxSanzimanTipi.TabIndex = 5;
            // 
            // cBoxMotorTipi
            // 
            cBoxMotorTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxMotorTipi.FormattingEnabled = true;
            cBoxMotorTipi.Location = new Point(6, 144);
            cBoxMotorTipi.Name = "cBoxMotorTipi";
            cBoxMotorTipi.Size = new Size(237, 23);
            cBoxMotorTipi.TabIndex = 4;
            // 
            // cBoxYakitTuru
            // 
            cBoxYakitTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxYakitTuru.FormattingEnabled = true;
            cBoxYakitTuru.Location = new Point(6, 115);
            cBoxYakitTuru.Name = "cBoxYakitTuru";
            cBoxYakitTuru.Size = new Size(237, 23);
            cBoxYakitTuru.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(6, 57);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "Model";
            txtModel.Size = new Size(237, 23);
            txtModel.TabIndex = 1;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(6, 28);
            txtMarka.Name = "txtMarka";
            txtMarka.PlaceholderText = "Marka";
            txtMarka.Size = new Size(237, 23);
            txtMarka.TabIndex = 0;
            // 
            // nbrUpDownYil
            // 
            nbrUpDownYil.Location = new Point(12, 424);
            nbrUpDownYil.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nbrUpDownYil.Minimum = new decimal(new int[] { 1940, 0, 0, 0 });
            nbrUpDownYil.Name = "nbrUpDownYil";
            nbrUpDownYil.Size = new Size(193, 23);
            nbrUpDownYil.TabIndex = 7;
            nbrUpDownYil.Value = new decimal(new int[] { 1940, 0, 0, 0 });
            nbrUpDownYil.Visible = false;
            // 
            // txtYili
            // 
            txtYili.Location = new Point(12, 395);
            txtYili.Name = "txtYili";
            txtYili.PlaceholderText = "Yıl";
            txtYili.Size = new Size(193, 23);
            txtYili.TabIndex = 2;
            txtYili.Visible = false;
            // 
            // dgvArabaList
            // 
            dgvArabaList.AllowUserToAddRows = false;
            dgvArabaList.AllowUserToDeleteRows = false;
            dgvArabaList.AutoGenerateColumns = false;
            dgvArabaList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabaList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, motorTipiDataGridViewTextBoxColumn, yakitTuruDataGridViewTextBoxColumn, sanzimanTipiDataGridViewTextBoxColumn, yiliDataGridViewTextBoxColumn });
            dgvArabaList.DataSource = arabaViewModelBindingSource;
            dgvArabaList.Location = new Point(279, 21);
            dgvArabaList.MultiSelect = false;
            dgvArabaList.Name = "dgvArabaList";
            dgvArabaList.ReadOnly = true;
            dgvArabaList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArabaList.Size = new Size(807, 368);
            dgvArabaList.TabIndex = 1;
            dgvArabaList.CellDoubleClick += dgvArabaList_CellDoubleClick;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.ReadOnly = true;
            ıdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            ıdDataGridViewTextBoxColumn.Width = 42;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motorTipiDataGridViewTextBoxColumn
            // 
            motorTipiDataGridViewTextBoxColumn.DataPropertyName = "MotorTipi";
            motorTipiDataGridViewTextBoxColumn.HeaderText = "MotorTipi";
            motorTipiDataGridViewTextBoxColumn.Name = "motorTipiDataGridViewTextBoxColumn";
            motorTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yakitTuruDataGridViewTextBoxColumn
            // 
            yakitTuruDataGridViewTextBoxColumn.DataPropertyName = "YakitTuru";
            yakitTuruDataGridViewTextBoxColumn.HeaderText = "YakitTuru";
            yakitTuruDataGridViewTextBoxColumn.Name = "yakitTuruDataGridViewTextBoxColumn";
            yakitTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sanzimanTipiDataGridViewTextBoxColumn
            // 
            sanzimanTipiDataGridViewTextBoxColumn.DataPropertyName = "SanzimanTipi";
            sanzimanTipiDataGridViewTextBoxColumn.HeaderText = "SanzimanTipi";
            sanzimanTipiDataGridViewTextBoxColumn.Name = "sanzimanTipiDataGridViewTextBoxColumn";
            sanzimanTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yiliDataGridViewTextBoxColumn
            // 
            yiliDataGridViewTextBoxColumn.DataPropertyName = "Yili";
            yiliDataGridViewTextBoxColumn.HeaderText = "Yili";
            yiliDataGridViewTextBoxColumn.Name = "yiliDataGridViewTextBoxColumn";
            yiliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arabaViewModelBindingSource
            // 
            arabaViewModelBindingSource.DataSource = typeof(Models.ArabaViewModel);
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(8, 260);
            txtCarId.Name = "txtCarId";
            txtCarId.PlaceholderText = "Car ID";
            txtCarId.Size = new Size(100, 23);
            txtCarId.TabIndex = 8;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(118, 260);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 8;
            btnRead.Text = "OKU";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 515);
            Controls.Add(dgvArabaList);
            Controls.Add(nbrUpDownYil);
            Controls.Add(groupBox1);
            Controls.Add(txtYili);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrUpDownYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArabaList).EndInit();
            ((System.ComponentModel.ISupportInitialize)arabaViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtModel;
        private TextBox txtMarka;
        private DataGridView dgvArabaList;
        private ComboBox cBoxSanzimanTipi;
        private ComboBox cBoxMotorTipi;
        private ComboBox cBoxYakitTuru;
        private TextBox txtYili;
        private Button btnSave;
        private NumericUpDown nbrUpDownYil;
        private ComboBox cBoxYil;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motorTipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yakitTuruDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sanzimanTipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yiliDataGridViewTextBoxColumn;
        private BindingSource arabaViewModelBindingSource;
        private TextBox txtId;
        private Button btnRead;
        private TextBox txtCarId;
    }
}
