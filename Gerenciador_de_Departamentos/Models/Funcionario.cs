﻿namespace Gerenciador_de_Departamentos.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public int RG { get; set; }
        public Departamento Departamento { get; set; }
    }
}
