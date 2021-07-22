using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ProfissaoVizinha.Models.Result
{
    public class TrabalhadorResult
    {
        
        public long Id { get; set; }
        public string NomeTrabalhador { get; set; }
        public long Cep { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public byte[] FotoPerfil { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}