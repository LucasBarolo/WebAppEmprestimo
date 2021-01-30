using System;
using System.ComponentModel.DataAnnotations;


namespace WebAppEmprestimo.Models
{
    public class DadosCliente
    {
        [Required(ErrorMessage = "Preencha seu nome completo")]
        [Display(Name ="Nome completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Preencha seu Endereço completo")]
        [Display(Name = "Endereço completo")]
        public string EnderecoCompleto { get; set; }

        [Required(ErrorMessage = "Preencha seu Data de Nascimento")]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha seu sexo.")]

        public string Sexo { get; set; }

        [Required(ErrorMessage = "Preencha seu Estado Civil")]
        public string EstadoCivil { get; set; }

        
    }
}