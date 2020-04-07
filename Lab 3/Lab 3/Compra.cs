using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Compra
    {
        public string Hora;
        public string Fecha;
        public string NombreCliente;
        public string NombreCajero;
        public List<Producto> nuevascompras = new List<Producto>();
        
        public Compra(string Horas, string Fechas, string NombreClientes, string NombreCajeros, List<Producto> nuevascomprass)
        {
            Hora = Horas;
            Fecha = Fechas;
            NombreCliente = NombreClientes;
            NombreCajero = NombreCajeros;
            nuevascompras = nuevascomprass;
        }
        public string InformacionCompra()
        {
            string info = (" Hora: " + Hora + "," + " Fecha: " + Fecha + "," 
                + " Nombre Cliente: " + NombreCliente + "," + " Nombre Cajero: " + NombreCajero +"\nProductos comprados:\n");
            
            for(int i = 0; i < nuevascompras.Count; i++)
            {
                info += nuevascompras[i].InformacionProductos();
                info += "\n";
            }
            return info;
        }











    }
}
