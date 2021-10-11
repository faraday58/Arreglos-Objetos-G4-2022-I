using System;

namespace Personas
{
    class Persona
    {
        #region Atributos
        private string nombre;
        private string telefono;
        private byte edad;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte Edad { 
            get => edad;
            set
            {
                if(   12 < edad   || edad > 80     )
                {
                    edad = 12;
                }
                else
                {
                    edad = value;
                }
                
            }
        }
        #endregion


        public Persona(string nombre, string telefono, byte edad)
        {
            Nombre = nombre;
            Telefono = telefono;
            Edad = edad;
        }

        public override string ToString()
        {
            string datos = String.Format("Nombre: {0} \n Teléfono: {1} \n Edad: {2}", Nombre,Telefono,Edad);
            return datos;
        }

    }
}
