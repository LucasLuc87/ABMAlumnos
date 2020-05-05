using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAlumnos
{

    public partial class AgregarAlumno : Form
    {

        BussinessLogicLayer bussinessLogicLayer;

        public AgregarAlumno()
        {
            InitializeComponent();
            bussinessLogicLayer = new BussinessLogicLayer();

        }


        #region Eventos
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            GrabarContacto();
        }

        private void GrabarContacto()
        {
            Contact contacto = new Contact()
            {
                nombre = txtName.Text,
                apellido = txtApellido.Text,
            };
            bussinessLogicLayer.AddContact(contacto);

        }



    }
}
