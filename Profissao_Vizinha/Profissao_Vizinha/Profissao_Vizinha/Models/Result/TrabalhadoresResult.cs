using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ProfissaoVizinha.Models.Result
{
    public class TrabalhadoresResult
    {
        public int Codigo { get; set; }
        public String Mensagem { get; set; }
        public String Token { get; set; }
        public String Ticket { get; set; }
        public List<TrabalhadorResult> Trabalhadores { get; set; }
    }
}