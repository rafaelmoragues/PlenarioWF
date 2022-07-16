using Controllers;
using SistemasPlenario.Models;
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
    public partial class AltaTelefono : Form
    {
        TelefonosController tController = new TelefonosController();
        int perId;
        public AltaTelefono()
        {
            InitializeComponent();
        }
        public AltaTelefono(int id)
        {
            InitializeComponent();
            perId=id;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Telefono tel = new Telefono {
                PersonaId = perId,
                TelefonoNumero = txb_Num.Text
            };
            tController.GuardarTel(tel);
            MessageBox.Show("Número de telefono guardado correctamente");
            this.Close();
        }
    }
}
