using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    public partial class VerHistorico : Form
    {
        public VerHistorico()
        {
            InitializeComponent();



        }

        private void VerHistorico_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.DialogResult = DialogResult.Cancel;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
