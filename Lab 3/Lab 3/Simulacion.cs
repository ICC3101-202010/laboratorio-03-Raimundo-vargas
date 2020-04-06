using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Simulacion
    {
        public List<Producto> Listaproductos = new List<Producto>();
        public List<Clientes> Listaclientes = new List<Clientes>();
        public List<Trabajadores> ListaTrabajadores = new List<Trabajadores>();
        public Simulacion()
        {
            Listaproductos.Add(new Producto("Arroz", "990", "Miraflores", 500));
            Listaproductos.Add(new Producto("Tallarines", "1.990", "Lucheti", 300));
            Listaproductos.Add(new Producto("Platano", "1.600", "Fruits", 200));
            Listaproductos.Add(new Producto("Sandia", "5.000", "Fruits", 40));
            Listaproductos.Add(new Producto("Carne", "11.000", "Carnespepe", 20));
            Listaproductos.Add(new Producto("Snichers", "990", "Snickers", 500));
            Listaproductos.Add(new Producto("Trencito", "1.200", "Nestle", 70));
            Listaproductos.Add(new Producto("Leche", "490", "Colun", 250));
            Listaproductos.Add(new Producto("Leche condensada", "990", "Colun", 100));
            Listaproductos.Add(new Producto("Manjar", "990", "Colun", 150));
            Listaproductos.Add(new Producto("Papas Fritas", "990", "Lays", 100));
            Listaproductos.Add(new Producto("Comida de Perro", "15.000", "Pedigree", 50));
            Listaproductos.Add(new Producto("Helado", "2.790", "Great Value", 50));
            Listaproductos.Add(new Producto("Ramitas", "790", "Marco Polo", 170));
            Listaproductos.Add(new Producto("Pizza", "4.990", "Great Value", 90));
            Listaproductos.Add(new Producto("Televisor", "185.000", "Samsung", 10));
            Listaproductos.Add(new Producto("Torta", "7.860", "Lider", 13));
            Listaproductos.Add(new Producto("Hielo", "1.000", "Lider", 30));
            Listaproductos.Add(new Producto("Cerveza", "690", "Corona", 250));
            Listaproductos.Add(new Producto("Carbon", "5.000", "Rinihue", 60));
            Listaproductos.Add(new Producto("Cigarros", "3.790", "kent", 50));
            Listaproductos.Add(new Producto("Bebida", "980", "Coca-Cola", 300));
            Listaproductos.Add(new Producto("Bebida", "890", "Pepsi", 200));
            Listaproductos.Add(new Producto("Salchichas", "2.800", "La Preferida", 80));
            Listaproductos.Add(new Producto("Malaya", "8.990", "Super Cerdo", 30));
            Listaproductos.Add(new Producto("Desodorante", "1.200", "Speed Stick", 85));
            Listaproductos.Add(new Producto("Vaso", "490", "Great Value", 115));
            Listaproductos.Add(new Producto("Confort", "5.990", "Elite", 500));
            Listaproductos.Add(new Producto("Alchol Gel", "1.190", "Nexcare", 200));
            Listaproductos.Add(new Producto("Agua", "690", "Cachantun", 150));

            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "11/08/1999", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "05/12/1989", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "12/11/1968", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "30/08/1998", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "07/01/2000", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "26/10/1985", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "21/03/1973", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "15/09/2001", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "30/05/1993", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "11/04/1996", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "18/11/1999", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Peruano"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Peruano"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Espanol"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Espanol"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Venezolano"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Venezolano"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Argentino"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Argentino"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Argentino"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Boliviano"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Estadounidense"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Frances"));
            Listaclientes.Add(new Clientes("20284056-6", "Raimundo", "Vargas", "", "Aleman"));

        }

        public void VerProductos()
        {
            for (int i = 0; i < Listaproductos.Count; i++)
                Console.WriteLine(Listaproductos[i].InformacionProductos());
        }
    }
}
