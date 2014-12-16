using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// BB 10
namespace Kamata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void duzniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.duzniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kamateDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kamateDataSet1.Poverioci' table. You can move, or remove it, as needed.
            this.poveriociTableAdapter.Fill(this.kamateDataSet1.Poverioci);
            // TODO: This line of code loads data into the 'kamateDataSet1.Kamate' table. You can move, or remove it, as needed.
            this.kamateTableAdapter.Fill(this.kamateDataSet1.Kamate);
            // TODO: This line of code loads data into the 'kamateDataSet1.Duznici' table. You can move, or remove it, as needed.
            this.duzniciTableAdapter.Fill(this.kamateDataSet1.Duznici);

        }

        private void adresaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
