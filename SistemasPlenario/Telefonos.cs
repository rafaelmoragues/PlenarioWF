using Controllers;
using Modelos.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasPlenario
{
    public partial class Telefonos : Form
    {
        TelefonosController tController = new TelefonosController();
        int _id=0;
        int _telId = 0;
        public Telefonos()
        {
            InitializeComponent();
        }
        public Telefonos(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            AltaTelefono nuevoTel = new AltaTelefono(_id);
            nuevoTel.ShowDialog();
            this.OnLoad(e);
        }

        private void Telefonos_Load(object sender, EventArgs e)
        {
            dataGridViewTelefonos.DataSource = tController.CargarTel(_id);
            dataGridViewTelefonos.Columns["TelefonoId"].Visible = false;
            dataGridViewTelefonos.Columns["Persona"].Visible = false;
            dataGridViewTelefonos.Columns["PersonaId"].Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Modificar mod = new Modificar(_telId);
            mod.ShowDialog();
            this.OnLoad(e);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (tController.EliminiarTel(_telId))
                MessageBox.Show("El número de telefono se borro correctamente");
            else MessageBox.Show("Ocurrió un error, seleccione un numero y vuelva " +
                "a presionar Eliminar");
            this.OnLoad(e);
        }

        private void dataGridViewTelefonos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _telId = (int)dataGridViewTelefonos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
