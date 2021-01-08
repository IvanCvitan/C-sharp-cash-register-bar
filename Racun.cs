using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BlagajnaV2
{
    public partial class Racun : Form
    {
        public Racun()
        {
            InitializeComponent();
            racunTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;

        }

        private void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                var oldId = e.Row["ID"];
                var newId = cmd.ExecuteScalar();
                e.Row["ID"] = newId;
                e.Row.AcceptChanges();
                foreach (DataRow rs in _Blagajna_CvitanDataSet.StavkaRacun.Rows)
                {
                    if (rs["idRacun"].Equals(oldId))
                        rs["idRacun"] = newId;
                }
            }
        }


        private void Racun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Blagajna_CvitanDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this._Blagajna_CvitanDataSet.Proizvod);
            // TODO: This line of code loads data into the '_Blagajna_CvitanDataSet.StavkaRacun' table. You can move, or remove it, as needed.
            this.stavkaRacunTableAdapter.Fill(this._Blagajna_CvitanDataSet.StavkaRacun);
            // TODO: This line of code loads data into the '_Blagajna_CvitanDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this._Blagajna_CvitanDataSet.Zaposlenik);
            // TODO: This line of code loads data into the '_Blagajna_CvitanDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this._Blagajna_CvitanDataSet.Racun);

        }

        private void BtnNovi_Click(object sender, EventArgs e)
        {
            racunBindingSource.AddNew();
            stavkaRacunBindingSource.AddNew();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            racunBindingSource.EndEdit();
            stavkaRacunBindingSource.EndEdit();
            racunTableAdapter.Update(_Blagajna_CvitanDataSet.Racun);
            stavkaRacunTableAdapter.Update(_Blagajna_CvitanDataSet.StavkaRacun);
        }

    }
}
