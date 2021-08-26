using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jogo.Models
{
    public class JogoClasse
    {
        [Display(Name = "Código de identificação")]
        [Range(1, 4, ErrorMessage = "O código deve ter de 1 a 4 dígitos")]
        public ushort JogoCod { get; set; }

        [Display(Name = "Nome do jogo")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string JogoNome { get; set; }

        [Display(Name = "Versão")]
        public string Versao { get; set; }

        [Display(Name = "Desenvolvedor")]
        [Required(ErrorMessage = "Coloque o Desenvolvedor")]
        public string JogoDesenvolvedor { get; set; }

        [Display(Name = "Gênero do jogo")]
        [Required(ErrorMessage = "Coloque o Gênero do jogo")]
        public string GeneroJogo { get; set; }

        [Display(Name = "Faixa etária")]
        [Required(ErrorMessage = "Coloque a faixa etária")]
        public string FaixaEtaria { get; set; }

        [Display(Name = "Plataforma disponível")]
        [Required(ErrorMessage = "Coloque a plataforma disponível")]
        public string Plataforma { get; set; }

        [Display(Name = "Ano de lançamento")]
        [Required(ErrorMessage = "Coloque o Ano de lançamento")]
        public string AnoLanc { get; set; }

        [Display(Name = "Sinopse do jogo")]
        [Required(ErrorMessage = "Coloque a Sinopse do jogo")]
        public string Sinopse { get; set; }
    }
}