﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();



        public void incrementarQteMovimentos()
        {
            this.qteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            this.qteMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0;i<tab.linhas; i++)
            {
                for(int j = 0;j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool movimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.linha, pos.coluna];
        }

    }
}
