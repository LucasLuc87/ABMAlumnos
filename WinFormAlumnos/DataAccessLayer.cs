using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormAlumnos
{
    class DataAccessLayer
    {
         SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Alumnos;Data Source=DESKTOP-F2PFMI0\\SERVIDORLUCAS");
        
        public void AddContact(Contact contacto)
        {
            if (TestConection())
            {
                try
                {
                    string query = @"
                                INSERT INTO GestionAlumnos values(@Nombre, @Apellido)";

                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlParameter nombre = new SqlParameter("@Nombre", contacto.nombre);
                    SqlParameter apellido = new SqlParameter("@Apellido", contacto.apellido);

                    comando.Parameters.Add(nombre);
                    comando.Parameters.Add(apellido);

                    conn.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        public void UpdateContact()
        {
            if (TestConection())
            {
                MessageBox.Show("Contacto Modificado");
            }
        }

        public void DeleteContact()
        {
            if (TestConection())
            {
                MessageBox.Show("Contacto Eliminado");
            } 
        }

        private bool TestConection()
        {
            bool conexion = false;
            try
            {
                conn.Open();
                conexion = true;                
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo conexion");                
            }
            finally
            {
                conn.Close();
            } 

            return conexion;
        }


        







    }
}
