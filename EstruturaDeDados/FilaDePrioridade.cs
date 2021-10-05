using EstruturaDeDados.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    public class FilaDePrioridade<T> where T : EntidadeComPrioridade
    {
        private T[] _itens;
        public FilaDePrioridade(T[] itens) 
        {
            if (itens == null || itens.Any()) throw new InvalidOperationException("Array nulo ou vazio!");
            _itens = itens;
        }

        public void Limpar() { }

        public void Consultar(string valor) { }

        public void Inserir(T paciente) 
        {
            const int proximo = 1;
            int ultimoIndice = _itens.Length - proximo;
            const int primeiroIndice = 0;

            while (ultimoIndice >= primeiroIndice 
                   && PrioridadeDoPacienteAtualEMaiorQue(_itens[ultimoIndice].Prioridade, paciente.Prioridade)) 
            {
                _itens[ultimoIndice + proximo] = paciente;
                ultimoIndice--;
            }
        }

        private bool PrioridadeDoPacienteAtualEMaiorQue(int prioridadeDoPaciente, int novaPrioridade) 
        {
            return prioridadeDoPaciente >= novaPrioridade;
        }

        public void Remover() { }

        public int ObtenhaTamanho() => _itens.Length;
    }
}
