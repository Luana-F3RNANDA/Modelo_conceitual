﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        public int Id { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}

