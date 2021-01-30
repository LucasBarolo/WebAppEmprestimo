using System;
using System.Collections.Generic;
using WebAppEmprestimo.Models;

namespace WebAppEmprestimo.Negocio
{
    public class RegraNegocio
    {
        public List<PropostaEmprestimo> CalculoPropostaEmprestimo(PropostaEmprestimo proposta)
        {
            List<PropostaEmprestimo> ListaProposta = new List<PropostaEmprestimo>();
            PropostaEmprestimo emprestimo;
            int qtdDiasInicio = 0;
            double _math = 0;
            if (proposta != null)
            {
                proposta.ParcelaPrincipal = proposta.ValorEmprestimo / proposta.QtdParcela;

                for (int i = 1; i <= proposta.QtdParcela; i++)
                {

                    emprestimo = new PropostaEmprestimo();
                    emprestimo.ParcelaPrincipal = proposta.ParcelaPrincipal;
                    qtdDiasInicio = qtdDiasInicio + 30;
                    emprestimo.Parcela = i;
                    _math = Math.Pow((1 + proposta.TaxaJuros / 100), (qtdDiasInicio / 30) - 1);
                    emprestimo.JurosLinear = proposta.ParcelaPrincipal * proposta.TaxaJuros * qtdDiasInicio / (100 * 30);
                    emprestimo.JurosExponencial = emprestimo.JurosLinear * _math;
                    emprestimo.ParcelaLinear = proposta.ParcelaPrincipal + emprestimo.JurosLinear;
                    emprestimo.ParcelaExponencial = proposta.ParcelaPrincipal + emprestimo.JurosExponencial;

                    emprestimo.JurosLinear = Math.Round(emprestimo.JurosLinear, 2);
                    emprestimo.JurosExponencial = Math.Round(emprestimo.JurosExponencial, 2);
                    emprestimo.ParcelaLinear = Math.Round(emprestimo.ParcelaLinear, 2);
                    emprestimo.ParcelaExponencial = Math.Round(emprestimo.ParcelaExponencial, 2);
                    ListaProposta.Add(emprestimo);
                }

            }

            return ListaProposta;
        }
    }
}