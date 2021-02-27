using System;

namespace ArbolBinarioCSharp.Clases.ArbolBinario
{
    class ArbolBinario
    {
        protected Nodo raiz;

        //la raiz va nullo al inicio xq el arbol es nuevo
        public ArbolBinario()
        {
            raiz = null;
        }

        public ArbolBinario(Nodo ValorRaiz)
        {
            this.raiz = ValorRaiz;
        }

        //modificadores
        public Nodo raizArbol()
        {
            return raiz;
        }

        //funcion si el arbol esta vacion
        bool esVacio()
        {
            return raiz == null;//se usa este para evitar el if
        }

        //funcion estatica
        private static Nodo NuevoArbol(Nodo ramaIZQ, object dato, Nodo ramaDERE)
        {
            return new Nodo(ramaIZQ, dato, ramaDERE);
        }

        internal static Nodo NuevoArbol(object p1, string v, object p2)
        {
            throw new NotImplementedException();
        }
    }
}
