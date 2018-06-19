﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto.Usuario
{
    public class UsuarioGetIdDto
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Sexo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Nacionalidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
