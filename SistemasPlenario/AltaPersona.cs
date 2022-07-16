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
    public partial class AltaPersona : Form
    {
        PersonasController pController = new PersonasController();
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona
            {
                CreditoMaximo = Convert.ToInt32(txb_Cred.Text),
                Nombre = txb_Nombre.Text,
                FechaNacimiento = Convert.ToDateTime(txb_FNac.Text)

            };
            pController.AgregarPersona(p);
            this.Close();
        }
    }
}
