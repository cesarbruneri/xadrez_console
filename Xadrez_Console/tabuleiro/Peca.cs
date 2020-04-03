﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using tabuleiro.Enums;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;            
            this.QtdMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
