using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbolito
{
    class Arbolito
    {
        // Ciertas variables perronas
        int a = 0, b = 2, Alturita = 0, Niveles = 0;
        // Metodo con el que se agregan los valores perrones 
        public void AgregadodeNodo(Nodo nodito, string nombre, string[] nombresito) 
        {
            if (nodito.Arreglo != null) 
            {
                foreach (Nodo item in nodito.Arreglo) 
                {
                    AgregadodeNodo(item, nombre, nombresito);  
                }
            }
            else  
            {
                if (nodito.Name == nombre)  
                {
                    nodito.Arreglo = new Nodo[nombresito.Length]; 
                    for (int i = 0; i < nombresito.Length; i++)
                    {
                        nodito.Arreglo[i] = new Nodo(nombresito[i]); 
                    }
                }
            }
        }
        //Impresion del nodo perron
        public void ImprimirelNodo(Nodo nodito)
        {

            if (nodito.Arreglo != null) 
            {
                Console.SetCursorPosition(a, b);
                Console.Write(nodito.Name); 
                a = a + 5;
                ++b;
                for (int i = 0; i < nodito.Arreglo.Length; i++)
                {
                    ImprimirelNodo(nodito.Arreglo[i]); 
                }
                a += 5;
            }
            else
            {
                Console.SetCursorPosition(a, b);
                Console.Write(nodito.Name); 

                ++b; 

            }
            //Altura
            Alturita = (b - 2) / 2; 
            Niveles = Alturita;
        }
        // Metodo de arbol perron C donde se construye
        public void Arbolperronc()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("\n.......................................");
            Console.WriteLine("Arbolperron C)");
            Nodo NodoRaiz = new Nodo("K");       
            AgregadodeNodo(NodoRaiz, "K", new string[] { "B", "A", "C", "D" });  
            AgregadodeNodo(NodoRaiz, "D", new string[] { "I    J", "E", }); 
            AgregadodeNodo(NodoRaiz, "E", new string[] { "F", "G" });
            AgregadodeNodo(NodoRaiz, "G", new string[] { "H" });
            ImprimirelNodo(NodoRaiz);  
            ImprimirlosDatosC();
            Console.WriteLine("\nPulse una tecla :)");
            Console.WriteLine("\n.......................................");
            Console.ReadKey();
        }
        // Metodo de arbol perron A donde se construye
        public void ArbolperronA()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("\n.......................................");
            Console.WriteLine("Arbol perron A)");
            Nodo NodoRaiz = new Nodo("G");       
            AgregadodeNodo(NodoRaiz, "G", new string[] { "F", "A" });  
            AgregadodeNodo(NodoRaiz, "A", new string[] { "B", "C", "D" });
            ImprimirelNodo(NodoRaiz); 
            ImprimirlosDatosA(); 
            Console.WriteLine("\nPulse una tecla :)");
            Console.WriteLine("\n.......................................");
            Console.ReadKey();
        }
        // Metodo de arbol perron B donde se construye
        public void ArbolperronB()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("\n.......................................");
            Console.WriteLine("Arbol perron B)");
            Nodo NodoRaiz = new Nodo("C");       
            AgregadodeNodo(NodoRaiz, "C", new string[] { "D", "F", "G", "A" });  
            AgregadodeNodo(NodoRaiz, "A", new string[] { "B" });
            AgregadodeNodo(NodoRaiz, "B", new string[] { "E" });
            ImprimirelNodo(NodoRaiz); 
            ImprimirlosDatosB(); 
            Console.WriteLine("\nPulse una tecla :) ");
            Console.WriteLine("\n.......................................");
            Console.ReadKey();
        }
        // metodo perrisisimo
        public void ImprimirlosDatosC() 
        {
            Console.WriteLine("\n.......................................");
            Console.WriteLine("\n\n\nLa altura es: {0}", Alturita - 1);
            Console.WriteLine("de K hasta H es: K>D>E>G>H");
            Console.WriteLine("El nivel es: {0}", Niveles - 1);
            Console.WriteLine("de K hasta C es: K>C");
            Console.WriteLine("de K hasta H es: K>D>E>G>H");
            Console.WriteLine("de K hasta J es: K>D>I>J");
            Console.WriteLine("\n.......................................");
        }
        // Metodo de imprecion perron 
        public void ImprimirlosDatosB() 
        {
            Console.WriteLine("\n.......................................");
            Console.WriteLine("\n\n\nLa altura es: {0}", Alturita);
            Console.WriteLine("de C hasta E es: C>A>B>E");
            Console.WriteLine("El nivel es: {0}", Niveles);
            Console.WriteLine("de C hasta C es: C");
            Console.WriteLine("de C hasta H es: No existe");
            Console.WriteLine("de C hasta J es: No existe");
            Console.WriteLine("\n.......................................");
        }
        // Metodo de impresion perrones
        public void ImprimirlosDatosA() 
        {
            Console.WriteLine("\n.......................................");
            Console.WriteLine("\n\n\nLa altura es: {0}", Alturita - 1);
            Console.WriteLine("de G hasta B, C o D es: G>A>B, C o D");
            Console.WriteLine("El nivel es: {0}", Niveles - 1);
            Console.WriteLine("de G hasta C es: G>A>C");
            Console.WriteLine("de G hasta H es: No existe ");
            Console.WriteLine("de G hasta J es: No existe ");
            Console.WriteLine("\n.......................................");
        }

        // Menu perron
        public void Meniu() 
        {
        Back:
            Console.Clear();
            Console.WriteLine("Introduzca el arbol que desea ver, pulse numero: \n1. Arbol perron A)\n2. Arbol perrisimo B)\n3. Super Arbol perron C)\n4. Salir de esta vaina");
            string Arbol = Console.ReadLine().ToUpper();
            if (Arbol == "1" || Arbol == "A")
            {
                ArbolperronA();
            }
            else if (Arbol == "2" || Arbol == "B")
            {
                ArbolperronB();
            }
            else if (Arbol == "3" || Arbol == "C")
            {
                Arbolperronc();
            }
            else if (Arbol == "4" || Arbol == "SALIR DE ESTA VAINA")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Error... Valor no valido.... Error.");
                Console.WriteLine("\nPulse una tecla...");
                Console.ReadKey();
                goto Back;
            }
        }
    }
}
