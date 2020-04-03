﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using tabuleiro.Enums;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab,cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
