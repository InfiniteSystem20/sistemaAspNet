﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class Funcionario
    {
        // Id do funcionario
        [Key]
        [Display(Name = "Código ", Description = "Codigo.")]
        public int idFunc { get; set; }
        
        // Nome do funcionario
        [Display(Name = "Nome", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        // [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //    "Números e caracteres especiais não são permitidos no nome.")]
        public string nomeFunc { get; set; }
        
        // CPF do funcionario
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatorio")]
        public string cpfFunc { get; set; }
        
        // email do funcionario
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = " O Email não é valido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string emailFunc { get; set; }

        //Cargo do funcionario
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O cargo é obrigatorio")]
        public string cargo { get; set; }

        //Senha ou Password do funcionario
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O senha é obrigatorio")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 caracteres")]
        public string senhaFunc { get; set; }

        public Telefone telefone { get; set; }
        public Endereco endereco { get; set; }

        //Nivel de acesso
        [Display(Name = "Privilégio")]
        [Required(ErrorMessage = "O nivel de acesso é obrigatorio")]
        public string nivelAcesso { get; set; }

        //ENDEREÇO FUNCIONARIO
        [Display(Name = "Logradouro ", Description = "rua/avenida/praça")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //           "Números e caracteres especiais não são permitidos no nome.")]
        public string logradouro { get; set; }

        [Display(Name = "Número ", Description = "Número")]
        [Range(0, int.MaxValue, ErrorMessage = "Por favor coloque numero valido")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public int numero { get; set; }

        [Display(Name = "Complemento ", Description = "casa/apto/viela")]
       // [Required(ErrorMessage = "O nome completo é obrigatório.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //           "Números e caracteres especiais não são permitidos no nome.")]
        public string complemento { get; set; }

        [Display(Name = "Bairro ", Description = "Bairro")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //           "Números e caracteres especiais não são permitidos no nome.")]
        public string bairro { get; set; }

        [Display(Name = "CEP ", Description = "CEP")]
        ///[Range(0, int.MaxValue, ErrorMessage = "Por favor coloque numero valido")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string CEP { get; set; }

        [Display(Name = "Cidade ", Description = "Cidade")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //           "Números e caracteres especiais não são permitidos no nome.")]
        public string cidade { get; set; }

        [Display(Name = "Estado ", Description = "Estado")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //          "Números e caracteres especiais não são permitidos no nome.")]
        public string estado { get; set; }

        [Display(Name = "UF ", Description = "UF")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
                  "Números e caracteres especiais não são permitidos no nome.")]
        public string UF { get; set; }

        //TELEFONE
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O numero é obrigatorio")]
        public string numTel1 { get; set; }


        [Display(Name = "Residencial")]
        public string numTel2 { get; set; }


        [Display(Name = "Comercial")]
        public string numTel3 { get; set; }


    }
}
