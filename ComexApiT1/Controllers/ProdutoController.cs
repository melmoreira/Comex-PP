using AutoMapper;
using ComexApiT1.Data;
using ComexApiT1.Dtos.Produtos;
using ComexApiT1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComexApiT1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ComexApiContext _context;
        private IMapper _mapper;

        public ProdutoController(ComexApiContext context,  IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarProduto([FromBody] CreateProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok("Produto adicionado com sucesso!");
        }

        [HttpGet]
        public IActionResult ListarProdutos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(_mapper.Map<List<ReadProdutoDto>>(produtos));
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, [FromBody] UpdateProdutoDto produtoDto) 
        { 
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null) 
            {
                return NotFound("Produto não encontrado");
            }

            _mapper.Map(produtoDto, produto);
            _context.SaveChanges();

            return Ok("Produto Atualizado com Sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult ApagarProduto(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok("Produto apagado com sucesso!");
        }
    }
}
