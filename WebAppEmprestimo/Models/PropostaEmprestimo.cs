using System.ComponentModel.DataAnnotations;

namespace WebAppEmprestimo.Models
{
    public class PropostaEmprestimo
    {
        public DadosCliente ClienteProposta { get; set; }

        [Display(Name ="Identificador Proposta")]
        public int IdProposta { get; set; }

        [Display(Name = "Valor Empréstimo")]
        public double ValorEmprestimo { get; set; }

        [Display(Name = "Quantidade de Parcelas")]
        public int QtdParcela { get; set; }

        [Display(Name = "Taxa de Juros")]
        public double TaxaJuros { get; set; }

        [Display(Name = "Juros Linear")]
        public double JurosLinear { get; set; }

        [Display(Name = "Juros Exponencial")]
        public double JurosExponencial { get; set; }

        [Display(Name = "Parcela Principal")]
        public double ParcelaPrincipal { get; set; }

        [Display(Name = "Parcela Linear")]
        public double ParcelaLinear { get; set; }

        [Display(Name = "Parcela Exponencial")]
        public double ParcelaExponencial { get; set; }

        [Display(Name = "Parcela")]
        public int Parcela { get; set; }
    }
}