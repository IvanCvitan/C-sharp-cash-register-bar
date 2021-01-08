namespace BlagajnaV2
{
    partial class Racun
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
            System.Windows.Forms.Label datumRacunaLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Blagajna_CvitanDataSet = new BlagajnaV2._Blagajna_CvitanDataSet();
            this.dtpDatumRacuna = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.racunTableAdapter = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.RacunTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.ZaposlenikTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnNovi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idRacunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaRacunTableAdapter = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.StavkaRacunTableAdapter();
            this.proizvodTableAdapter = new BlagajnaV2._Blagajna_CvitanDataSetTableAdapters.ProizvodTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.proizvodStavkaRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikRacunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIzdvanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            datumRacunaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Blagajna_CvitanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodStavkaRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikRacunBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // datumRacunaLabel
            // 
            datumRacunaLabel.AutoSize = true;
            datumRacunaLabel.Location = new System.Drawing.Point(340, 266);
            datumRacunaLabel.Name = "datumRacunaLabel";
            datumRacunaLabel.Size = new System.Drawing.Size(90, 13);
            datumRacunaLabel.TabIndex = 27;
            datumRacunaLabel.Text = "Datum Izdavanja:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.datumIzdvanjaDataGridViewTextBoxColumn,
            this.placenDataGridViewCheckBoxColumn,
            this.idZaposlenikDataGridViewTextBoxColumn,
            this.Zaposlenik});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(548, 164);
            this.dataGridView1.TabIndex = 26;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            // 
            // _Blagajna_CvitanDataSet
            // 
            this._Blagajna_CvitanDataSet.DataSetName = "_Blagajna_CvitanDataSet";
            this._Blagajna_CvitanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDatumRacuna
            // 
            this.dtpDatumRacuna.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "DatumIzdvanja", true));
            this.dtpDatumRacuna.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.racunBindingSource, "DatumIzdvanja", true));
            this.dtpDatumRacuna.Location = new System.Drawing.Point(436, 260);
            this.dtpDatumRacuna.Name = "dtpDatumRacuna";
            this.dtpDatumRacuna.Size = new System.Drawing.Size(167, 20);
            this.dtpDatumRacuna.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Placeno:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.racunBindingSource, "Placen", true));
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.racunBindingSource, "Placen", true));
            this.checkBox1.Location = new System.Drawing.Point(443, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Zaposlenik: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "ID", true));
            this.textBox1.Location = new System.Drawing.Point(436, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // BtnNovi
            // 
            this.BtnNovi.Location = new System.Drawing.Point(178, 225);
            this.BtnNovi.Name = "BtnNovi";
            this.BtnNovi.Size = new System.Drawing.Size(94, 34);
            this.BtnNovi.TabIndex = 35;
            this.BtnNovi.Text = "Novi";
            this.BtnNovi.UseVisualStyleBackColor = true;
            this.BtnNovi.Click += new System.EventHandler(this.BtnNovi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(178, 292);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(94, 33);
            this.btnSpremi.TabIndex = 36;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Proizvod,
            this.idRacunDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkaRacunBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(79, 405);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(548, 212);
            this.dataGridView2.TabIndex = 37;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Proizvod
            // 
            this.Proizvod.DataPropertyName = "IdProizvod";
            this.Proizvod.DataSource = this.proizvodBindingSource;
            this.Proizvod.DisplayMember = "Naziv";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Proizvod.ValueMember = "ID";
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataMember = "Proizvod";
            this.proizvodBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            // 
            // idRacunDataGridViewTextBoxColumn
            // 
            this.idRacunDataGridViewTextBoxColumn.DataPropertyName = "IdRacun";
            this.idRacunDataGridViewTextBoxColumn.HeaderText = "IdRacun";
            this.idRacunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRacunDataGridViewTextBoxColumn.Name = "idRacunDataGridViewTextBoxColumn";
            this.idRacunDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stavkaRacunBindingSource
            // 
            this.stavkaRacunBindingSource.DataMember = "StavkaRacun";
            this.stavkaRacunBindingSource.DataSource = this._Blagajna_CvitanDataSet;
            // 
            // stavkaRacunTableAdapter
            // 
            this.stavkaRacunTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.racunBindingSource, "idZaposlenik", true));
            this.comboBox1.DataSource = this.zaposlenikBindingSource;
            this.comboBox1.DisplayMember = "Ime";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.ValueMember = "id";
            // 
            // proizvodStavkaRacunBindingSource
            // 
            this.proizvodStavkaRacunBindingSource.DataMember = "ProizvodStavkaRacun";
            this.proizvodStavkaRacunBindingSource.DataSource = this.proizvodBindingSource;
            // 
            // zaposlenikRacunBindingSource
            // 
            this.zaposlenikRacunBindingSource.DataMember = "ZaposlenikRacun";
            this.zaposlenikRacunBindingSource.DataSource = this.zaposlenikBindingSource;
            // 
            // zaposlenikRacunBindingSource1
            // 
            this.zaposlenikRacunBindingSource1.DataMember = "ZaposlenikRacun";
            this.zaposlenikRacunBindingSource1.DataSource = this.zaposlenikBindingSource;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // datumIzdvanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdvanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumIzdvanja";
            this.datumIzdvanjaDataGridViewTextBoxColumn.HeaderText = "DatumIzdvanja";
            this.datumIzdvanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumIzdvanjaDataGridViewTextBoxColumn.Name = "datumIzdvanjaDataGridViewTextBoxColumn";
            this.datumIzdvanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumIzdvanjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // placenDataGridViewCheckBoxColumn
            // 
            this.placenDataGridViewCheckBoxColumn.DataPropertyName = "Placen";
            this.placenDataGridViewCheckBoxColumn.HeaderText = "Placen";
            this.placenDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.placenDataGridViewCheckBoxColumn.Name = "placenDataGridViewCheckBoxColumn";
            this.placenDataGridViewCheckBoxColumn.ReadOnly = true;
            this.placenDataGridViewCheckBoxColumn.Width = 125;
            // 
            // idZaposlenikDataGridViewTextBoxColumn
            // 
            this.idZaposlenikDataGridViewTextBoxColumn.DataPropertyName = "idZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.HeaderText = "idZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idZaposlenikDataGridViewTextBoxColumn.Name = "idZaposlenikDataGridViewTextBoxColumn";
            this.idZaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idZaposlenikDataGridViewTextBoxColumn.Visible = false;
            this.idZaposlenikDataGridViewTextBoxColumn.Width = 125;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.DataPropertyName = "idZaposlenik";
            this.Zaposlenik.DataSource = this.zaposlenikBindingSource;
            this.Zaposlenik.DisplayMember = "Ime";
            this.Zaposlenik.HeaderText = "Zaposlenik";
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            this.Zaposlenik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zaposlenik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Zaposlenik.ValueMember = "id";
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 639);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.BtnNovi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumRacuna);
            this.Controls.Add(datumRacunaLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Racun";
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.Racun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Blagajna_CvitanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodStavkaRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikRacunBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpDatumRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private _Blagajna_CvitanDataSet _Blagajna_CvitanDataSet;
        private _Blagajna_CvitanDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private _Blagajna_CvitanDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnNovi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stavkaRacunBindingSource;
        private _Blagajna_CvitanDataSetTableAdapters.StavkaRacunTableAdapter stavkaRacunTableAdapter;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private _Blagajna_CvitanDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRacun;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource proizvodStavkaRacunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRacunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposlenikRacunBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikRacunBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdvanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn placenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Zaposlenik;
    }
}