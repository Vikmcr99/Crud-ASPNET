﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoAniversarios.Models
{
    public class Aniversariante
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
