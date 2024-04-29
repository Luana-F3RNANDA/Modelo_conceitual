﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Modelo_conceitual
{
    public class Compra
    {
        public SoapInteger id {  get; set; }
        public DateTime instante { get; set; }
        public string descricao { get; set; }
        public double desconto { get; set; }
        public double valor_total { get; set; }

        public Fornecedor fornecedor { get; set; }
    }
}