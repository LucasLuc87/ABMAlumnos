using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WinFormAlumnos
{
    public partial class ABMAlumns : Form
    {

        private BussinessLogicLayer bussinessLogic;


        public ABMAlumns()
        {
            InitializeComponent();
            bussinessLogic = new BussinessLogicLayer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarAlumno agregarAlumno = new AgregarAlumno();
            agregarAlumno.ShowDialog();

        }
    }
}
