using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumnos
{
    class BussinessLogicLayer
    {
        DataAccessLayer dataAccessLayer;

        public BussinessLogicLayer()
        {
            dataAccessLayer = new DataAccessLayer();
        }


        public void AddContact(Contact contacto)
        {
            dataAccessLayer.AddContact(contacto);

        }



        public void SaveContact(Contact contacto)
        {
            if (contacto.id == 0)
            {

            }
            else
            {
                    
            }

        }

    }
}
