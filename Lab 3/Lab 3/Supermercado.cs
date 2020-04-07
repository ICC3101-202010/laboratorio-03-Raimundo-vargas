using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Supermercado
    {
        public List<Producto> Listaproductos = new List<Producto>();
        public List<Clientes> Listaclientes = new List<Clientes>();
        public List<Trabajadores> ListaTrabajadores = new List<Trabajadores>();
        public List<Compra> compras = new List<Compra>();      
        public Supermercado()
        {
            Console.WriteLine("Bienvenido, Que desea hacer?");
        }
        public void CrearProductos()
        {
            Console.WriteLine("Crear Producto:");
            Console.WriteLine("\nIngrese Nombre del Producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese Precio del Producto:");
            string precio = Console.ReadLine();
            Console.WriteLine("\nIngrese Marca del Producto:");
            string marca = Console.ReadLine();
            Console.WriteLine("\nIngrese Stock del Producto:");
            int stock = int.Parse(Console.ReadLine());
            Listaproductos.Add(new Producto(nombre, precio, marca, stock));
        }
        public void CrearCliente()
        {
            Console.WriteLine("Crear Cliente:");
            Console.WriteLine("\nIngrese Rut del Cliente:");
            string rutcliente = Console.ReadLine();
            Console.WriteLine("\nIngrese Nombre del Cliente:");
            string nombrecliente = Console.ReadLine();
            Console.WriteLine("\nIngrese Apellido del Cliente:");
            string apellidocliente = Console.ReadLine();
            Console.WriteLine("\nIngrese Nacionalidad del Cliente:");
            string nacionalidadcliente = Console.ReadLine();
            Console.WriteLine("\nIngrese Fecha de nacimiento del Cliente:");
            string fechanacimientocliente = Console.ReadLine();
            Listaclientes.Add( new Clientes(rutcliente, nombrecliente, apellidocliente, fechanacimientocliente, nacionalidadcliente));           
        }
        public void CrearTrabajador()
        {
            Console.WriteLine("Crear Trabajador:");
            Console.WriteLine("\nIngrese Rut del Trabajador:");
            string rutTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese Nombre del Trabajador:");
            string nombreTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese Apellido del Trabajador:");
            string apellidoTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese Nacionalidad del Trabajador:");
            string nacionalidadTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese Fecha de nacimiento del Trabajador:");
            string fechanacimientoTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese puesto del Trabajador (cajero / supervisor / auxiliar / jefe)");
            string puestoTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese sueldo del Trabajador:");
            string sueldoTrabajador = Console.ReadLine();
            Console.WriteLine("\nIngrese horario del Trabajador:");
            string horario = Console.ReadLine();
            if (puestoTrabajador == "cajero" || puestoTrabajador == "supervisor" || puestoTrabajador == "jefe" || puestoTrabajador == "auxiliar")
            {
                Trabajadores Trabajador = new Trabajadores(rutTrabajador, nombreTrabajador, apellidoTrabajador,
                fechanacimientoTrabajador, nacionalidadTrabajador, puestoTrabajador, sueldoTrabajador,horario);
                ListaTrabajadores.Add(Trabajador);
            }
            else
            {
                Console.WriteLine("a ingresado un puesto de trabajo erroneo");
            }        
        }
        public void BolsadeCompra()
        {
            List<Producto> ListadeCompra = new List<Producto>();
            string s = "s";
            while (s == "s")
            {
                Console.WriteLine("\nIngrese Nombre del Producto:");
                string nombreproducto = Console.ReadLine();
                Console.WriteLine("\nIngrese Cantidad del Producto a comprar:");
                int cantidad = int.Parse(Console.ReadLine());
                for (int i = 0; i < Listaproductos.Count; i++)
                {
                    if (Listaproductos[i].Nombre == nombreproducto)
                    {
                        if ((Listaproductos[i].Stock) >= cantidad)
                        {
                            Listaproductos[i].Stock = Listaproductos[i].Stock - cantidad;                         
                            ListadeCompra.Add(new Producto (Listaproductos[i].Nombre,Listaproductos[i].Precio,Listaproductos[i].Marca,cantidad));                         
                        }
                        else
                        {
                            Console.WriteLine("No se puede comprar esta cantidad de este producto, Puede comprar maximo: " + Listaproductos[i].Stock);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Este producto no existe");
                        break;
                    }
                    Console.WriteLine("Desea seguir agregando productos a la blosa?(si = s/ no = ingresa cualquier valor)");
                s = Console.ReadLine();
                }           
            }
            string problema = "";
            Console.WriteLine("cual es el nombre del cliente que compra?");
            string nombrecliente = Console.ReadLine();
            for (int i = 0; i < Listaclientes.Count; i++)
            {
                if (Listaclientes[i].Nombre == nombrecliente)
                {
                    continue;
                }
                else
                {
                    problema += "El nombre de cliente no se encuentra en la lista de nombres";
                    break;
                }
            }
            Console.WriteLine("cual es el nombre del cajero que atiende?");
            string nombrecajero = Console.ReadLine();
            for (int i = 0; i < ListaTrabajadores.Count; i++)
            {
                if (ListaTrabajadores[i].Nombre == nombrecajero && ListaTrabajadores[i].puesto == "cajero")
                {
                    continue;
                }
                else
                {
                    problema += "\nEl nombre del cajero no se encuentra en la lista de nombres";
                    break;
                }
            }
            Console.WriteLine("\nIngrese Fecha de compra:");
            string fecha = Console.ReadLine();
            Console.WriteLine("\nIngrese Hora de compra:");
            string hora = Console.ReadLine();
            if (problema == "")
            {
                compras.Add(new Compra(hora, fecha, nombrecliente, nombrecajero, ListadeCompra));
            }
            else
            {
                Console.WriteLine(problema);
            }
        }
        
        public void VerTrabajadores()
        {
            if (ListaTrabajadores.Count > 0)
            {
                Console.WriteLine("\nEsta es la lista de trabajadores:\n");
                for (int i = 0; i < ListaTrabajadores.Count; i++)
                {
                    Console.WriteLine(ListaTrabajadores[i].Informaciontrabajadores());
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nNo hay trabajadores en la lista de trabajadores\n");
            }
        }
        public void VerClientes()
        {
            if (Listaclientes.Count > 0)
            {
                Console.WriteLine("\nEsta es la lista de clientes:\n");
                for (int i = 0; i < Listaclientes.Count; i++)
                {
                    Console.WriteLine(Listaclientes[i].Informacionclientes());
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nNo hay clientes en la lista de clientes\n");
            }
        }
        public void VerProductos()
        {
            if (Listaproductos.Count > 0)
            {
                Console.WriteLine("\nEsta es la lista de productos:\n");
                for (int i = 0; i < Listaproductos.Count; i++)
                {
                    Console.WriteLine(Listaproductos[i].InformacionProductos());
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nNo hay productos en la lista de productoss\n");
            }
        }
        public void VerCompras()
        {
            if (compras.Count > 0)
            {
                Console.WriteLine("\nEsta es la lista de compras:\n");
                for (int i = 0; i < compras.Count; i++)
                {
                    Console.WriteLine(compras[i].InformacionCompra());
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nNo se han realizado compras\n");
            }
        }
        public void CambiarDePuesto()
        {
            if (ListaTrabajadores.Count>0)
            {
                Console.WriteLine("\nIngrese nombre del trabajador: ");
                string respuestanombre = Console.ReadLine();
                for (int i = 0; i < ListaTrabajadores.Count; i++)
                    if (ListaTrabajadores[i].Nombre == respuestanombre)
                    {
                        Console.WriteLine("\nIngrese el nuevo puesto: (cajero / supervisor/ jefe / auxiliar)");
                        string respuestapuesto = Console.ReadLine();
                        if (respuestapuesto == "cajero" || respuestapuesto == "supervisor" || respuestapuesto == "jefe" || respuestapuesto == "auxiliar")
                        {
                            ListaTrabajadores[i].puesto = respuestapuesto;
                            Console.WriteLine("\nUsted ha cambiado el puesto de trabajo de forma efectiva. ");
                        }
                        else
                        {
                            Console.WriteLine("\nUsted ha ingresado un puesto de trabajo erroneo. ");
                        }
                    }
                else
                    {
                        Console.WriteLine("Ese trabajador no existe");
                    }
            }
            else
            {
                Console.WriteLine("\nNo hay Trabajadores en la lista de trabajadores.");
            }     
        }
        public void CambiarDeSueldo()
        {
            if (ListaTrabajadores.Count > 0)
            {
                Console.WriteLine("\nIngrese nombre del trabajador: ");
                string respuestanombre = Console.ReadLine();
                for (int i = 0; i < ListaTrabajadores.Count; i++)
                    if (ListaTrabajadores[i].Nombre == respuestanombre)
                    {
                        Console.WriteLine("\nIngrese el nuevo sueldo:");
                        string respuestasueldo = Console.ReadLine();
                        
                        ListaTrabajadores[i].sueldo = respuestasueldo;
                        Console.WriteLine("\nUsted ha cambiado el sueldo de forma efectiva. ");
                    }
                    else
                    {
                        Console.WriteLine("Ese trabajador no existe");
                    }
            }
            else
            {
                Console.WriteLine("\nNo hay Trabajadores en la lista de trabajadores.");
            }
        }
        public void CambiarHorario()
        {
            if (ListaTrabajadores.Count > 0)
            {
                Console.WriteLine("\nIngrese nombre del trabajador: ");
                string respuestanombre = Console.ReadLine();
                for (int i = 0; i < ListaTrabajadores.Count; i++)
                    if (ListaTrabajadores[i].Nombre == respuestanombre)
                    {
                        Console.WriteLine("\nIngrese el nuevo horario:");
                        string horario = Console.ReadLine();
                        ListaTrabajadores[i].Horario = horario;
                        Console.WriteLine("\nUsted ha cambiado el horario de forma efectiva. ");
                    }
                    else
                    {
                        Console.WriteLine("Ese trabajador no existe");
                    }
            }
            else
            {
                Console.WriteLine("\nNo hay Trabajadores en la lista de trabajadores.");
            }
        }
    }
}