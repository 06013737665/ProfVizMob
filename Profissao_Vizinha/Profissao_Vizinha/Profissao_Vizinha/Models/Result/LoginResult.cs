using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ProfissaoVizinha.Models.Result
{
    public class LoginResult
    {
        public int Codigo { get; set; }
        public String Mensagem { get; set; }
        public String Token { get; set; }
        public Trabalhador Trabalhador { get; set; }
    }
}