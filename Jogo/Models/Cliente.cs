using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jogo.Models
{
    public class Cliente
    {
        [Display(Name ="Nome do Cliente")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string CliNome { get; set; }

        [Display(Name = "CPF do Cliente")]
        [RegularExpression(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}", ErrorMessage = "Valor Inválido")]
        public string CliCPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime CliDtNasc
        {
            get
            {
                return this.cliDtNasc.HasValue
                ? this.cliDtNasc.Value
               : DateTime.Now;
            }
            set
            {
                this.cliDtNasc = value;
            }
        }
        private DateTime? cliDtNasc = null;

        [Display(Name = "Email do Cliente")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Formato de e-mail inválido")]
        public string EmailCli { get; set; }

        [Display(Name = "Telefone celular do Cliente")]
        [RegularExpression(@"^\([1-9]{2}\) [9]{0,1}[6-9]{1}[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Formato de telefone inválido")]
        public string CelCli { get; set; }

        [Display(Name = "Endereço do Cliente")]
        [Required(ErrorMessage = "Nome da rua e número.")]
        public string EnderecoCli { get; set; }

    }
}