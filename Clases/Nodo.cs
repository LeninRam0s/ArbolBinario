using System;

namespace ArbolBinarioCSharp.Clases.ArbolBinario
{
    class Nodo
    {
        //object para almacenar cualquier dato
        protected object dato;
        protected Nodo izquierda;
        protected Nodo derecha;

        //nodo padre
        public Nodo(object valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;
        }

        //propiedades hijo
        public Nodo(Nodo ramaIzquierda, object valor, Nodo ramaDerercha)
        {
            dato = valor;
            izquierda = ramaIzquierda;
            derecha = ramaDerercha;
        }

        //retorna el valor del nodo xq esta protegido
        public object valorNodo()
        {
            return dato;
        }

        public Nodo subArbolDerecho()
        {
            return derecha;
        }

        public Nodo subArbolIzquierda()
        {
            return izquierda;
        }

        //accesos para asignar valor
        public void nuevoValor(object nv)
        {
            dato = nv;

        }

        //asignar valor a las ramas

        public void ramaIzq(Nodo n)
        {
            izquierda = n;
        }

        public void ramaDer(Nodo n)
        {
            derecha = n;
        }

        public void visitar()
        {
            Console.WriteLine(dato + "<->");
        }


    }
}
