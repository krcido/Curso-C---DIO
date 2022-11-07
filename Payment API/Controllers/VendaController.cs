using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Payment_API.Models;
using Payment_API.Context;


namespace Payment_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaContext _context;

        public VendaController(VendaContext context)
        {
            _context = context;
        }

       [HttpPost]
       public IActionResult Criar(Venda venda)
       {
           if (venda.Data == DateTime.MinValue)
               
           return BadRequest(new { Erro = "A data da venda não pode ser vazia" });

           _context.Add(venda);
           _context.SaveChanges();
           return Ok(venda);
       }

       [HttpGet("{Procurar Venda}")]
       public IActionResult ObterPorId(int NumeroPedido)
       {
           var venda = _context.Vendas.Find(NumeroPedido);
           
           if (venda == null)
               return NotFound ();
               
           return Ok(venda);
       }

       [HttpPut("{Status Pagamento}")]
       public IActionResult AtualizarPagamento(EnumStatusPedido NumeroPedido, Venda venda)
       {
           var vendaBanco = _context.Vendas.Find(NumeroPedido);

           if(vendaBanco == null)
              return NotFound();

            vendaBanco.Pagamento = venda.Pagamento;      

           _context.Vendas.Update(vendaBanco);
           _context.SaveChanges();

            return Ok(vendaBanco);
       }

        [HttpPut("{Status Entrega}")]
        public IActionResult AtualizarEntrega(EnumStatusPedido NumeroPedido, Venda venda)
         {
           var vendaBanco = _context.Vendas.Find(NumeroPedido);

           if(vendaBanco == null)
              return NotFound();

            vendaBanco.Entrega = venda.Entrega;     

           _context.Vendas.Update(vendaBanco);
           _context.SaveChanges();

            return Ok(vendaBanco);
        }

        [HttpDelete("{Apagar Venda}")]
       public IActionResult Deletar(int NumeroPedido)
       {
           var vendaBanco = _context.Vendas.Find(NumeroPedido);

           if(vendaBanco == null)
              return NotFound();

          _context.Vendas.Remove(vendaBanco);
          _context.SaveChanges();

          return NoContent();
       }

    }
}