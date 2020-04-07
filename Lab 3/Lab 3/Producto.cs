using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Producto
    {  
        public string Nombre;
        public string Precio;
        public string Marca;
        public int Stock;
        public Producto(string Nombres, string Precios, string Marcas, int Stocks)
        {           
            Nombre = Nombres;
            Precio = Precios;
            Marca = Marcas;
            Stock = Stocks;
        }
        public string InformacionProductos()
        {
            string info = (" Nombre: " + Nombre + "," + " Precio: " + Precio + "," + " Marca: " + Marca + "," + " Stock: " + Stock);
            return info;
        }
    }
}
