using TesteBRANEF.API.Application.Queries;
using TesteBRANEF.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OpenTracing;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
using TesteBRANEF.API.Application.Commands;

namespace TesteBRANEF.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteQueries _clienteQueries;
        private readonly IMediator _mediator;

        public ClienteController( IClienteQueries contratoPdfQueries, IMediator mediator)
        {
            _clienteQueries = contratoPdfQueries;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObterClientes()
        {
            try
            {
                var retorno = await _clienteQueries.ObterClientes();
                return new JsonResult(retorno);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro na busca");
            }
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarCliente(int id)
        {
            try
            {
                var retorno = await _clienteQueries.ConsultarCliente(id);
                return new JsonResult(retorno);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro na busca");
            }
        }

        [HttpPost]
        public async Task<IActionResult> InserirCliente(InserirClienteCommand inserirCliente)
        {
            try
            {
                var retorno = await _mediator.Send(inserirCliente);
                return new JsonResult("Cliente criado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro ao inserir");
            }
        }

        [HttpPut]
        public async Task<IActionResult> AlterarCliente(AlterarClienteCommand alterarCliente)
        {
            try
            {
                var retorno = await _mediator.Send(alterarCliente);
                return new JsonResult("Cliente alterado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro ao inserir");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoverCliente(int id)
        {
            try
            {
                var removerCliente = new RemoverClienteCommand() { Id = id};
                var retorno = await _mediator.Send(removerCliente);
                return new JsonResult("Cliente Removido com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro ao inserir");
            }
        }
    }
}
