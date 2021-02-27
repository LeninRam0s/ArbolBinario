using ArbolBinarioCSharp.Clases.ArbolBinario;
using System;
using System.Collections;

namespace ArbolBinarioCSharp
{
    class Program
    {
        public static void preorden(Nodo r)
        {
            if (r != null)
            {

                preorden(r.subArbolIzquierda());
                r.visitar();
                preorden(r.subArbolDerecho());

            }
        }

        public static void inorden(Nodo r)
        {
            if (r != null)
            {
                inorden(r.subArbolIzquierda());
                inorden(r.subArbolDerecho());
                r.visitar();
            }

        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                postorden(r.subArbolIzquierda());
                postorden(r.subArbolDerecho());

            }

        }


        static void Main(string[] args)
        {


            try
            {
                ArbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();

                //SUBARBOL IZQUIERDO
                a1 = ArbolBinario.NuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.NuevoArbol(null, "Fabricio", null);
                a = ArbolBinario.NuevoArbol(a1, "Gaby", a2);
                pila.Push(a);//apilar

                //SUBARBOL DERECHO
                a1 = ArbolBinario.NuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.NuevoArbol(null, "Abel", null);
                a = ArbolBinario.NuevoArbol(a1, "Monica", a2);
                pila.Push(a);//apilar

                //invertir a2 * a1
                a2 = (Nodo)pila.Pop();
                a1 = (Nodo)pila.Pop();

                //crea raiz
                a = ArbolBinario.NuevoArbol(a1, "Hector", a2);
                arbol = new ArbolBinario(a);
                int pause;
                pause = 0;

                Console.WriteLine("Preorden");
                preorden(a);

                Console.WriteLine("\nPostorden");
                postorden(a);

                Console.WriteLine("\nInorden");
                inorden(a);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error!!! " + ex.Message);
            }





        }
    }
}
