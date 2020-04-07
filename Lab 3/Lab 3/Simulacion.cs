using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Simulacion
    {
        public List<Producto> Listaproductos = new List<Producto>();
        public List<Producto> Listaproductosoficial = new List<Producto>();
        public List<Clientes> Listaclientes = new List<Clientes>();
        public List<Clientes> Listaclientesoficial = new List<Clientes>();
        public List<Trabajadores> ListaTrabajadores = new List<Trabajadores>();
        public List<Trabajadores> ListaTrabajadoresoficial = new List<Trabajadores>();
        public List<Trabajadores> ListaJefes = new List<Trabajadores>();
        public List<Trabajadores> ListaJefesoficial = new List<Trabajadores>();
        public List<Trabajadores> ListaCajeros = new List<Trabajadores>();
        public List<Trabajadores> ListaCajerosoficial = new List<Trabajadores>();
        public List<Trabajadores> ListaAuxiliares = new List<Trabajadores>();
        public List<Trabajadores> ListaAuxiliaresoficial = new List<Trabajadores>();
        public List<Trabajadores> ListaSupervisores = new List<Trabajadores>();
        public List<Trabajadores> ListaSupervisoresoficial = new List<Trabajadores>();
        public List<Compra> compras = new List<Compra>();
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
            Listaproductos.Add(new Producto("Servilletas", "690", " Elite", 250));
            Listaproductos.Add(new Producto("Jugo", "690", "Wstts", 250));
            Listaproductos.Add(new Producto("Pañales", "1890", "Bambi", 150));
            Listaproductos.Add(new Producto("Cepillo de dientes", "1390", "Lider", 50));
            Listaproductos.Add(new Producto("Pasta de dientes", "490", "Colgate", 50));
            Listaproductos.Add(new Producto("Afeitadora", "990", "Gilette", 50));
            Listaproductos.Add(new Producto("Limon", "1990", "Frutas", 80));
            Listaproductos.Add(new Producto("Palta", "2990", "Frutas", 90));
            Listaproductos.Add(new Producto("Chorizo", "4590", "Don Jorge", 30));
            Listaproductos.Add(new Producto("Pan", "1690", "Bimbo", 80));
            Listaproductos.Add(new Producto("Azucar", "590", "Iansa", 60));
            Listaproductos.Add(new Producto("Harina", "790", "Lider", 80));
            Listaproductos.Add(new Producto("Chicles", "490", "Orbitz", 150));
            Listaproductos.Add(new Producto("Taza", "390", "Lider", 20));
            Listaproductos.Add(new Producto("Pilas AA", "2390", "Duracel", 150));
            Listaproductos.Add(new Producto("Lapices", "790", "Color", 550));
            Listaproductos.Add(new Producto("Plumon", "1190", "Faber Castel", 350));
            Listaproductos.Add(new Producto("Hojas", "4990", "Lider", 150));
            Listaproductos.Add(new Producto("Tv", "150000", "Samsung", 20));
            Listaproductos.Add(new Producto("Refrigerador", "180000", "Samsung", 10));
            Listaproductos.Add(new Producto("Batidora", "30000", "Samsung", 40));
            Listaclientes.Add(new Clientes("20254056-6", "Raimundo", "Vargas", "11/08/1999", "Chileno"));
            Listaclientes.Add(new Clientes("10264056-7", "Felipe", "Alcalde", "05/12/1989", "Chileno"));
            Listaclientes.Add(new Clientes("20248556-8", "Francisco", "Fernandez", "12/11/1968", "Chileno"));
            Listaclientes.Add(new Clientes("10884056-9", "Paula", "Rozas", "30/08/1998", "Chileno"));
            Listaclientes.Add(new Clientes("20214056-1", "Clara", "Soto", "07/01/2000", "Chileno"));
            Listaclientes.Add(new Clientes("10234056-2", "Juan", "Tagle", "26/10/1985", "Chileno"));
            Listaclientes.Add(new Clientes("20244056-3", "Carlos", "Versluys", "21/03/1973", "Chileno"));
            Listaclientes.Add(new Clientes("10240556-4", "Jaime", "Castro", "15/09/2001", "Chileno"));
            Listaclientes.Add(new Clientes("56840566-5", "Sebastian", "Canales", "30/05/1993", "Chileno"));
            Listaclientes.Add(new Clientes("10284056-1", "Antonio", "Ruiz-Tagle", "11/04/1996", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-2", "Jose", "Astroza", "18/11/1999", "Chileno"));
            Listaclientes.Add(new Clientes("10284056-3", "Josemaria", "Gubbins", "03/03/1999", "Chileno"));
            Listaclientes.Add(new Clientes("20284056-4", "Fernando", "Gross", "05/05/1998", "Chileno"));
            Listaclientes.Add(new Clientes("10288656-5", "Romualdo", "Vial", "06/06/1997", "Chileno"));
            Listaclientes.Add(new Clientes("20284526-6", "Rodrigo", "Vial", "07/07/2000", "Chileno"));
            Listaclientes.Add(new Clientes("10284256-7", "Ernesto", "Vergara", "08/08/2001", "Chileno"));
            Listaclientes.Add(new Clientes("20284656-8", "Josefina", "Villa", "09/09/1996", "Chileno"));
            Listaclientes.Add(new Clientes("10284956-9", "Fernanda", "Beza", "02/02/1970", "Chileno"));
            Listaclientes.Add(new Clientes("20284756-1", "Magdalena", "Ale", "01/01/1990", "Peruano"));
            Listaclientes.Add(new Clientes("10284856-k", "Florencia", "Chilet", "10/10/1999", "Peruano"));
            Listaclientes.Add(new Clientes("20284956-2", "Camila", "Tonkin", "11/11/1997", "Espanol"));
            Listaclientes.Add(new Clientes("10284156-3", "Angeles", "Herrera", "12/12/1996", "Espanol"));
            Listaclientes.Add(new Clientes("20284256-4", "Macarena", "Vidal", "13/12/1999", "Venezolano"));
            Listaclientes.Add(new Clientes("10284356-5", "Maria", "Sanchez", "14/09/1998", "Venezolano"));
            Listaclientes.Add(new Clientes("20284456-6", "Martin", "Rodriguez", "18/11/1980", "Argentino"));
            Listaclientes.Add(new Clientes("10284556-7", "Mauricio", "Valenzuela", "19/12/1990", "Argentino"));
            Listaclientes.Add(new Clientes("20284656-8", "Marcelo", "Bahomonde", "12/12/1993", "Argentino"));
            Listaclientes.Add(new Clientes("10284756-9", "Federico", "Perez-Cotapo", "20/05/1976", "Boliviano"));
            Listaclientes.Add(new Clientes("20284856-k", "Elisa", "Gana", "22/11/1988", "Estadounidense"));
            Listaclientes.Add(new Clientes("10284956-1", "Vanessa", "Chamas", "21/08/1973", "Frances"));
            Listaclientes.Add(new Clientes("20284156-2", "Cecilia", "Vargas", "27/02/1992", "Aleman"));
            ListaJefes.Add(new Trabajadores("10284158-2", "Cecilia", "Suarez", "20/03/1992", "Chileno", "Jefe", "1.000.000", "8:00-19:00"));
            ListaJefes.Add(new Trabajadores("20234156-3", "Francisca", "Vargas", "27/02/1992", "Chileno", "Jefe", "1.000.000", "8:00-19:00"));
            ListaJefes.Add(new Trabajadores("10285156-4", "Raimundo", "Ale", "27/05/1991", "Chileno", "Jefe", "1.000.000", "8:00-19:00"));
            ListaJefes.Add(new Trabajadores("26284156-5", "Rodrigo", "Vergara", "17/02/1998", "Chileno", "Jefe", "1.000.000", "8:00-19:00"));
            ListaJefes.Add(new Trabajadores("20285856-6", "Felipe", "Pinilla", "06/05/1992", "Chileno", "Jefe", "1.000.000", "8:00-19:00"));
            ListaAuxiliares.Add(new Trabajadores("10235856-1", "Felipe", "Urzua", "06/05/1982", "Chileno", "Auxiliar", "500.000", "8:00-19:00"));
            ListaAuxiliares.Add(new Trabajadores("20285656-2", "Martin", "Perez", "06/07/1993", "Chileno", "Auxiliar", "500.000", "10:00-21:00"));
            ListaAuxiliares.Add(new Trabajadores("10285856-k", "Meliton", "Soto", "16/05/1972", "Chileno", "Auxiliar", "500.000", "8:00-19:00"));
            ListaAuxiliares.Add(new Trabajadores("20289856-3", "Sergio", "Moreno", "08/08/1992", "Chileno", "Auxiliar", "500.000", "10:00-21:00"));
            ListaAuxiliares.Add(new Trabajadores("10285956-4", "Paulina", "Piñera", "24/05/1998", "Chileno", "Auxiliar", "500.000", "8:00-19:00"));
            ListaAuxiliares.Add(new Trabajadores("20285856-5", "Yoselin", "Errazuriz", "13/07/1990", "Chileno", "Auxiliar", "500.000", "10:00-21:00"));
            ListaSupervisores.Add(new Trabajadores("10285866-1", "Rodrigo", "Valenzuela", "06/0/1991", "Chileno", "Supervisor", "600.000", "8:00-19:00"));
            ListaSupervisores.Add(new Trabajadores("20286856-2", "Maximiliano", "Grogean", "07/02/1992", "Chileno", "Supervisor", "600.000", "10:00-21:00"));
            ListaSupervisores.Add(new Trabajadores("11285856-3", "Carla", "Hamilton", "08/03/1993", "Chileno", "Supervisor", "600.000", "8:00-19:00"));
            ListaSupervisores.Add(new Trabajadores("20255856-4", "Carolina", "Verstappen", "09/04/1994", "Espanol", "Supervisor", "600.000", "10:00-21:00"));
            ListaSupervisores.Add(new Trabajadores("10285856-5", "Pascual", "Ricciardo", "10/05/1995", "Chileno", "Supervisor", "600.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("10285856-6", "Brayan", "Recabarren", "11/06/1996", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("20268756-7", "Jhonatan", "Anguita", "12/07/1997", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("10295856-8", "Elopoldo", "Ibanez", "12/08/1998", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("20285856-9", "Renata", "Vargas", "13/09/1997", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("10482856-k", "Renato", "Vial", "14/10/1999", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("29285856-1", "Ruperto", "Soto", "15/11/1981", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("10265856-2", "Maria Jose", "Perez", "16/12/1982", "Venezolano", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("20285456-3", "Natalia", "Errazuriz", "17/01/1983", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("10285896-4", "Antonia", "Bizarri", "18/02/1984", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("20285656-5", "Amalia", "Alvarez", "19/03/1985", "Chileno", "Cajero", "500.000", "8:00-19:00"));
            ListaCajeros.Add(new Trabajadores("10255856-6", "Tomas", "Rivera", "20/04/1986", "Chileno", "Cajero", "500.000", "8:00-19:00"));
        }
        public void HacerListadeProductos()
        {
            int numero = 0;
            while (numero < 30)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, Listaproductos.Count);
                Listaproductosoficial.Add(Listaproductos[a]);
                Listaproductos.Remove(Listaproductos[a]);
                numero += 1;
            }

        }
        public void VerProductos()
        {
            for (int i = 0; i < Listaproductosoficial.Count; i++)
                Console.WriteLine(Listaproductosoficial[i].InformacionProductos());
        }
        public void HacerListadeClientes()
        {
            int numero = 0;
            while (numero < 15)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, Listaclientes.Count);
                Listaclientesoficial.Add(Listaclientes[a]);
                Listaclientes.Remove(Listaclientes[a]);
                numero += 1;
            }
        }
        public void VerClientes()
        {

            for (int i = 0; i < Listaclientesoficial.Count; i++)
                Console.WriteLine(Listaclientesoficial[i].Informacionclientes());
        }
        public void HacerListadeJefes()
        {

            Random rnd = new Random();
            int a = rnd.Next(0, ListaJefes.Count);
            ListaJefesoficial.Add(ListaJefes[a]);
            ListaJefes.Remove(ListaJefes[a]);
        }
        public void VerJefe()
        {

            for (int i = 0; i < ListaJefesoficial.Count; i++)
                Console.WriteLine(ListaJefesoficial[i].Informaciontrabajadores());
        }
        public void HacerListadeSupervisores()
        {

            Random rnd = new Random();
            int a = rnd.Next(0, ListaSupervisores.Count);
            ListaSupervisoresoficial.Add(ListaSupervisores[a]);
            ListaSupervisores.Remove(ListaSupervisores[a]);
        }
        public void VerSupervisor()
        {

            for (int i = 0; i < ListaSupervisoresoficial.Count; i++)
                Console.WriteLine(ListaSupervisoresoficial[i].Informaciontrabajadores());
        }
        public void HacerListadeAuxiliares()
        {

            int numero = 0;
            while (numero < 2)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, ListaAuxiliares.Count);
                ListaAuxiliaresoficial.Add(ListaAuxiliares[a]);
                ListaAuxiliares.Remove(ListaAuxiliares[a]);
                numero += 1;
            }
        }
        public void VerAuxiliares()
        {

            for (int i = 0; i < ListaAuxiliaresoficial.Count; i++)
                Console.WriteLine(ListaAuxiliaresoficial[i].Informaciontrabajadores());
        }
        public void HacerListadeCajeros()
        {
            int numero = 0;
            while (numero < 3)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, ListaCajeros.Count);
                ListaCajerosoficial.Add(ListaCajeros[a]);
                ListaCajeros.Remove(ListaCajeros[a]);
                numero += 1;
            }
        }
        public void VerCajero()
        {

            for (int i = 0; i < ListaCajerosoficial.Count; i++)
                Console.WriteLine(ListaCajerosoficial[i].Informaciontrabajadores());
        }
        public void BolsadeCompra()
        {
            List<Producto> ListadeCompra = new List<Producto>();
            Random rnd = new Random();
            int cantidadcompra = rnd.Next(0, Listaproductosoficial.Count);
            while (cantidadcompra > 0)
            {
                int n = rnd.Next(0, Listaproductosoficial.Count);
                int cantidad = rnd.Next(0, Listaproductosoficial[n].Stock); ;
                ListadeCompra.Add(Listaproductosoficial[n]);
                Listaproductosoficial[n].Stock -= cantidad;
                cantidadcompra -= 1;
            }

            int r = rnd.Next(0, Listaclientesoficial.Count);
            DateTime fecha = DateTime.Now;
            string nombrecliente = Listaclientesoficial[r].Nombre;
            r = rnd.Next(0, ListaCajerosoficial.Count);
            string nombrecajero = ListaCajerosoficial[r].Nombre;
            string fechas = fecha.ToShortDateString().ToString();
            string horas = fecha.ToShortTimeString().ToString();
            compras.Add(new Compra(horas, fechas, nombrecliente, nombrecajero, ListadeCompra));
        }   
        public void VerComprass()
        {
            if (compras.Count > 0)
            {
                
                for (int i = 0; i < compras.Count; i++)
                {
                    Console.WriteLine("\nDetalle Compra n" + (i+1)+"\n");
                    Console.WriteLine(compras[i].InformacionCompra());
                    Thread.Sleep(1000);
                }
                Console.WriteLine("\n");
            }     
        }       
    }
}
