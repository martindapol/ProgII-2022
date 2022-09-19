using PilasYColas__App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PilasYColas__App.Clases
{
    internal class Pila : IColeccion
    {
        private object[] array;
        private int contador;

        public Pila(int cantidad)
        {
            contador = -1;
            array = new object[cantidad];
        }

        public bool agregar(object elemento)
        {
            bool agregado = false;

            if (contador < array.Length)
            {
                array[++contador] = elemento;
                agregado = true;
            }

            return agregado;
        }

        public object cantidadElementos()
        {
            object elementos = null;
            int cantElem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != null)
                {
                    cantElem++;
                }
            }
            elementos = cantElem;
            return elementos;
        }

        public bool listaVacia()
        {
            return contador == -1;
        }

        public object extraer()
        {
            object elemento = null;

            if (!listaVacia())
            {
                elemento = array[contador];
                array[contador] = null;
                contador--;
            }
            return elemento;
        }

        public object primerElemento()
        {
            object elemento = null;
            if (!listaVacia())
            {
                elemento = array[0];
            }
            return elemento;
        }

        public object proximoEnSalir()
        {
            object elemento = null;
            if (!listaVacia())
                elemento = array[contador];
            return elemento;
        }
    }
    
}
