﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Heranca
{
    public class Juridica : Pessoa
    {
        public string Cnpj { get; set; }

        public Boolean ValidarCnpj()
        {
            return Cnpj.Length == 14;
        }
    }
}
