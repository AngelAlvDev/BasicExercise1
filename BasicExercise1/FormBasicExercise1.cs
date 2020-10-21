using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicExercise1
{
    public partial class FormBasicExercise1 : Form
    {
        public FormBasicExercise1()
        {
            InitializeComponent();
        }

        private void nuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = (new PrintDialog()).ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Vas a imprimir");
            }
            else
            {
                this.Close();
            }

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
}
