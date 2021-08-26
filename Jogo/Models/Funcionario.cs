using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jogo.Models
{
    public class Funcionario
    {
        [Display(Name = "Código de Identificação")]
        [Range(1, 4, ErrorMessage = "O código deve ter de 1 a 4 dígitos")]
        public ushort FuncCod { get; set; }

        [Display(Name = "Nome do Funcionário")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string FuncNome { get; set; }

        [Display(Name = "CPF do funcionário")]
        [RegularExpression(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}", ErrorMessage = "Valor Inválido")]
        public string CPFFunc { get; set; }

        [Display(Name = "RG do funcionário")]
        [RegularExpression(@"(^\d{1,3}).?(\d{3}).?(\d{3})-?(\d{1}|X|x$)", ErrorMessage = "Valor Inválido")]
        public string RGFunc { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Data de nascimento obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime FuncDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue
                ? this.funcDtNasc.Value
               : DateTime.Now;
            }
            set
            {
                this.funcDtNasc = value;
            }
        }
        private DateTime? funcDtNasc = null;

        [Display(Name = "Email do funcionário")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Formato de e-mail inválido")]
        public string EmailFunc { get; set; }

        [Display(Name = "Telefone celular do funcionário")]
        [RegularExpression(@"^\([1-9]{2}\) [9]{0,1}[6-9]{1}[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Formato de telefone inválido")]
        public string CelFunc { get; set; }

        [Display(Name = "Cargo do funcionário")]
        [Required(ErrorMessage = "O cargo é obrigatório")]
        public string Cargo { get; set; }

        [Display(Name = "Endereço do funcionário")]
        [Required(ErrorMessage = "Nome da rua e número.")]
        public string EnderecoFunc { get; set; }

    }
}