using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void flieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aBMAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* REVISAR
            this.Hide();
            Form alumnosform = new AlumnosForm();
            alumnosform.Show();
            */
        }

        private void aBMMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form materiasform = new MateriasForm();
            materiasform.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
