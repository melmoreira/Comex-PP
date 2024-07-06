using AutoMapper;
using ComexApiT1.Data;
using ComexApiT1.Dtos;
using ComexApiT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComexApiT1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private ComexApiContext _context;
        private IMapper _mapper;

        public EnderecoController(ComexApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost] 
        public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return Ok(enderecoDto);
        }

        [HttpGet]
        public IActionResult RecuperarEnderecos()
        {
            var enderecos = _context.Enderecos.ToList();
            return Ok(_mapper.Map<List<ReadEnderecoDto>>(enderecos));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarEnderecoPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);
            if(endereco != null)
            {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return Ok(enderecoDto);
            }
            return NotFound("Endereço Nao encontrado!");
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarEndereco(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
