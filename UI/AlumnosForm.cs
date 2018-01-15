using BusinessLogicLayer;
using BusinessLogicLayer.Model;
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
    public partial class AlumnosForm : Form
    {
        private AlumnoController controller = new AlumnoController();
        private int selectedRow;
        public AlumnosForm()
        {
            InitializeComponent();
        }

        private void AlumnosForm_Load(object sender, EventArgs e)
        {
            alumnosGrid.DataSource = controller.GetAll();
            foreach (var button in Controls.OfType<Button>())
            {
                button.Click += Refrescar;
            }
            txtId.Text = alumnosGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = alumnosGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtApellido.Text = alumnosGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var alumno = new AlumnoViewModel(0, txtNombre.Text, txtApellido.Text);
                controller.Guardar(alumno);
            }
            else
            {
                MessageBox.Show("Campos invalidos");
            }
        }
        private void Refrescar(object sender, EventArgs e)
        {
            alumnosGrid.DataSource = controller.GetAll();
            if (selectedRow > alumnosGrid.Rows.Count-1)
                selectedRow = alumnosGrid.Rows.Count-1;
            alumnosGrid.CurrentCell = alumnosGrid.Rows[selectedRow].Cells[0];


            txtId.Text = alumnosGrid.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = alumnosGrid.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = alumnosGrid.CurrentRow.Cells[2].Value.ToString();


        }
        private bool Validar()
        {
            if (txtApellido.Text != "" && txtNombre.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var alumno = new AlumnoViewModel((alumnosGrid.SelectedRows[0].DataBoundItem as AlumnoViewModel).ID, txtNombre.Text, txtApellido.Text);
            controller.Actualizar(alumno);
        }

        private void alumnosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = alumnosGrid.CurrentRow.Index;
            txtId.Text = alumnosGrid.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = alumnosGrid.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = alumnosGrid.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            controller.Borrar((int)alumnosGrid.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
