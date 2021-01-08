namespace BlagajnaV2
{
    partial class Proizvodac
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
            this._Blagajna_CvitanDataSet = new BlagajnaV2._Blagajna_CvitanDataSet();
            this.blagajnaCvitanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodacTableAdapter = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.ProizvodacTableAdapter();
            this.tableAdapterManager = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.BtnNovi = new System.Windows.Forms.Button();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.državaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.državaTableAdapter = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.DržavaTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDrzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._Blagajna_CvitanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blagajnaCvitanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.državaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Blagajna_CvitanDataSet
            // 
            this._Blagajna_CvitanDataSet.DataSetName = "_Blagajna_CvitanDataSet";
            this._Blagajna_CvitanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blagajnaCvitanDataSetBindingSource
            // 
            this.blagajnaCvitanDataSetBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            this.blagajnaCvitanDataSetBindingSource.Position = 0;
            // 
            // proizvodacBindingSource
            // 
            this.proizvodacBindingSource.DataMember = "Proizvodac";
            this.proizvodacBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            // 
            // proizvodacTableAdapter
            // 
            this.proizvodacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DržavaTableAdapter = null;
            this.tableAdapterManager.ProizvodacTableAdapter = this.proizvodacTableAdapter;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.StavkaRacunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.idDrzavaDataGridViewTextBoxColumn,
            this.Drzava});
            this.dataGridView1.DataSource = this.proizvodacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(422, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Država";
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodacBindingSource, "ID", true));
            this.id.Location = new System.Drawing.Point(47, 487);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(132, 20);
            this.id.TabIndex = 4;
            // 
            // naziv
            // 
            this.naziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodacBindingSource, "Naziv", true));
            this.naziv.Location = new System.Drawing.Point(251, 487);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(132, 20);
            this.naziv.TabIndex = 5;
            // 
            // BtnNovi
            // 
            this.BtnNovi.Location = new System.Drawing.Point(26, 192);
            this.BtnNovi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNovi.Name = "BtnNovi";
            this.BtnNovi.Size = new System.Drawing.Size(79, 35);
            this.BtnNovi.TabIndex = 37;
            this.BtnNovi.Text = "Novi";
            this.BtnNovi.UseVisualStyleBackColor = true;
            this.BtnNovi.Click += new System.EventHandler(this.BtnNovi_Click);
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(26, 248);
            this.BtnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(79, 35);
            this.BtnSpremi.TabIndex = 36;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // državaBindingSource
            // 
            this.državaBindingSource.DataMember = "Država";
            this.državaBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            // 
            // državaTableAdapter
            // 
            this.državaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proizvodacBindingSource, "IdDrzava", true));
            this.comboBox1.DataSource = this.državaBindingSource;
            this.comboBox1.DisplayMember = "Naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(468, 487);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.ValueMember = "ID";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDrzavaDataGridViewTextBoxColumn
            // 
            this.idDrzavaDataGridViewTextBoxColumn.DataPropertyName = "IdDrzava";
            this.idDrzavaDataGridViewTextBoxColumn.HeaderText = "IdDrzava";
            this.idDrzavaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDrzavaDataGridViewTextBoxColumn.Name = "idDrzavaDataGridViewTextBoxColumn";
            this.idDrzavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDrzavaDataGridViewTextBoxColumn.Visible = false;
            this.idDrzavaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "IdDrzava";
            this.Drzava.DataSource = this.državaBindingSource;
            this.Drzava.DisplayMember = "Naziv";
            this.Drzava.HeaderText = "Drzava";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            this.Drzava.ValueMember = "ID";
            // 
            // Proizvodac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 533);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnNovi);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Proizvodac";
            this.Text = "Proizvodač";
            this.Load += new System.EventHandler(this.Proizvodac_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Blagajna_CvitanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blagajnaCvitanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.državaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource blagajnaCvitanDataSetBindingSource;
        private _Blagajna_CvitanDataSet _Blagajna_CvitanDataSet;
        private System.Windows.Forms.BindingSource proizvodacBindingSource;
        private _Blagajna_CvitanDataSetTableAdapters.ProizvodacTableAdapter proizvodacTableAdapter;
        private _Blagajna_CvitanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.Button BtnNovi;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.BindingSource državaBindingSource;
        private _Blagajna_CvitanDataSetTableAdapters.DržavaTableAdapter državaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDrzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Drzava;
    }
}