using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class ArrayList <E>
    {
        private E[] list;
        private int tamanho, capacidade;

        public ArrayList()
        {
            capacidade = 10;
            tamanho = 0;
            list = new E[capacidade];
        }

        public void Adicionar(E element)
        {
            Capacidade();
            list[tamanho] = element;
            this.tamanho++;
        }

        public void Adicionar(int indice, E element)
        {
            Capacidade();
            for (int i = tamanho; i > indice; i--)
            {
                list[i] = list[i - 1];
            }
            list[indice] = element;
            this.tamanho++;
        }

        public E Obter(int indice)
        {
            return list[indice];
        }

        public E Remover(int indice)
        {
            E elementRemove = list[indice];
            list[indice] = default(E);
            for (int i = indice; i < tamanho; i++)
            {
                list[i] = list[i + 1];
            }
            this.tamanho--;
            return elementRemove;
        }

        public int Tamanho()
        {
            return this.tamanho;
        }

        public bool Vazio()
        {
            return this.tamanho == 0 ;
        }

        private void Capacidade()
        {
            if (tamanho == capacidade)
            {
                capacidade = capacidade + 10;
                E[] newList = new E[capacidade];
                for (int i = 0; i < tamanho; i++)
                {
                    newList[i] = list[i];
                }
                list = newList;
            }
        }

    }
    
}
