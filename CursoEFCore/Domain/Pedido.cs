using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoEFCore.ValuesObjects;

namespace CursoEFCore.Domain
{
    public class Pedido
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public Cliente? Cliente { get; set; }

        public DateTime IniciadoEm { get; set; }

        public DateTime FinalizadaEm { get; set; }

        public TipoFrete TipoFrete { get; set; }

        public StatusPedido StatusPedido {get; set;}
        
        public string? Observacao {get; set;}

        public ICollection<PedidoItem>? Items {get; set;}

    }
}