using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_API.Models
{
    public class Venda
    {
       public int NumeroPedido { get; set; }
       public DateTime Data { get; set; }
       public int CodigoProduto { get; set; }
       public string NomeProduto { get; set; }
       public int IdVendedor { get; set; }
       public string NomeVendedor { get; set; }
       public string CpfVendedor { get; set; }
       public string EmailVendedor { get; set; }
       public string TelefoneVendedor { get; set; }
       public EnumStatusPedido Pagamento { get; set; }
       public EnumStatusPedido Entrega { get; set; }
    }
}