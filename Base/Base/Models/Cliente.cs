﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Base.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}