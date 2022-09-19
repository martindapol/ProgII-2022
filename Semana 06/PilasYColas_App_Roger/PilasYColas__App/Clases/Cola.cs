using PilasYColas__App.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas__App.Clases
{
    internal class Cola : IColeccion
    {
        private List<object> lista;
        private int contador;

        public Cola(int cantidad)
        {
            contador = -1;
            lista = new List<object>();
        }

        public bool agregar(object elemento)
        {
            bool elementoAgregadoOk = false;

            lista.Add(elemento);
            foreach (var e in lista)
            {
                if (e == elemento)
                {
                    elementoAgregadoOk = true;
                    contador++;
                }
            }

            return elementoAgregadoOk;
        }

        public object cantidadElementos()
        {
            object elementos = null;
            int cantElem = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                cantElem++;
            }
            elementos = cantElem;
            return elementos;
        }

        public object extraer()
        {
            object elemento = null;

            if (!listaVacia())
            {
                elemento = lista[contador - contador];
                lista.RemoveAt(contador - contador);
                contador--;
            }
            return elemento;
        }

        public bool listaVacia()
        {
            return contador == -1;
        }

        public object primerElemento()
        {
            object elemento = null;
            if (!listaVacia())
            {
                elemento = lista[contador - contador];
            }
            return elemento;
        }

        public object proximoEnSalir()
        {
            object elemento = null;
            if(!this.listaVacia())
                elemento = lista[contador - contador];
            return elemento;
        }
    }
}
