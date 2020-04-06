using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Trabajadores
    {
        public string sueldo;
        public string puesto;
        public string Rut;
        public string Nombre;
        public string Apellido;
        public string Fechadenacimiento;
        public string Nacionalidad;
        public string Horario;
        public Trabajadores(string Ruts, string Nombres, string Apellidos, string Fechadenacimientos, 
            string Nacionalidads, string puestos ,string sueldos , string horarios)
        {
            Rut = Ruts;
            Nombre = Nombres;
            Apellido = Apellidos;
            Fechadenacimiento = Fechadenacimientos;
            Nacionalidad = Nacionalidads;
            sueldo = sueldos;
            puesto = puestos;
            Horario = horarios;
        }
        public string Informaciontrabajadores()
        {
            string info = (" Rut: " + Rut + "," + " Nombre: " + Nombre + "," + " Apellido:  " 
                + Apellido + "," + " Fecha de nacimiento: : " + Fechadenacimiento + " ,Puesto: " + puesto + " ,sueldo: " + sueldo + " ,horario: " + Horario);
            return info;
        }
    }
}
