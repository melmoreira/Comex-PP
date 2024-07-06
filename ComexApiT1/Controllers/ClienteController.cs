using AutoMapper;
using ComexApiT1.Data;
using ComexApiT1.Dtos;
using ComexApiT1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComexApiT1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ComexApiContext _context;
        private IMapper _mapper;

        public ClienteController(ComexApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] CreateClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(clienteDto);
        }

        [HttpGet]
        public IActionResult RecuperarClientes()
        {
            var clientes = _context.Clientes.ToList();
            return Ok(_mapper.Map<List<ReadClienteDto>>(clientes));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(e => e.Id == id);
            if (cliente != null)
            {
                ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
                return Ok(clienteDto);
            }
            return NotFound("Cliente Nao encontrado!");
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(e => e.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _mapper.Map(clienteDto, cliente);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCliente(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(e => e.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Remove(cliente);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
