using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pump.Api.ViewModel;
using Pump.Domain.Interfaces;
using MediatR;
using Pump.Apllication.Commands;
using Pump.Apllication.Querys;

namespace Pump.Api.Controllers
{
    [Route("[controller]")]
    public class ElementoPumpController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IRepository _repositoryElemento;

        public ElementoPumpController(IRepository repositoryElemento, IMapper mapper, IMediator mediator)
        {
            _repositoryElemento = repositoryElemento;
            _mapper = mapper;
            _mediator = mediator;
        }

        /// <summary>
        /// Retornar informações sobre o produto (elemento) gym
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetElementoId(int id)
        {
            var retorno = await _mediator.Send(new ConsultarElementoPumpQuery(id));
            if (retorno != null)
            {
                return Ok(retorno);
            }

            return NotFound(); 
        }

        /// <summary>
        /// Inserindo produto (elemento) gym Mediator
        /// <remarks>
        /// <list>
        /// <item>aaaaa</item>
        /// <item>aaaaa</item>
        /// </list>
        /// </remarks>
        /// </summary>
        /// <param name="addmodel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] AdicionaElementoPumpViewModel addmodel)
        {
            var retorno = await _mediator.Send(new CadastrarElementoPumpCommand(addmodel.Nome, addmodel.Valor, addmodel.Gramas));
            if(retorno)
            {
                return Accepted();
            }

            return NotFound();

        }

        /// <summary>
        /// Alterando produto (elemento) gym Mediator
        /// </summary>
        /// <param name="atualizamodel"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AtualizarElementoPumpViewModel atualizamodel)
        {
            var retorno = await _mediator.Send(new AtualizarElementoPumpCommand(atualizamodel.Id, atualizamodel.Nome, atualizamodel.Valor, atualizamodel.Gramas));
            if (retorno)
            {
                return NoContent();
            }

            return NotFound();
        }

        /// <summary>
        /// Deletando produto (elemento) gym Mediator
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var retorno = await _mediator.Send(new DeletarElementoPumpCommand(id));
            if (retorno)
            {
                return NoContent();
            }

            return NotFound();   
        }        
    }
}