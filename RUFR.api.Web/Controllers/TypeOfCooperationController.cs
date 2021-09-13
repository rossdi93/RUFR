using Microsoft.AspNetCore.Mvc;
using RUFR.Api.Model.Models;
using System;
using System.Linq;
using RUFR.Api.Service.Interfaces;

namespace RUFR.Api.Web.Controllers
{
    [Route("api/TypeOfCooperation")]
    [ApiController]
    public class TypeOfCooperationController : ControllerBase
    {
        private readonly ITyperOfCooperationService _typerOfCooperationService;

        public TypeOfCooperationController(ITyperOfCooperationService typerOfCooperationService)
        {
            _typerOfCooperationService = typerOfCooperationService;
        }

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_typerOfCooperationService.Select().ToList());
        }

        /// <summary>
        /// Получение по id конктретной сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_typerOfCooperationService.GetById(id));
        }

        /// <summary>
        /// Добавление новой сущности
        /// </summary>
        /// <param name="typeOfCooperation"></param>
        /// <returns></returns>
        [HttpPost("New")]
        public IActionResult New([FromBody] TypesOfCooperationModel typeOfCooperation)
        {
            TypesOfCooperationModel newTypeOfCooperation = _typerOfCooperationService.Create(typeOfCooperation);

            return Ok(newTypeOfCooperation);
        }

        /// <summary>
        /// Обновление сущетсвующего сущности
        /// </summary>
        /// <param name="typeOfCooperation"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update([FromBody] TypesOfCooperationModel typeOfCooperation)
        {
            if (_typerOfCooperationService.GetById(typeOfCooperation.Id) != null)
            {
                return NotFound(typeOfCooperation);
            }

            try
            {
                TypesOfCooperationModel oldTypeOfCooperation = _typerOfCooperationService.GetById(typeOfCooperation.Id);
                oldTypeOfCooperation = typeOfCooperation;
                _typerOfCooperationService.Update(oldTypeOfCooperation);

                return Ok(oldTypeOfCooperation);

            }
            catch (Exception)
            {

                throw;
            }

        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var typeOfCooperation = _typerOfCooperationService.GetById(id);
            if (!typeOfCooperation.IsDelete)
            {
                typeOfCooperation.IsDelete = true;
                try
                {
                    _typerOfCooperationService.Update(typeOfCooperation);
                    return Ok();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
