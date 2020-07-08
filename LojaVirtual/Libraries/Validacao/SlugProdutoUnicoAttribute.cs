using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Validacao
{
    public class SlugProdutoUnicoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IProdutoRepository _produtoRepository = (IProdutoRepository)validationContext.GetService(typeof(IProdutoRepository));
            Produto produto = (Produto)validationContext.ObjectInstance;

            if (produto.Id == 0)
            {
                Produto produtoDB = _produtoRepository.ObterProdutoSlug(produto.Slug);
                if (produtoDB == null)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
            }
            else
            {
                Produto produtoDB = _produtoRepository.ObterProdutoSlug(produto.Slug);

                if (produtoDB == null)
                {
                    return ValidationResult.Success;
                }
                else if (produtoDB.Id == produto.Id)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
            }
        }
    }
}