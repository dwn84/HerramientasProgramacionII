using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Persona
    {
        #region variables
        private string name;
        private string addres;
        private string cellphone;
        #endregion
        #region Propiedades
        public string Name { get => name; set => name = value; }
        public string Addres { get => addres; set => addres = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        #endregion
        #region metodos
        public Persona()
        {
            name = "Rene Higuita";
            addres = "Cra 11 #11-11";
            cellphone = "315222222";
        }

  

        

        //sobrecarga 2  del constructor
        public Persona(string name, string addres="Cra 1", string cellphone="301222222")
        {
            this.name = name;
            this.addres = addres;
            this.cellphone = cellphone;

        }

        #endregion
    }
}
