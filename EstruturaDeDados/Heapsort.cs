using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    public class Heapsort
    {
        private const string _mensagemNuloOuVazio = "O vetor é nulo ou não contém elementos";
        private const string _mensagemDeNaoOrdenacao = "O vetor não está ordenado";
        public bool EstaOrdenado { get; private set; }

        private int[] _array;
        private const int _primeiraPosicao = 0;
        public int[] Array => !EstaOrdenado ? throw new Exception(_mensagemDeNaoOrdenacao) : _array;
        public Heapsort(int[] array) 
        {
            if (array == null || !array.Any()) throw new InvalidOperationException(_mensagemNuloOuVazio);
            _array = array;
        }

        public void Ordene() 
        {
            int temp;
            int meio = (_array.Length - 1) / 2;

            for (int indice = meio; indice >= _primeiraPosicao; indice--)
                CrieHeap(_array, indice, _array.Length - 1);

            for (int indice = _array.Length - 1; indice >= 1; indice--)
            {
                temp = _array[_primeiraPosicao];
                _array[_primeiraPosicao] = _array[indice];
                _array[indice] = temp;

                CrieHeap(_array, _primeiraPosicao, indice - 1);
            }
        }

        private void CrieHeap(int[] array, int indice, int ultimoIndice)
        {
            int temp = array[indice];
            int proximoIndice = indice * 2 + 1;
            while (proximoIndice <= ultimoIndice)
            {
                if (proximoIndice < ultimoIndice)
                    if (array[proximoIndice] < array[proximoIndice + 1])
                        proximoIndice += 1;

                if (temp < array[proximoIndice])
                {
                    array[indice] = array[proximoIndice];
                    indice = proximoIndice;
                    proximoIndice = 2 * indice + 1;
                }
                else
                {
                    proximoIndice = ultimoIndice + 1;
                }
            }

            array[indice] = temp;
        }

    }
}
