using EstruturaDeDados.Dominio;
using System;

namespace EstruturaDeDados
{
    public class Arvore
    {
        public No Raiz { get; private set; }

        public Arvore(No raiz) 
        {
            Raiz = raiz;
        }

        public int ObtenhaAltura() 
        {
            if (Raiz == null) throw new ArgumentNullException("Sem elementos na árvore.");
            if (Raiz.Direita == null && Raiz.Esquerda == null) return 0;

            int alturaDireita = 0;
            int alturaEsquerda = 0;

            while (Raiz.Direita != null)
                alturaDireita++;
            while (Raiz.Esquerda != null)
                alturaEsquerda++;

            return alturaDireita >= alturaEsquerda ? alturaDireita : alturaEsquerda;
        }
    }
}
