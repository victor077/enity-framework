using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoEFCore.ValuesObjects;

namespace CursoEFCore.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodigoBarras { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool Ativo { get; set; }
    }
}