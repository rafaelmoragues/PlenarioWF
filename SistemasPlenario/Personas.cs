using Controllers;
using Modelos.Data;

namespace SistemasPlenario
{
    public partial class Personas : Form
    {
        PersonasController pController = new PersonasController();
        int pId = 0;

        public Personas()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AltaPersona persona = new AltaPersona();
            persona.ShowDialog();
            this.OnLoad(e);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (pController.Borrar(pId))
                MessageBox.Show("La persona se eliminó correctamente");
            else MessageBox.Show("Ocurrió un error, seleccione una persona y vuelva " +
                "a presionar Eliminar");
            this.OnLoad(e);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            Telefonos telefonos = new Telefonos(pId);
            telefonos.Show();
        }

        private void dataGridViewPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pId = (int)dataGridViewPersonas.Rows[e.RowIndex].Cells[0].Value;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            dataGridViewPersonas.DataSource = pController.CargarPersonas();
            dataGridViewPersonas.Columns["PersonaId"].Visible = false;
            dataGridViewPersonas.Columns["Telefonos"].Visible = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            var per = pController.Buscar(txb_buscar.Text);
            dataGridView1.DataSource= per;
        }
    }
}