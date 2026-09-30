using System;

namespace Exercicio_06.Models
{
    public class Mensagem
    {
        public string? texto { get; set; } = "";
        public string? erro { get; set; } = "";

        public string? operacao {get; set;}
        
        public double? numero1 { get; set; } 
        public double? numero2 { get; set; } 
        public double? resultado { get; set; } 
    }
}