using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Clientes
    {
        public string Rut;
        public string Nombre;
        public string Apellido;
        public string Fechadenacimiento;
        public string Nacionalidad;
        public Clientes(string Ruts, string Nombres, string Apellidos, string Fechadenacimientos, string Nacionalidads)
        {
            Rut = Ruts;
            Nombre = Nombres;
            Apellido = Apellidos;
            Fechadenacimiento = Fechadenacimientos;
            Nacionalidad = Nacionalidads;
        }
        public string Informacionclientes()
        {
            string info = (" Rut: " + Rut + "," + " Nombre: " + Nombre + "," + " Apellido:  "
                + Apellido + "," + " Fecha de nacimiento: : " + Fechadenacimiento);
            return info;
        }
    }
}
