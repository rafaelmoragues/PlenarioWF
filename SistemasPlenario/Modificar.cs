using Controllers;
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
    public partial class Modificar : Form
    {
        TelefonosController tController = new TelefonosController();
        int _tId;
        public Modificar(int id)
        {
            InitializeComponent();
            _tId = id;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var aux = tController.GetTel(_tId);
            aux.TelefonoNumero = txb_Num.Text;
            tController.update(aux);
            this.Close();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            var aux = tController.GetTel(_tId);
            if (aux != null)
                txb_Num.Text = aux.TelefonoNumero;
            else
            {
                MessageBox.Show("No se seleccionó ningún número");
                Close();
            }
        }
    }
}
