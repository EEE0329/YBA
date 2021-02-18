using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormBase : Form
    {
        public DataSet ds = new DataSet();
        public FormBase()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public virtual void Salvar()
        {

        }
        public virtual void Imprimir()
        {

        }
        public virtual void Consultar()
        {

        }
        public virtual void Eliminar()
        {

        }
        public virtual void Limpiar()
        {

        }

    }
}
