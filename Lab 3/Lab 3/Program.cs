﻿using System;
using System.Threading;
using System.Collections.Generic;

namespace Lab_3
{
    class Program
    {
        static void Main()
        {
            Supermercado interaccion = new Supermercado();
            string e = "";
            while (e=="")
            {
                Console.WriteLine("\n1. Crear Trabajadores");
                Console.WriteLine("2. Crear Cliente");
                Console.WriteLine("3. Crear Producto");
                Console.WriteLine("4. Hacer Compra");
                Console.WriteLine("5. Ver lista de Trabajadores");
                Console.WriteLine("6. Ver lista de Clientes");
                Console.WriteLine("7. Ver lista de Productos");
                Console.WriteLine("8. Ver Todas las compras realizadas");
                Console.WriteLine("9. Cambiar a trabajador de Puesto");
                Console.WriteLine("10. Cambiar sueldo de trabajador");
                Console.WriteLine("11. Cambiar horario a trabajador");
                Console.WriteLine("12. Generar una Simulacion de Compra");
                Console.WriteLine("13. Salir");
                string quehacer = Console.ReadLine();
                string s;
                if (quehacer == "1")
                {
                    s = "s";
                    while (s == "s")
                    {
                        interaccion.CrearTrabajador();
                        Console.WriteLine("Desea seguir agregando Trabajadores?(si = s/ no = ingresa cualquier valor)");
                        s = Console.ReadLine();
                    }
                }
                else if (quehacer == "2")
                {
                    s = "s";
                    while (s == "s")
                    {
                        interaccion.CrearCliente();
                        Console.WriteLine("Desea seguir agregando Clientes?(si = s/ no = ingresa cualquier valor)");
                        s = Console.ReadLine();
                    }
                }
                else if (quehacer == "3")
                {
                    s = "s";
                    while (s == "s")
                    {
                        interaccion.CrearProductos();
                        Console.WriteLine("Desea seguir agregando productos?(si = s/ no = ingresa cualquier valor)");
                        s = Console.ReadLine();
                    }
                }
                else if (quehacer == "4")
                {                    
                    interaccion.BolsadeCompra();
                }
                else if (quehacer=="5")
                {
                    interaccion.VerTrabajadores();
                }
                else if (quehacer == "6")
                {
                    interaccion.VerClientes();
                }
                else if (quehacer == "7")
                {
                    interaccion.VerProductos();
                }
                else if (quehacer == "8")
                {
                    interaccion.VerCompras();
                }
                else if (quehacer=="9")
                {
                    interaccion.CambiarDePuesto();
                }
                else if (quehacer == "10")
                {
                    interaccion.CambiarDeSueldo();
                }
                else if (quehacer == "11")
                {
                    interaccion.CambiarHorario();
                }
                else if (quehacer == "12")
                {
                    Console.WriteLine("\nEjecutando Simulacion Aleatoria...\n");               
                    Simulacion inicio = new Simulacion();
                    inicio.HacerListadeProductos();
                    Console.WriteLine("Productos:");
                    inicio.VerProductos();
                    inicio.HacerListadeClientes();
                    inicio.HacerListadeJefes();
                    inicio.HacerListadeSupervisores();
                    inicio.HacerListadeAuxiliares();
                    inicio.HacerListadeCajeros();
                    int n = 0;
                    while(n<5)
                    {
                        inicio.BolsadeCompra();
                        n += 1;
                    }                   
                    Thread.Sleep(1000);
                    Console.WriteLine("\nClientes:");
                    inicio.VerClientes();
                    Thread.Sleep(1000);
                    Console.WriteLine("\nTrabajadores:");
                    inicio.VerJefe();
                    inicio.VerSupervisor();
                    inicio.VerAuxiliares();
                    inicio.VerCajero();
                    Thread.Sleep(1000);
                    inicio.VerComprass();
                    Thread.Sleep(1000);
                    Console.WriteLine("Stock actualizado:\n");
                    inicio.VerProductos();
                    Console.WriteLine("\nSIMULACION TERMINADA");
                }
                else if (quehacer == "13")
                {
                    e = "stop";
                }     
                else
                {
                    Console.WriteLine("Valor ingresado no valido");
                }
            }
        }
    }
}
 