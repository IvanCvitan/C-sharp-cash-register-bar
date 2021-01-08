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
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
            zaposlenikTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
        }

        private void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                e.Row["ID"] = cmd.ExecuteScalar();  
                e.Row.AcceptChanges();
            }
        }
        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Blagajna_CvitanDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this._Blagajna_CvitanDataSet.Zaposlenik);

        }
        private void BtnNovi_Click(object sender, EventArgs e)
        {
            zaposlenikBindingSource.AddNew();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            zaposlenikBindingSource.EndEdit();
            zaposlenikTableAdapter.Update(_Blagajna_CvitanDataSet.Zaposlenik);
        }

    

    }
}
