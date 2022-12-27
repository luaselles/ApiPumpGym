using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pump.Api.ViewModel;
using Pump.Domain.Entity;
using Pump.Domain.Interfaces;

namespace Pump.Api.Controllers
{
    [Route("[controller]")]
    public class ElementoPumpController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repositoryElemento;

        public ElementoPumpController(IRepository repositoryElemento, IMapper mapper)
        {
            _repositoryElemento = repositoryElemento;
            _mapper = mapper;
        }

        /// <summary>
        /// Retornar informações sobre o produto (elemento) gym
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetElementoId(int id)
        {
            var elementoEncontrado = _repositoryElemento.GetElementoId(id);
            if (elementoEncontrado != null)
            {
                var elementoMapeado = _mapper.Map<ElementoDetalheViewModel>(elementoEncontrado);
                return Ok(elementoEncontrado);
            }
            return NotFound();
        }

        /// <summary>
        /// Inserindo produto (elemento) gym
        /// </summary>
        /// <param name="addmodel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Insert ([FromBody] AdicionaElementoPumpViewModel addmodel)
        {
            var elementoAdd = _mapper.Map<ElementoPumpEntity>(addmodel);
            if (_repositoryElemento.InsertElemento(elementoAdd))
            {
                return Accepted();
            }
            
            return NotFound();
        }
    
        /// <summary>
        /// Deletando produto (elemento) gym
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_repositoryElemento.DeleteElemento(id))
            {
                return NoContent();
            }

            return NotFound();
        }
   
        [HttpPut("id")]
        public IActionResult Update(int id, [FromBody] AtualizarElementoPumpViewModel atualizamodel)
        {
            var buscaModel = _repositoryElemento.GetElementoId(id);
            buscaModel = _mapper.Map(atualizamodel, buscaModel);

            if(buscaModel != null && _repositoryElemento.UpdateElemento(buscaModel))
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}